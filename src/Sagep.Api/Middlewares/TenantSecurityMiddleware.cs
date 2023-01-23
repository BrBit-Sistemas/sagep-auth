using Sagep.Domain.Interfaces;
using Sagep.Domain.Models;
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
                                 IApplicationUserRepository _applicationUserRepository,
                                 ILogger<TenantSecurityMiddleware> _logger,
                                 IUserProvider _userProvider)
        {
            String tenantIdentifier = string.Empty;
            try
            {
                tenantIdentifier = _httpContext?.Session?.GetString("TenantId") ?? string.Empty;
                _logger.LogInformation($"Identifier é => {tenantIdentifier}");
            }
            catch { throw; }
            
            if (string.IsNullOrEmpty(tenantIdentifier))
            {
                string userId = _userProvider.GetId();
                _logger.LogInformation($"UserId => {userId}");

                if (!string.IsNullOrEmpty(userId)) 
                {
                    var user = new ApplicationUser();
                    try
                    {
                        user = await _applicationUserRepository.GetByIdWithTenant(userId);
                    }
                    catch { throw; }
                    
                    if (user != null && user.Tenant != null)
                    {
                        _httpContext?.Session.SetString("TenantId", user?.Tenant?.Id.ToString() ?? string.Empty);
                        _logger.LogInformation($"TenantId to session is => {user?.Tenant.Id}");
                    }
                } else
                {
                    _logger.LogInformation($"Usuário fazendo acesso a método não protegido [AllowAnonymous], e não está passando token na request. Portanto, não está sendo possível obter a tenancy, uma vez que não é possível obter o usuário.");
                }
            }

            if (_httpContext != null) await next.Invoke(_httpContext);
        }
    }
}