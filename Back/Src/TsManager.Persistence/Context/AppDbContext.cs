using Microsoft.EntityFrameworkCore;
using System;
using TsManager.Domain;

namespace TsManager.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Analista_Equipe> AnalistaEquipes { get; set; }
        public DbSet<Anexo> Anexos { get; set; }
        public DbSet<Chamado> Chamados { get; set; }
        public DbSet<EquipeAtendimento> EquipesAtendimento { get; set; }
        public DbSet<Historico> Historicos { get; set; }
        public DbSet<Severidade> Severidades { get; set; }
        public DbSet<Sla> Slas { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<TipoRegistro> TipoRegistros { get; set; }
        public DbSet<UsuarioChamado> UsuarioChamados { get; set; }


        // Injeta o servi�o para migration

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
