using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;
using Sagep.Domain.Models.DataTable;

namespace Sagep.Domain.Interfaces
{
    public interface IDisciplinaRepository : IRepository<Disciplina>
    {
        IEnumerable<Disciplina> GetAllWithIncludes();
        Int64 GetTotalAtivos();
        Int64 GetTotalInativos();
        Int64 GetTotalWithIgnoreQueryFilter();
    }
}