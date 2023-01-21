using System;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Sagep.Application.Resolvers
{
    public class TenantResolver
    {
        public static bool TryGetTenantIdAsync(out Guid result)
        {
            StringBuilder tenantId = new StringBuilder();
            var _httpContext = new HttpContextAccessor();
            try
            {
                tenantId.Append(_httpContext.HttpContext.Session.GetString("TenantId"));
            }
            catch (InvalidOperationException ex) { throw ex; }

            return Guid.TryParse(tenantId.ToString(), out result);
        }
    }
}