using Sagep.Domain.Interfaces;
using Sagep.Infra.Data.Extensions;

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
            string tenantIdentifier = context?.Session?.GetString("TenantId") ?? string.Empty;
            Console.WriteLine($"?Identifier é => {tenantIdentifier}");
            if (string.IsNullOrEmpty(tenantIdentifier))
            {
                var apiKey = context?.Request?.Headers["X-Api-Key"].FirstOrDefault() ?? string.Empty;
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
                            context?.Session.SetString("TenantId", tenantIdNew?.ToString() ?? string.Empty);
                        }
                    }
                }
            }

            if (context != null) await next.Invoke(context);
        }
    }
}