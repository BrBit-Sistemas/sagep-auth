using System.Data;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Domain.Interfaces;
using Sagep.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;
using Sagep.Domain.Models.DataTable;
using Sagep.Infra.Data.Extensions.DataTable;

namespace Sagep.Infra.Data.Repository
{
    public class AndamentoPenalRepository : Repository<AndamentoPenal>, IAndamentoPenalRepository
    {
        private readonly ITenantRepository _tenantRepository;

        public AndamentoPenalRepository(SigespDbContext context,
                                        ITenantRepository tenantRepository)
            : base(context)
        {
            _tenantRepository = tenantRepository;
        }

        public AndamentoPenal GetByDetentoNome(string nome)
        {
            var andamentoPenal = DbSet
                                    .Include(x => x.Detento)
                                    .Where(x => x.Detento.Nome == nome)
                                    .FirstOrDefault();

            return andamentoPenal;
        }

        public AndamentoPenal GetByDetentoIpen(int ipen)
        {
            var andamentoPenal = DbSet
                                .Include(x => x.Detento)
                                .Where(x => x.Detento.Ipen == ipen)
                                .Where(x => !x.IsDeleted)
                                .FirstOrDefault();

            return andamentoPenal;
        }

        public AndamentoPenal GetByDetentoId(Guid id)
        {
            var andamentoPenal = DbSet
                                    .AsNoTracking()
                                    .IgnoreQueryFilters()
                                    .Include(x => x.Detento)
                                    .Include(x => x.Tenant)
                                    .Where(x => x.Detento.Id == id)
                                    .FirstOrDefault();

            return andamentoPenal;
        }

        public async Task<DataTableServerSideResult<AndamentoPenal>> GetWithDataTableResultAsync(DataTableServerSideRequest request)
        {
            var andamentoPenalForDataTable = await DbSet
                                                    .AsNoTracking()
                                                    .Include(x => x.Detento)
                                                    .Where(x => !x.IsDeleted)
                                                    .OrderBy(x => x.DataEventoPrincipal)
                                                    .GetDatatableResultAsync(request);
            return andamentoPenalForDataTable;
        }

        public async Task<IEnumerable<AndamentoPenal>> GetAllOnlyIsDeletedTrue()
        {
            var andamentoPenal = await DbSet
                                            .Include(x => x.Detento)
                                            .Where(d => d.Detento.IsDeleted == true)
                                            .ToListAsync();

            return andamentoPenal;
        }

        public IEnumerable<AndamentoPenal> GetAllWithIgnoreFilter()
        {
             var andamentoPenal = DbSet
                                    .Include(x => x.Detento)
                                    .Where(d => !d.IsDeleted)
                                    .ToList();

            return andamentoPenal;
        }

        public IEnumerable<AndamentoPenal> GetAllWithInclude()
        {
             var andamentoPenal = DbSet
                                    .Include(x => x.Detento)
                                    .Where(d => !d.IsDeleted)
                                    .ToList();

            return andamentoPenal;
        }

        public AndamentoPenal GetByIdWithIgnoreFilter(Guid id)
        {
            var andamentoPenal = DbSet
                                    .FirstOrDefault(x => x.Id == id);

            return andamentoPenal;
        }

        public AndamentoPenal GetByIdWithInclude(Guid id)
        {
            var andamentoPenal = DbSet
                                    .IgnoreQueryFilters()
                                    .Include(x => x.Detento)
                                    .Where(x => x.IsDeleted == false && x.Id == id)
                                    .FirstOrDefault();
            
            return andamentoPenal;

        }

        public Int64 GetTotalByStatus(AndamentoPenalStatusEnum status)
        {
            var total = DbSet
                            .Where(x => !x.IsDeleted)
                            .Count(e => EF.Property<AndamentoPenalStatusEnum>(e, "Status") == status);
            
            return total;
        }

        public Int64 GetTotal()
        {
            var total = DbSet
                            .Count(x => !x.IsDeleted);
            return total;
        }

        public bool AlreadyAtivoByIpen(int ipen)
        {
            var alreadyAtivoByIpen = DbSet
                                        .Include(x => x.Detento)
                                        .Any(x => x.Detento.Ipen == ipen);
            return alreadyAtivoByIpen;
        }

        public AndamentoPenal RescueInactiveByIpen(int ipen)
        {
            var rescueInactiveByIpen = DbSet
                                        .AsNoTracking()
                                        .IgnoreQueryFilters()
                                        .Include(x => x.Detento)
                                        .Where(x => x.IsDeleted == true
                                               && x.Detento.Ipen == ipen)
                                        .FirstOrDefault();
                                        
            return rescueInactiveByIpen;
        }

        public AndamentoPenal GetByIdWithouIncludes(Guid id)
        {
            var result = DbSet
                            .AsNoTracking()
                            .FirstOrDefault(x => x.Id == id);
            
            return result;
        }
    }
}