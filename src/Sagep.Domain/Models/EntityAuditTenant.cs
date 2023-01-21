using System;

namespace Sagep.Domain.Models
{
    public abstract class EntityAuditTenant : Entity
    {
        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
        public Guid TenantId { get; set; }
    }
}