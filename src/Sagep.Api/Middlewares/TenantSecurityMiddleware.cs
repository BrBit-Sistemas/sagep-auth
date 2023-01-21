using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Sagep.Domain.Interfaces;
using Sagep.Infra.Data.Extensions;
using Sagep.Infra.Data.Repository;

namespace SigespWeb.Api.Middlewares
{
    public class TenantSecurityMiddleware 
    {
        private readonly RequestDelegate next;
        
        public TenantSecurityMiddleware(RequestDelegate next) 
        {
            this.next = next;
        }
        
        public async Task Invoke(HttpContext context,
                                 IConfiguration configuration,
                                 IHttpContextAccessor httpContextAccessor,
                                 ITenantRepository _tenantRepository)
        {
            string tenantIdentifier = context.Session.GetString("TenantId");
            Console.WriteLine($"?Identifier é => {tenantIdentifier}");
            if (string.IsNullOrEmpty(tenantIdentifier))
            {
                var apiKey = context.Request.Headers["X-Api-Key"].FirstOrDefault();
                if (!string.IsNullOrEmpty(apiKey)) 
                {
                    Guid apiKeyGuid;
                    if (Guid.TryParse(apiKey, out apiKeyGuid))
                    {
                        string tenantId = await _tenantRepository
                                                        .GetTenantIdAsync(apiKeyGuid);
                        Console.WriteLine($"ApiKey é => {tenantId}");
                        if (!string.IsNullOrEmpty(tenantId))
                        {
                            var tenantIdNew = StringHelpers
                                                .ExtractTenantId(tenantId);
                            context.Session.SetString("TenantId", tenantIdNew.ToString());
                        }
                    }
                }
            }
            await next.Invoke(context);
        }
    }
}