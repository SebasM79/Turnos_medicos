namespace TurnosMedicos.Api.Domain
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Matricula { get; set; } = null!;
        public int Cel { get; set; } 
        public string Email { get; set; } = null!;
        public string Direccion { get; set; } = null!;

        // FK
        public int UnidadTratamientoId { get; set; }

        // Navegación
        public UnidadTratamiento UnidadTratamiento { get; set; } = null!;

        public ICollection<MedicoEspecialidad> MedicosEspecialidades { get; set; } = new List<MedicoEspecialidad>();
        public ICollection<Turno> Turnos { get; set; } = new List<Turno>();
    }
}
