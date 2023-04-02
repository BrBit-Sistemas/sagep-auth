using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Sagep.Application.ViewModels;

namespace Sagep.Application.Interfaces
{
    public interface IHubConnectionCarceragemAppService
    {
        Task<IEnumerable<DetentoViewModel>> GetAllAsync();
    }
}