using Microsoft.EntityFrameworkCore;
using TurnosMedicos.Api.Domain;

namespace TurnosMedicos.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // DbSets (tablas)
        public DbSet<UnidadTratamiento> UnidadesTratamiento { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<MedicoEspecialidad> MedicosEspecialidades { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<ObraSocial> ObrasSociales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuraciones vendrán acá (Fluent API)
        modelBuilder.Entity<Especialidad>()
            .HasOne(e => e.UnidadTratamiento)
            .WithMany(ut => ut.Especialidades)
            .HasForeignKey(e => e.UnidadTratamientoId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Medico>()
            .HasOne(m => m.UnidadTratamiento)
            .WithMany(ut => ut.Medicos)
            .HasForeignKey(m => m.UnidadTratamientoId)
            .OnDelete(DeleteBehavior.Restrict); 
        
        modelBuilder.Entity<MedicoEspecialidad>()
            .HasKey(me => new { me.MedicoId, me.EspecialidadId });
        
        modelBuilder.Entity<MedicoEspecialidad>()
            .HasOne(me => me.Medico)
            .WithMany(m => m.MedicosEspecialidades)
            .HasForeignKey(me => me.MedicoId);

        modelBuilder.Entity<MedicoEspecialidad>()
            .HasOne(me => me.Especialidad)
            .WithMany(e => e.MedicosEspecialidades)
            .HasForeignKey(me => me.EspecialidadId);

        modelBuilder.Entity<Turno>()
            .HasOne(t => t.Medico)
            .WithMany(m => m.Turnos)
            .HasForeignKey(t => t.MedicoId);  

        modelBuilder.Entity<Turno>()
            .HasOne(t => t.Paciente)
            .WithMany(p => p.Turnos)
            .HasForeignKey(t => t.PacienteId);
        
        modelBuilder.Entity<Turno>()
            .HasOne(t => t.Especialidad)
            .WithMany()
            .HasForeignKey(t => t.EspecialidadId);

        modelBuilder.Entity<Turno>()
            .HasOne(t => t.ObraSocial)
            .WithMany(o => o.Turnos)
            .HasForeignKey(t => t.ObraSocialId);
    }

    }
}
