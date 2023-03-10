using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Sagep.Domain.Models;
using Sagep.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Sagep.Infra.CrossCutting.Identity.Services;
using System.Reflection;
using System.IO;
using Microsoft.Extensions.DependencyModel;
using Sagep.Infra.Data.Services;
using BoxBack.Infra.Data.Mappings;
using Sagep.Domain.Security;

namespace Sagep.Infra.Data.Context
{
    public class SagepAppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string,
                                                       ApplicationUserClaim, ApplicationUserRole, IdentityUserLogin<string>,
                                                       IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public static Guid Tenant1Id = Guid.Parse("51aab199-1482-4f0d-8ff1-5ca0e7bc525a");
        
        private readonly ITenantProvider _tenantProvider;
        private readonly IUserProvider _userProvider;

        public SagepAppDbContext(DbContextOptions<SagepAppDbContext> options, 
                                ITenantProvider tenantProvider,
                                IUserProvider userProvider)
            : base(options)
        {
            _tenantProvider = tenantProvider;
            _userProvider = userProvider;
        }

        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<ApplicationGroup> ApplicationGroups { get; set; }
        public DbSet<ApplicationRoleGroup> ApplicationRoleGroups { get; set; }
        public DbSet<ApplicationUserGroup> ApplicationUserGroups { get; set; }
        public DbSet<VerticalNavItem> VerticalNavItems { get; set; }
        public DbSet<ApplicationNotification> ApplicationNotifications { get; set; }
        public DbSet<Detento> Detentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            // NpgsqlConnection.GlobalTypeMapper.MapEnum<InstrumentoPrisaoTipoEnum>();
            // NpgsqlConnection.GlobalTypeMapper.MapComposite<InstrumentoPrisaoTipoEnum>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Set BaseEntity rules to all loaded entity types
            foreach (var type in GetEntityTypes())
            {
                var method = SetGlobalQueryMethod.MakeGenericMethod(type);
                method.Invoke(this, new object[] { modelBuilder });
            }

            modelBuilder.ApplyConfiguration(new TenantMap());
            modelBuilder.ApplyConfiguration(new ApplicationUserMap());
            modelBuilder.ApplyConfiguration(new ApplicationUserClaimMap());
            modelBuilder.ApplyConfiguration(new ApplicationRoleMap());
            modelBuilder.ApplyConfiguration(new ApplicationUserRoleMap());
            modelBuilder.ApplyConfiguration(new ApplicationGroupMap());
            modelBuilder.ApplyConfiguration(new ApplicationRoleGroupMap());
            modelBuilder.ApplyConfiguration(new ApplicationUserGroupMap());
            modelBuilder.ApplyConfiguration(new VerticalNavItemMap());
            modelBuilder.ApplyConfiguration(new ApplicationNotificationMap());
            modelBuilder.ApplyConfiguration(new DetentoMap());
        }

        // Find loaded entity types from assemblies that application uses
        //
        private static IList<Type> _entityTypeCache;
        private static IList<Type> GetEntityTypes()
        {
            if (_entityTypeCache != null)
            {
                return _entityTypeCache.ToList();
            }

            _entityTypeCache = (from a in GetReferencingAssemblies()
                                from t in a.DefinedTypes
                                where t.BaseType == typeof(EntityAuditTenant)
                                select t.AsType()).ToList();

            return _entityTypeCache;
        }
    
        private static IEnumerable<Assembly> GetReferencingAssemblies()
        {
            var assemblies = new List<Assembly>();
            var dependencies = DependencyContext.Default.RuntimeLibraries;

            foreach (var library in dependencies)
            {
                try
                {
                    var assembly = Assembly.Load(new AssemblyName(library.Name));
                    assemblies.Add(assembly);
                }
                catch (FileNotFoundException)
                { }
            }
            return assemblies;
        }

        // Applying BaseEntity rules to all entities that inherit from it.
        // Define MethodInfo member that is used when model is built.
        //
        static readonly MethodInfo SetGlobalQueryMethod = typeof(SagepAppDbContext)
                                                                .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                                                                .Single(t => t.IsGenericMethod && t.Name == "SetGlobalQuery");

        public void SetGlobalQuery<T>(ModelBuilder builder) where T : EntityAuditTenant
        {
            builder.Entity<T>().HasQueryFilter(e => e.TenantId == _tenantProvider.GetTenantId());
        }

        public int SaveChangesWhitoutSD(bool acceptAllChangesOnSuccess)
        {
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforeSaving();

            try
            {
                return base.SaveChanges(acceptAllChangesOnSuccess);
            }
            catch { throw; }
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            OnBeforeSaving();
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void OnBeforeSaving()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is EntityAudit || x.Entity is EntityAuditTenant)
                .ToList();

            var entitiesTracker = ChangeTracker.Entries().ToList();

            UpdateSoftDelete(entities);
            UpdateTimestamps(entities);
        }

        private void UpdateSoftDelete(List<EntityEntry> entries)
        {
            var filtered = entries
                .Where(x => x.State == EntityState.Added
                    || x.State == EntityState.Deleted);

            foreach (var entry in filtered)
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        //entry.CurrentValues["IsDeleted"] = false;
                        if (entry.Entity is EntityAudit) 
                        {
                            ((EntityAudit)entry.Entity).IsDeleted = false;
                        } else {
                            ((EntityAuditTenant)entry.Entity).IsDeleted = false;
                        }
                        
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        //entry.CurrentValues["IsDeleted"] = true;
                        if (entry.Entity is EntityAudit) 
                        {
                            ((EntityAudit)entry.Entity).IsDeleted = true;
                        } else {
                            ((EntityAuditTenant)entry.Entity).IsDeleted = true;
                        }
                        break;
                }
            }
        }

        private void UpdateTimestamps(List<EntityEntry> entries)
        {
            var filtered = entries
                .Where(x => x.State == EntityState.Added
                    || x.State == EntityState.Modified);

            // TODO: Get real current user id
            var currentUserId = _userProvider.GetGuidId();

            foreach (var entry in filtered)
            {
                if (entry.Entity is EntityAudit)
                {
                    if (entry.State == EntityState.Added)
                    {
                        ((EntityAudit)entry.Entity).CreatedAt = DateTime.UtcNow;
                        ((EntityAudit)entry.Entity).CreatedBy = currentUserId;
                    }

                    ((EntityAudit)entry.Entity).UpdatedAt = DateTime.UtcNow;
                    ((EntityAudit)entry.Entity).UpdatedBy = currentUserId;
                } else {
                    if (entry.State == EntityState.Added)
                    {
                        ((EntityAuditTenant)entry.Entity).CreatedAt = DateTime.UtcNow;
                        ((EntityAuditTenant)entry.Entity).CreatedBy = currentUserId;
                    }

                    ((EntityAuditTenant)entry.Entity).UpdatedAt = DateTime.UtcNow;
                    ((EntityAuditTenant)entry.Entity).UpdatedBy = currentUserId;
                }
            }
        }
    }
}