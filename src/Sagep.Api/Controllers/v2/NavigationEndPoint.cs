using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Sagep.Api.Controllers.v2;
using Sagep.Application.Interfaces;
using Sagep.Application.ViewModels;

namespace BoxBack.WebApi.EndPoints
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/navigation")]
    public class NavigationEndPoint : ApiController
    {
        private readonly INavigationAppService _navigationManager;
        private readonly IHttpContextAccessor _httpCA;
        public NavigationEndPoint(INavigationAppService navigationManager, IHttpContextAccessor httpCA) 
        { 
            _navigationManager = navigationManager;
            _httpCA = httpCA;
        }

        /// <summary>
        /// Lista as opções de menu do usuário
        /// </summary>
        /// <param></param>
        /// <returns>Um json com os itens de menu</returns>
        /// <response code="200">Lista de itens</response>
        /// <response code="400">Lista nula</response>
        /// <response code="404">Lista vazia</response>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [Route("my-menu")]
        [HttpGet]
        public async Task<IActionResult> MyMenuAsync()
        {
            #region User resolve
            String userId;
            try
            {  
                userId = _httpCA?.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
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