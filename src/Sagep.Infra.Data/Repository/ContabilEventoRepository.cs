using System;
using System.Linq;
using Sagep.Domain.Models;
using Sagep.Domain.Interfaces;
using Sagep.Infra.Data.Context;
using Sagep.Domain.Models.DataTable;
using Sagep.Infra.Data.Extensions.DataTable;
using System.Threading.Tasks;

namespace Sagep.Infra.Data.Repository
{
    public class ContabilEventoRepository : Repository<ContabilEvento>, IContabilEventoRepository
    {
        public ContabilEventoRepository(SigespDbContext context)
            : base(context)
        {
            
        }

        public int GetTotalActiveRecords()
        {
            var total = DbSet.Count();

            return total;
        }

        public async Task<DataTableServerSideResult<ContabilEvento>> GetAllWithDataTableResultAsync(DataTableServerSideRequest request)
        {
            var contabilEventosForDataTable = await DbSet
                                                    .OrderBy(x => x.Codigo)
                                                    .GetDatatableResultAsync(request);
            return contabilEventosForDataTable;
        }

        public ContabilEvento GetByEspecificacao (string especificacao)
        {
            var contabilEvento = DbSet
                                    .Where(x => x.Especificacao == especificacao)
                                    .FirstOrDefault();
            return contabilEvento;
        }
    }
}