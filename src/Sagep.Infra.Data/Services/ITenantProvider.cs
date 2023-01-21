using System;
using Microsoft.AspNetCore.Http;

namespace Sagep.Infra.Data.Services
{
    public interface ITenantProvider
    {
        Guid GetTenantId();
    }

    public class TenantProvider : ITenantProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public TenantProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Guid GetTenantId()
        {
            String tenantIdString;
            try
            {
                tenantIdString = _httpContextAccessor.HttpContext.Session.GetString("TenantId");
            }
            catch { throw; }

            Guid tenantIdGuid;
            try
            {
                Guid.TryParse(tenantIdString, out tenantIdGuid);
            }
            catch { throw; }
            
            return tenantIdGuid;
        }
    }
}