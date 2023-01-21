﻿using System.Data.Common;
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
using Sagep.Domain.Enums;
using System.Reflection;
using System.IO;
using Microsoft.Extensions.DependencyModel;
using Sagep.Infra.Data.Services;

namespace Sagep.Infra.Data.Context
{
    public class SigespDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string,
                                                     ApplicationUserClaim, ApplicationUserRole, IdentityUserLogin<string>,
                                                     IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public static Guid Tenant1Id = Guid.Parse("51aab199-1482-4f0d-8ff1-5ca0e7bc525a");
        
        private readonly UserResolverService _userResolverService;
        private readonly ITenantProvider _tenantProvider;

        public SigespDbContext(DbContextOptions<SigespDbContext> options, 
                               UserResolverService userResolverService,
                               ITenantProvider tenantProvider)
            : base(options)
        {
            _userResolverService = userResolverService;
            _tenantProvider = tenantProvider;
        }

        public DbSet<ContaUsuario> ContaUsuarios { get; set; }
        public DbSet<Detento> Detentos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<EmpresaConvenio> EmpresaConvenios { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<ContaCorrente> ContasCorrentes { get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }
        public DbSet<ListaAmarela> ListaAmarela { get; set; }
        public DbSet<Edi> Edis { get; set; }
        public DbSet<EdiLog> EdisLogs { get; set; }
        public DbSet<SequenciaOficio> SequenciasOficios { get; set; }
        public DbSet<ColaboradorPonto> ColaboradoresPontos { get; set; }
        public DbSet<ColaboradorPontoApontamento> ColaboradoresPontosApontamentos { get; set; }
        public DbSet<ContabilEvento> ContabilEventos { get; set; }
        public DbSet<AndamentoPenal> AndamentoPenal { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<LivroAutor> LivrosAutores { get; set; }
        public DbSet<LivroGenero> LivrosGeneros { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<AlunoEja> AlunosEja { get; set; }
        public DbSet<AlunoEjaDisciplina> AlunoEjaDisciplinas { get; set; }
        public DbSet<AlunoEncceja> AlunosEncceja { get; set; }
        public DbSet<AlunoEnem> AlunosEnem { get; set; }
        public DbSet<AlunoLeitor> AlunosLeitores { get; set; }
        public DbSet<AlunoLeitura> AlunosLeituras { get; set; }
        public DbSet<AlunoLeituraCronograma> AlunosLeiturasCronogramas { get; set; }
        public DbSet<AlunoRedacaoDPU> AlunosRedacaoDPU { get; set; }
        public DbSet<DetentoSaidaTemporaria> DetentoSaidasTemporaria { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<FormularioLeituraDicaEscrita> FormularioLeituraDicasEscrita { get; set; }
        public DbSet<FormularioLeituraDicaEscritaDica> FormularioLeituraDicasEscritaDicas { get; set; }
        public DbSet<FormularioLeituraPerguntaGrupo> FormularioLeituraPerguntasGrupos { get; set; }
        public DbSet<FormularioLeituraPergunta> FormularioLeituraPerguntas { get; set; }
        public DbSet<ServidorEstado> ServidoresEstado { get; set; }
        public DbSet<ServidorEstadoReforco> ServidoresEstadoReforcos { get; set; }
        public DbSet<ServidorEstadoReforcoRegra> ServidorEstadoReforcoRegras { get; set; }
        public DbSet<ServidorEstadoReforcoRegraVagaDia> ServidorEstadoReforcoRegraVagasDia { get; set; }
        public DbSet<ApplicationNotification> ApplicationNotifications { get; set; }
        public DbSet<InfracaoAdministrativaDisciplinar> InfracoesAdministrativasDisciplinares { get; set; }
        public DbSet<InfracaoAdministrativaDisciplinarDetento> InfracoesAdministrativasDisciplinaresDetentos { get; set; }


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

            modelBuilder.ApplyConfiguration(new ApplicationUserClaimMap());
            modelBuilder.ApplyConfiguration(new ApplicationUserMap());
            modelBuilder.ApplyConfiguration(new ApplicationRoleMap());
            modelBuilder.ApplyConfiguration(new ApplicationUserRoleMap());
            modelBuilder.ApplyConfiguration(new ContaUsuarioMap());
            modelBuilder.ApplyConfiguration(new DetentoMap());
            modelBuilder.ApplyConfiguration(new EmpresaMap());
            modelBuilder.ApplyConfiguration(new EmpresaConvenioMap());
            modelBuilder.ApplyConfiguration(new ColaboradorMap());
            modelBuilder.ApplyConfiguration(new ContaCorrenteMap());
            modelBuilder.ApplyConfiguration(new LancamentoMap());
            modelBuilder.ApplyConfiguration(new ListaAmarelaMap());
            modelBuilder.ApplyConfiguration(new EdiMap());
            modelBuilder.ApplyConfiguration(new EdiLogMap());
            modelBuilder.ApplyConfiguration(new SequenciaOficioMap());
            modelBuilder.ApplyConfiguration(new ColaboradorPontoMap());
            modelBuilder.ApplyConfiguration(new ColaboradorPontoApontamentoMap());
            modelBuilder.ApplyConfiguration(new ContabilEventoMap());
            modelBuilder.ApplyConfiguration(new AndamentoPenalMap());
            modelBuilder.ApplyConfiguration(new LivroMap());
            modelBuilder.ApplyConfiguration(new LivroAutorMap());
            modelBuilder.ApplyConfiguration(new LivroGeneroMap());
            modelBuilder.ApplyConfiguration(new ProfessorMap());
            modelBuilder.ApplyConfiguration(new DisciplinaMap());
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new AlunoEjaMap());
            modelBuilder.ApplyConfiguration(new AlunoEjaDisciplinaMap());
            modelBuilder.ApplyConfiguration(new AlunoEnccejaMap());
            modelBuilder.ApplyConfiguration(new AlunoEnemMap());
            modelBuilder.ApplyConfiguration(new AlunoLeitorMap());
            modelBuilder.ApplyConfiguration(new AlunoLeituraMap());
            modelBuilder.ApplyConfiguration(new AlunoLeituraCronogramaMap());
            modelBuilder.ApplyConfiguration(new AlunoRedacaoDPUMap());
            modelBuilder.ApplyConfiguration(new DetentoSaidaTemporariaMap());
            modelBuilder.ApplyConfiguration(new TenantMap());
            modelBuilder.ApplyConfiguration(new FormularioLeituraDicaEscritaMap());
            modelBuilder.ApplyConfiguration(new FormularioLeituraDicaEscritaDicaMap());
            modelBuilder.ApplyConfiguration(new FormularioLeituraPerguntaGrupoMap());
            modelBuilder.ApplyConfiguration(new FormularioLeituraPerguntaMap());
            modelBuilder.ApplyConfiguration(new ServidorEstadoMap());
            modelBuilder.ApplyConfiguration(new ServidorEstadoReforcoMap());
            modelBuilder.ApplyConfiguration(new ServidorEstadoReforcoRegraMap());
            modelBuilder.ApplyConfiguration(new ServidorEstadoReforcoRegraVagaDiaMap());
            modelBuilder.ApplyConfiguration(new ApplicationNotificationMap());
            modelBuilder.ApplyConfiguration(new InfracaoAdministrativaDisciplinarMap());
            modelBuilder.ApplyConfiguration(new InfracaoAdministrativaDisciplinarDetentoMap());

            modelBuilder.HasPostgresEnum<InstrumentoPrisaoTipoEnum>();

            modelBuilder.Entity<AndamentoPenal>()
                        .HasQueryFilter(e => e.TenantId == _tenantProvider.GetTenantId());

            // modelBuilder
            //        .HasPostgresExtension("uuid-ossp")
            //        .Entity<Detento>()
            //        .Property(c => c.Id)
            //        .HasDefaultValueSql("uuid_generate_v4()");
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
        static readonly MethodInfo SetGlobalQueryMethod = typeof(SigespDbContext)
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
            var currentUserId = _userResolverService.GetUserId();

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