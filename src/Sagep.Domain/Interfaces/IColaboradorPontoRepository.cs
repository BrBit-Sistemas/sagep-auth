using System;
using Sagep.Domain.Models;

namespace Sagep.Domain.Interfaces
{
    public interface IColaboradorPontoRepository : IRepository<ColaboradorPonto> 
    {
        bool IsAlreadyDataInicioDataFimEmpresaConvenio(DateTime dataInicio,
                                                                  DateTime dataFim,
                                                                  Guid empresaConvenioId);
    }
}