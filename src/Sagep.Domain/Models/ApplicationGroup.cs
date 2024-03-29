using System.Collections.Generic;

namespace Sagep.Domain.Models
{
    public class ApplicationGroup : EntityAuditTenant
    {        
        public ApplicationGroup(string name,
                                string uniqueKey)
        {
            Name = name;
            UniqueKey = uniqueKey;
        }

        // Constructor empty for EF
        public ApplicationGroup() {}

        public string Name { get; set; }
        public string UniqueKey { get; set; }

        // Relationships
        public Tenant Tenant { get; set; }

        public ICollection<ApplicationRoleGroup> ApplicationRoleGroups { get; set; }
        public ICollection<ApplicationUserGroup> ApplicationUserGroups { get; set; }
    }
}