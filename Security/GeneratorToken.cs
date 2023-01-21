using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using Sigesp.Domain.Models;

namespace SigespWeb.Api.Security
{
    public class GeneratorToken
    {
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
                    claims.Add(new Claim(ClaimTypes.Name, appUser?.UserName));
                    
                    // ** Implementar as entidades de grupo de usuário, e que mais
                    // ** for necessário para realizar a implementação abaixo


                    // try
                    // {
                    //     foreach (var aUg in appUser.ApplicationUserGroups)
                    //     {
                    //         foreach (var aRg in aUg.ApplicationGroup.ApplicationRoleGroups.Select(x => x.ApplicationRole.Name))
                    //         {
                    //             claims.Add(new Claim(ClaimTypes.Role, aRg));
                    //         }
                    //     }    
                    // }
                    // catch { throw; }
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
    }
}
