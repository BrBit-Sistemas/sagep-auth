using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Sagep.Application.Interfaces;
using System.ComponentModel.DataAnnotations;
using NetDevPack.Domain;

namespace Sagep.Api.Controllers.v1
{
    [Authorize(Roles = "Master, CanHubConnectionCarceragemAccess")]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/hub-connection/carceragem")]
    public class HubConnectionCarceragemController : ApiController
    {
        private readonly ILogger<HubConnectionCarceragemController> _logger;
        private readonly IHubConnectionCarceragemAppService _hubConnectionCarceragemAppService;

        public HubConnectionCarceragemController(ILogger<HubConnectionCarceragemController> logger,
                                                 IHubConnectionCarceragemAppService hubConnectionCarceragemAppService)
        {
            _logger = logger;
            _hubConnectionCarceragemAppService = hubConnectionCarceragemAppService;
        }

        /// <summary>
        /// Obtém todos os detentos do microservice sagep-carceragem
        /// </summary>
        /// <returns>Um array json com os detentos</returns>
        /// <response code="200">Lista de detentos</response>
        /// <response code="400">Problemas de validação ou dados nulos</response>
        /// <response code="404">Lista vazia</response>
        /// <response code="500">Erro desconhecido</response>
        [Authorize(Roles = "Master, CanDetentoList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [HttpGet]
        public async Task<IActionResult> DetentoListAsync()
        {
            try
            {
                var result = await _hubConnectionCarceragemAppService.GetAllAsync();
                _logger.LogInformation($"{result}");

                return Ok(new {
                    AllData = result.ToList(),
                    Detentos = result.ToList(),
                    Params = "",
                    Total = result.Count()
                });
            }
            catch (ValidationException ex)
            {
                _logger.LogError($"Error processing route request: {ex.Message}", ex);
                return BadRequest($"Error processing route request: {ex.Message}");
            }
            catch (DomainException ex)
            {
                _logger.LogError($"Error processing route request: {ex.Message}", ex);
                return BadRequest($"Error processing route request: {ex.Message}");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error processing route request: {ex.Message}", ex);
                return CustomResponse(500, $"Error processing route request: {ex.Message}");
            }
        }
    }
}