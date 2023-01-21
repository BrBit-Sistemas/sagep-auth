using Microsoft.AspNetCore.Identity;

namespace Sagep.Domain.Models
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ApplicationRole ApplicationRole { get; set; }
    }
}