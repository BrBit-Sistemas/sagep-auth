using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;

namespace Sagep.Domain.Interfaces
{
    public interface IDetentoSaidaTemporariaRepository : IRepository<DetentoSaidaTemporaria>
    {
        IEnumerable<DetentoSaidaTemporaria> GetAllByDetentoIpen (int ipen);
        void RemoveAll(IEnumerable<DetentoSaidaTemporaria> detentosST);
        IEnumerable<DetentoSaidaTemporaria> GetAllByFilterReportSaidasPrevistas(DateTime dataInicio,
                                                                                 DateTime dataFim,
                                                                                 string opt);
    }
}