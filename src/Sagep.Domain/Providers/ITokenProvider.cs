using System.Text;
using System.Collections.Generic;
using System.Security.Claims;
using Sagep.Domain.Models;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Sagep.Domain.Security
{
    public interface ITokenProvider
    {
        string GetToken(ApplicationUser appUser);
        string GetTokenFromHttpContext();
        string GetUserIdFromToken();
    }

    public class TokenProvider : ITokenProvider
    {
        private readonly IHttpContextAccessor _httpContextAcessor;
        private readonly ILogger<TokenProvider> _logger;

        public TokenProvider(IHttpContextAccessor httpContextAcessor,
                             ILogger<TokenProvider> logger)
        {
            _httpContextAcessor = httpContextAcessor;
            _logger = logger;
        }

        public string GetToken(ApplicationUser appUser)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Settings.Secret);
            
            ClaimsIdentity getClaimsIdentity()
            {
                return new ClaimsIdentity(getClaims());
                Claim[] getClaims()
                {
                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, appUser.Id));
                    claims.Add(new Claim(ClaimTypes.Name, appUser.UserName));
                    
                    try
                    {
                        foreach (var aUg in appUser.ApplicationUserGroups.Where(x => !x.ApplicationGroup.IsDeleted).ToList())
                        {
                            foreach (var aRg in aUg.ApplicationGroup.ApplicationRoleGroups.Select(x => x.ApplicationRole.Name))
                            {
                                claims.Add(new Claim(ClaimTypes.Role, aRg));
                            }
                        }    
                    }
                    catch { throw; }
                    return claims.ToArray();
                }
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = getClaimsIdentity(),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            String tokenResult;
            try
            {
                var token = tokenHandler.CreateToken(tokenDescriptor);
                if (token == null)
                    throw new Exception("Problemas ao obter o token. Tente novamente, persistindo o problema informe a equipe do sistema.");
                
                tokenResult = tokenHandler.WriteToken(token);
            }
            catch { throw; }

            return tokenResult;
        }
        public string GetTokenFromHttpContext()
        {
            String token = string.Empty;
            try
            {
                token = _httpContextAcessor?.HttpContext?.Request?.Headers["Authorization"];
            }
            catch { throw; }

            if (!string.IsNullOrEmpty(token))
            {
                token = token?.Replace("Bearer ", "");
            }

            return token;
        }
        public string GetUserIdFromToken()
        {
            string token = GetTokenFromHttpContext();

            if (string.IsNullOrEmpty(token))
            {
                _logger.LogError($"Não foi possível obter Token: {token}");
                throw new ArgumentException(nameof(token));
            }

            var pureToken = token;
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = new JwtSecurityToken();
            try
            {
                jwtSecurityToken = handler.ReadJwtToken(token);
            }
            catch { throw; }

            String userId = string.Empty;
            try
            {
                userId = jwtSecurityToken?.Payload["nameid"]?.ToString() ?? string.Empty;
            }
            catch { throw; }

            return userId;
        }
    }
}
