using Consultorio.Domain.Entities;
using Consultorio.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Atende>? Atende { get; set; }
        public DbSet<Consulta>? Consulta { get; set; }
        public DbSet<Convenio>? Convenio { get; set; }
        public DbSet<Dentista>? Dentista { get; set; }
        public DbSet<Especialidade>? Especialidade { get; set; }
        public DbSet<Paciente>? Paciente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Atende>(new AtendeMap().Configure);
            modelBuilder.Entity<Consulta>(new ConsultaMap().Configure);
            modelBuilder.Entity<Convenio>(new ConvenioMap().Configure);
            modelBuilder.Entity<Dentista>(new DentistaMap().Configure);
            modelBuilder.Entity<Especialidade>(new EspecialidadeMap().Configure);
            modelBuilder.Entity<Paciente>(new PacienteMap().Configure);
            
        }
    }
}
