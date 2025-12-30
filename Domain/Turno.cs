namespace TurnosMedicos.Api.Domain
{
    public class Turno
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }

        // FKs
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
        public int EspecialidadId { get; set; }
        public int ObraSocialId { get; set; }

        // Navegación
        public Medico Medico { get; set; } = null!;
        public Paciente Paciente { get; set; } = null!;
        public Especialidad Especialidad { get; set; } = null!;
        public ObraSocial ObraSocial { get; set; } = null!;
    }
}
