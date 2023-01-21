using System;
using System.Threading.Tasks;
using Sagep.Domain.Models;

namespace Sagep.Domain.Interfaces
{
    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
        Task<ApplicationUser> GetByIdWithTenant(string id);
    }
}