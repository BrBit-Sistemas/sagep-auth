using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sagep.Application.Interfaces;
using Sagep.Application.ViewModels;
using Sagep.Domain.Security;

namespace Sagep.Api.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/navigation")]
    public class NavigationController : ApiController
    {
        private readonly INavigationAppService _navigationManager;
        private readonly IUserProvider _userProvider;


        public NavigationController(INavigationAppService navigationManager,
                                    IUserProvider userProvider) 
        { 
            _navigationManager = navigationManager;
            _userProvider = userProvider;
        }

        /// <summary>
        /// Lista as opções de menu do usuário
        /// </summary>
        /// <param></param>
        /// <returns>Um json com os itens de menu</returns>
        /// <response code="200">Lista de itens</response>
        /// <response code="400">Lista nula</response>
        /// <response code="404">Lista vazia</response>
        [Authorize(Roles = "Master, CanUserRead, CanUserAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces("application/json")]
        [Route("my-menu")]
        [HttpGet]
        public async Task<IActionResult> MyMenuAsync()
        {
            #region User resolve
            String userId;
            try
            {
                userId = _userProvider.GetId();
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }

            if (string.IsNullOrEmpty(userId))
                throw new ArgumentNullException(nameof(userId));
            #endregion

            IEnumerable<VerticalNavItemViewModel> result = new List<VerticalNavItemViewModel>();
            try
            {
                result = await _navigationManager.MyMenuAsync(userId);
            }
            catch (Exception ex) { AddErrorToTryCatch(ex); return CustomResponse(500); }
            return CustomResponse(200, result);
        }
    }
}