using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;

namespace Sagep.Domain.Interfaces
{
    public interface ISequenciaOficioRepository : IRepository<SequenciaOficio>
    {
        IEnumerable<int> GetSequencias(Guid tenantId, SetorEnum setor);
    }
}