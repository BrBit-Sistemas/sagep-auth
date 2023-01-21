using System.Security.Claims;
using System;
using Microsoft.AspNetCore.Http;

namespace Sagep.Domain.Security
{
    public interface IUserProvider
    {
        string GetId();
        Guid GetGuidId();
    }

    public class UserProvider : IUserProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetId()
        {
            String userId = string.Empty;
            try
            {
                userId = _httpContextAccessor?.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            }
            catch { throw; }

            return userId;
        }

        public Guid GetGuidId()
        {
            String userId = string.Empty;
            try
            {
                userId = _httpContextAccessor?.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            }
            catch { throw; }

            Guid userGuidId = Guid.Empty;
            try
            {
                Guid.TryParse(userId, out userGuidId);
            }
            catch { throw; }

            return userGuidId;
        }
    }
}
