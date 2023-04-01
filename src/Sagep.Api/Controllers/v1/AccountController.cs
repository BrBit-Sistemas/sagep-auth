using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Sagep.Domain.Models;
using Sagep.Infra.Data.Context;
using Sagep.Application.ViewModels;
using Sagep.Domain.Enums;
using Sagep.Api.Helpers;
using Sagep.Domain.Security;

namespace Sagep.Api.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/account")]
    public class AccountController : ApiController
    {
        private readonly ILogger<AccountController> _logger;
        private readonly ITokenProvider _tokenProvider;
        private readonly SagepAppDbContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IUserProvider _userProvider;
        private readonly IHttpContextAccessor _httpContextAcessor;

        public AccountController(ILogger<AccountController> logger,
                                ITokenProvider tokenProvider,
                                SagepAppDbContext context,
                                SignInManager<ApplicationUser> signInManager,
                                UserManager<ApplicationUser> userManager,
                                IMapper mapper,
                                IUserProvider userProvider,
                                IHttpContextAccessor httpContextAcessor)
        {
            _logger = logger;
            _tokenProvider = tokenProvider;
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _mapper = mapper;
            _userProvider = userProvider;
            _httpContextAcessor = httpContextAcessor;
        }

        /// <summary>
        /// Autentica um usuário e retorna seus dados
        /// </summary>
        /// <param name="authenticateViewModel"></param>
        /// <returns>Um json com os dados do usuário autenticado</returns>
        /// <response code="200">Dados do usuário autenticado</response>
        /// <response code="400">Não passou nas validações ou dados de usuário null</response>
        /// <response code="404">Usuário não encontrado</response>
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Route("authenticate")]
        [HttpPost]
        public async Task<IActionResult> AuthenticateAsync([FromBody]AuthenticateViewModel authenticateViewModel)
        {
            #region SignIn resolve
            // does sigin
            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger acocunt lockout, set lockoutOnFailure: true
            var sigIn = new Microsoft.AspNetCore.Identity.SignInResult();
            try
            {
                sigIn = await _signInManager
                                .PasswordSignInAsync(authenticateViewModel.Email,
                                                        authenticateViewModel.Password,
                                                        authenticateViewModel.RememberMe,
                                                        lockoutOnFailure: true);
                #region Checks
                if (sigIn.IsLockedOut)
                {
                    _logger.LogWarning("Usuário bloqueado.");

                    AddError("Usuário bloqueado. \nAguarde 1 minuto e tente novamente. Caso persista, solicite o desbloqueio ao administrador do sistema.");
                    return CustomResponse(400);
                } else if (sigIn.IsNotAllowed) {
                    _logger.LogWarning("E-mail não confirmado.");

                    AddError("E-mail não confirmado. Check seu e-mai de confirmação, caso o problema persista, solicite novamente um e-mail de verificação.");
                    return CustomResponse(400);
                } else if (sigIn.RequiresTwoFactor) {
                    _logger.LogWarning("Você ativou a autenticação de dois fatores.");

                    AddError("Você ativou a autenticação de dois fatores. Portanto, faça login nesta condição.");
                    return CustomResponse(400);
                } else if (!sigIn.Succeeded) {
                    _logger.LogWarning("Usuário ou senha inválidos.");

                    AddError("Usuário ou senha inválidos.");
                    return CustomResponse(400);
                }
                #endregion
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }
            #endregion
            
            #region User resolve and news validations
            var user = new ApplicationUser();
            try
            {
                user = await _context
                                    .Users
                                    .Include(x => x.ApplicationUserGroups)
                                    .ThenInclude(x => x.ApplicationGroup)
                                    .ThenInclude(x => x.ApplicationRoleGroups)
                                    .ThenInclude(x => x.ApplicationRole)
                                    .FirstOrDefaultAsync(x => x.Email == authenticateViewModel.Email);
            }
            catch (Exception ex) 
            { 
                _logger.LogWarning(ex.Message);

                AddErrorToTryCatch(ex);
                return CustomResponse(500); 
            }

            if (user == null)
            {
                _logger.LogWarning("Usuário não encontrado.");

                AddError("Usuário não encontrado.");
                return CustomResponse(404);
            }

            // check to user inactive
            if (user.Status == ApplicationUserStatusEnum.INACTIVE)
            {
                _logger.LogWarning("Usuário inativo.");

                AddError("Usuário inativo."+ "\nPara fazer login solicite ao administrador a ativação de seu usuário.");
                return CustomResponse(400);
            }

            // check to user pending active
            if (user.Status == ApplicationUserStatusEnum.PENDING)
            {
                _logger.LogWarning("Usuário pendente de ativação.");

                AddError("Usuário pendente de ativação."+ "\nPara fazer login solicite ao administrador a ativação de seu usuário.");
                return CustomResponse(400);
            }
            #endregion

            // check to groups inactives
            if (user.ApplicationUserGroups.Count(x => !x.ApplicationGroup.IsDeleted) <= 0)
            {
                _logger.LogWarning("Usuário sem grupo ativo vinculado que permita acesso.");

                AddError("Usuário sem grupo ativo vinculado que permita acesso.\nSolicite ao usuário master da sua empresa para vincular seu usuário a outro grupo ativo, ou ativar ao menos um grupo já vinculado ao seu usuário.");
                return CustomResponse(400);
            }

            #region Map
            var userMapped = new ApplicationUserViewModel();
            try
            {
                userMapped = _mapper.Map<ApplicationUserViewModel>(user);
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }
            #endregion

            #region Get token
            String token;
            try
            {
                token = _tokenProvider.GetToken(user);
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }

            if (string.IsNullOrEmpty(token))
            {
                _logger.LogWarning("Problemas ao obter token.");

                AddError("Problemas ao obter token. Tente novamente, persistindo o problema informe a equipe de suporte.");
                return CustomResponse(400);
            } 
            else
            {
                userMapped.AccessToken = token;
            }
            
            #endregion

            return Ok(new { userData = userMapped });
        }

        /// <summary>
        /// Lista os dados do usuário logado
        /// </summary>
        /// <param></param>
        /// <returns>Um json com os dados de usuário</returns>
        /// <response code="200">Lista dos dados do usuário logado</response>
        /// <response code="400">Lista nula</response>
        /// <response code="404">Lista vazia</response>
        [Authorize(Roles = "Master, CanUserRead, CanUserAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces("application/json")]
        [Route("me")]
        [HttpGet]
        public async Task<IActionResult> MeAsync()
        {
            var a = _httpContextAcessor?.HttpContext?.Session.GetString("TenantId");
            #region UserId resolve
            String userId = string.Empty;
            try
            {
                userId = _userProvider.GetId();
            }
            catch { throw; }
            
            if (string.IsNullOrEmpty(userId))
            {
                return CustomResponse(400, new { message = "Não foi possível obter o id do usuário. \nTente novamente, caso o problema persista acione a equipe de suporte." });
            }

            var user = new ApplicationUser();
            try
            {
                user = await _context
                                    .Users
                                    .Include(a => a.ApplicationUserGroups)
                                        .ThenInclude(b => b.ApplicationGroup)
                                            .ThenInclude(c => c.ApplicationRoleGroups)
                                                .ThenInclude(d => d.ApplicationRole)
                                    .FirstOrDefaultAsync(x => x.Id == userId);
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }

            if (user == null)
                return CustomResponse(404, new { message = "Nenhum registro encontrado." });
            #endregion

            #region Generals validations
            // check to groups inactives
            if (user.ApplicationUserGroups.Count(x => !x.ApplicationGroup.IsDeleted) <= 0)
            {
                AddError("Usuário sem grupo ativo vinculado que permita acesso.\nSolicite ao usuário master da sua empresa para vincular seu usuário a outro grupo ativo, ou ativar ao menos um grupo já vinculado ao seu usuário.");
                return CustomResponse(400);
            }
            #endregion

            #region Map
            var userMapped = new ApplicationUserViewModel();
            try
            {
                userMapped = _mapper.Map<ApplicationUserViewModel>(user);
                userMapped.AccessToken = _tokenProvider.GetTokenFromHttpContext();
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }

            // map manually roles
            userMapped.Roles = new List<string>();
            try
            {
                userMapped.Roles = MapperHelpers.MapFromTwoDepths(user.ApplicationUserGroups.Select(x => x.ApplicationGroup.ApplicationRoleGroups.Select(x => x.ApplicationRole.Name)));
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }
            #endregion

            return Ok(new { userData = userMapped });
        }
    }
}