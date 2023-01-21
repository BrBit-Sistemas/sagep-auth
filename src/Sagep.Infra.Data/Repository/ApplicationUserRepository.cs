using System;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Sagep.Domain.Interfaces;
using Sagep.Domain.Models;
using Sagep.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Sagep.Infra.Data.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(SagepAppDbContext context)
        : base(context)
        {
        }
        
        public async Task<ApplicationUser> GetByIdWithTenant(string id) 
        {
            return await DbSet
                            .Include(x => x.Tenant)
                            .FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
    }    
}
