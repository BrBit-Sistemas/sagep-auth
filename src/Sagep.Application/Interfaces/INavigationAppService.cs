using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Application.ViewModels;

namespace Sagep.Application.Interfaces
{
    public interface INavigationAppService
    {
        Task<IEnumerable<VerticalNavItemViewModel>> MyMenuAsync(string userId);
    }
}