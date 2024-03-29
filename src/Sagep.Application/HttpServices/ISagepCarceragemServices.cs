using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using Sagep.Application.ViewModels;

namespace Sagep.Application.HttpServices
{
    public interface ISagepCarceragemServices
    {
        /// <summary>
        /// Obtém uma lista de detentos do microservice sagep-carceragem
        /// </summary>
        /// <param name="apiKey"></param>
        /// <returns>Retorna um array json com uma lista de detentos.</returns>
        /// <response code="200">Retorna sucesso com um array json com os detentos.</response>
        /// <response code="404">Nenhuma detento encontrada.</response>
        /// <response code="400">Problemas de validação ou dados nulos</response>
        /// <response code="500">Erro interno desconhecido</response>
        [Get("/detentos/list")]
        [Headers("Content-Type: application/json")]
        Task<IList<DetentoLegadoViewModel>> GetAllAsync([Header("Authorization")] string apiKey = null);
    }
}