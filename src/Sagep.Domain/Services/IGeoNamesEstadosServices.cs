using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using Sagep.Domain.Models.Services;

namespace Sagep.Domain.Services
{
    public interface IGeoNamesEstadosServices
    {
        [Get("/childrenJSON?geonameId=3469034")]
        Task<GeoNamesEstadosModel> GetAllEstados();
    }
}