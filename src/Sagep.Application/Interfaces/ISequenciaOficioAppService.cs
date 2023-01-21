using System;
using Sagep.Application.ViewModels;

namespace Sagep.Application.Interfaces
{
    public interface ISequenciaOficioAppService : IDisposable
    {
        SequenciaOficioViewModel CriarNova();
    }
}