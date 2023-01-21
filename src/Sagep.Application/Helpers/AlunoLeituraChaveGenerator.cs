using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sagep.Domain.Interfaces;
using Sagep.Infra.Data.Context;
using Sagep.Infra.Data.Extensions;

namespace Sagep.Application.Helpers
{
    public class AlunoLeituraChaveGenerator
    {
        private readonly SigespDbContext _context;
        private readonly ITenantRepository _tenantRepository;

        public AlunoLeituraChaveGenerator(SigespDbContext context,
                                          ITenantRepository tenantRepository)
        {
            _context = context;
            _tenantRepository = tenantRepository;
        }

        public async Task<Int64> GenerateNextChaveLeituraAsync(Guid tenantId)
        {   
            var lastKey = new List<Int64>();
            try
            {
                lastKey = await _context
                                    .AlunosLeituras
                                    .Where(x => x.Tenant.Id == tenantId)
                                    .Select(x => x.ChaveLeitura)
                                    .ToListAsync();
            } catch { throw; }

            var nextChaveLeitura = 0;
            if (lastKey.Count() > 0)
            {
                var tmp = (int)(lastKey.Max() + 1);
                nextChaveLeitura = tmp;
            }
            else
            {
                nextChaveLeitura = 1;
            }

            return nextChaveLeitura;
        }
    }
}