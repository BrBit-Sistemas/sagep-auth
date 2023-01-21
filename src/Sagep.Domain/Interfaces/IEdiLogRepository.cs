using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Domain.Models;

namespace Sagep.Domain.Interfaces
{
    public interface IEdiLogRepository : IRepository<EdiLog>
    {
        IEnumerable<EdiLog> GetAllByEdiId(Guid ediId);
    }
}