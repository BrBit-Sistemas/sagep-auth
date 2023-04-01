using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Sagep.Domain.Models;
using Sagep.Infra.Data.Context;
using Sagep.Application.ViewModels;
using Sagep.Domain.Security;
using Sagep.Domain.Interfaces;

namespace Sagep.Api.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/detentos")]
    public class DetentoController : ApiController
    {
        private readonly ILogger<AccountController> _logger;
        private readonly ITokenProvider _tokenProvider;
        private readonly SagepAppDbContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IUserProvider _userProvider;
        private readonly IHttpContextAccessor _httpContextAcessor;
        private readonly IUnitOfWork _unitOfWork;

        public DetentoController(ILogger<AccountController> logger,
                                ITokenProvider tokenProvider,
                                SagepAppDbContext context,
                                SignInManager<ApplicationUser> signInManager,
                                UserManager<ApplicationUser> userManager,
                                IMapper mapper,
                                IUserProvider userProvider,
                                IHttpContextAccessor httpContextAcessor,
                                IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _tokenProvider = tokenProvider;
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _mapper = mapper;
            _userProvider = userProvider;
            _httpContextAcessor = httpContextAcessor;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Lista todos os clientes
        /// </summary>
        /// <returns>Um json com os clientes</returns>
        /// <response code="200">Lista de clientes</response>
        /// <response code="400">Problemas de validação ou dados nulos</response>
        /// <response code="404">Lista vazia</response>
        [Authorize(Roles = "Master, CanClienteList, CanClienteAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces("application/json")]
        [Route("list")]
        [HttpGet]
        public async Task<IActionResult> ListAsync()
        {
            #region Get data
            var detentos = new List<Detento>();
            detentos = await _context.Detentos
                                            .AsNoTracking()
                                            .OrderByDescending(x => x.UpdatedAt)
                                            .ToListAsync();
            #endregion
            
            #region Map
            IEnumerable<DetentoViewModel> detentosMap = new List<DetentoViewModel>();
            try
            {
                detentosMap = _mapper.Map<IEnumerable<DetentoViewModel>>(detentos);
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }
            #endregion
            
            return Ok(new {
                AllData = detentosMap.ToList(),
                Detentos = detentosMap.ToList(),
                Params = "",
                Total = detentosMap.Count()
            });
        }

        [Authorize(Roles = "Master, CanClienteCreate, CanClienteAll")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/json")]
        [Route("create")]
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody]DetentoViewModel detentoViewModel)
        {
            #region Map
            var detentoMap = new Detento();
            try
            {
                detentoMap = _mapper.Map<Detento>(detentoViewModel);
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }
            #endregion

            #region Persistance and commit
            try
            {
                await _context.Detentos.AddAsync(detentoMap);
                _unitOfWork.Commit();
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }
            #endregion

            return CustomResponse(201);
        }
    }
}