using System.Data;
using System;
using System.Linq;
using System.Collections.Generic;
using Sagep.Domain.Interfaces;
using Sagep.Domain.Models;
using Sagep.Infra.Data.Context;
using Sagep.Domain.Enums;

namespace Sagep.Infra.Data.Repository
{
    public class SequenciaOficioRepository : Repository<SequenciaOficio>, ISequenciaOficioRepository
    {
        public SequenciaOficioRepository(SigespDbContext context)
            : base(context)
        {
        }

        public IEnumerable<int> GetSequencias(Guid tenantId, SetorEnum setor)
        {
            IEnumerable<int> result = new List<int>();
            try
            {
                result =  DbSet
                            .Where(x => x.Tenant.Id == tenantId &&
                                   x.Setor == setor &&
                                   x.CreatedAt.Date.Year.Equals(DateTime.Now.Year))
                            .Select(x => x.Sequencia)
                            .ToList();
            }
            catch (Exception ex) { throw ex; }
            return result;
        }
    }
}