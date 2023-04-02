using Microsoft.AspNetCore.Authorization;

namespace Sagep.Api.SecutiryExtensions
{
    public class PermissionsRequirement : IAuthorizationRequirement
    {
        public string Permission { get; }

        public PermissionsRequirement(string permission)
        {
            Permission = permission;
        }
    }
}