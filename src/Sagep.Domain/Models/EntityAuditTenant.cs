using System;

namespace Sagep.Domain.Models
{
    public abstract class EntityAuditTenant : Entity
    {
        public DateTimeOffset CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
        public Guid TenantId { get; set; }
    }
}