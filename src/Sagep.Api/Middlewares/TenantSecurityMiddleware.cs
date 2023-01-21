using Sagep.Domain.Interfaces;
using Sagep.Domain.Security;
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
        
        public async Task Invoke(HttpContext _httpContext,
                                 ITenantRepository _tenantRepository,
                                 ILogger<TenantSecurityMiddleware> _logger,
                                 IUserProvider _userProvider)
        {
            string tenantIdentifier = _httpContext?.Session?.GetString("TenantId") ?? string.Empty;
            string userId = _userProvider.GetId();

            _logger.LogInformation($"UserId é => {userId}");
            _logger.LogInformation($"Identifier é => {tenantIdentifier}");
            
            if (string.IsNullOrEmpty(tenantIdentifier))
            {
                var apiKey = _httpContext?.Request?.Headers["X-Api-Key"].FirstOrDefault() ?? string.Empty;
                if (!string.IsNullOrEmpty(apiKey)) 
                {
                    Guid apiKeyGuid;
                    if (Guid.TryParse(apiKey, out apiKeyGuid))
                    {
                        string tenantId = await _tenantRepository
                                                        .GetTenantIdAsync(apiKeyGuid);

                        _logger.LogInformation($"ApiKey é => {tenantIdentifier}");

                        if (!string.IsNullOrEmpty(tenantId))
                        {
                            var tenantIdNew = StringHelpers
                                                .ExtractTenantId(tenantId);
                            _httpContext?.Session.SetString("TenantId", tenantIdNew?.ToString() ?? string.Empty);
                        }
                    }
                }
            }

            if (_httpContext != null) await next.Invoke(_httpContext);
        }
    }
}