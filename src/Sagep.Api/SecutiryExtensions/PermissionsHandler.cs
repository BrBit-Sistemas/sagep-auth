using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Sagep.Api.SecutiryExtensions
{
    public class PermissionsHandler : AuthorizationHandler<PermissionsRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionsRequirement requirement)
        {
            // Por exemplo, você pode verificar as Claims do usuário
            var userHasPermission = context.User.HasClaim(c => c.Type == "Permission" && c.Value == requirement.Permission);

            if (userHasPermission)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}