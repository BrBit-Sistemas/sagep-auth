using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using Sagep.Domain.Models;

namespace Sagep.Domain.Services
{
    public interface IIBGEServices
    {
        [Get("/")]
        Task<IEnumerable<IBGEEstado>> GetAllEstados();
    }
}