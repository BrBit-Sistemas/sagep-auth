using System;
using Sagep.Application.ViewModels;

namespace Sagep.Application.Interfaces
{
    public interface IEntityToTestAppService : IDisposable
    {
        bool Add(DetentoViewModel viewModel);        
    }
}