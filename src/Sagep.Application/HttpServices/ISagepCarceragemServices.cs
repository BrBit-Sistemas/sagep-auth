using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using Sagep.Application.ViewModels;

namespace Sagep.Application.HttpServices
{
    public interface ISagepCarceragemServices
    {
        [Get("/")]
        Task<IEnumerable<DetentoViewModel>> GetAll();
    }
}