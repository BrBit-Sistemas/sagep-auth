using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using Sagep.Application.ViewModels;

namespace Sagep.Application.HttpServices
{
    public interface ISagepNfseServices
    {
        /// <summary>
        /// Obtém uma lista de notas fiscais do microservice sagep-nfse
        /// </summary>
        /// <param name="apiKey"></param>
        /// <returns>Retorna um array json com uma lista de notas fiscais.</returns>
        /// <response code="200">Retorna sucesso com um array json com as notas fiscais.</response>
        /// <response code="404">Nenhuma nota fiscal encontrada.</response>
        /// <response code="400">Problemas de validação ou dados nulos</response>
        /// <response code="500">Erro interno desconhecido</response>
        [Get("/")]
        [Headers("Content-Type: application/json")]
        Task<IList<NotaFiscalServicoViewModel>> GetAll([Header("Authorization")] string apiKey);
    }
}