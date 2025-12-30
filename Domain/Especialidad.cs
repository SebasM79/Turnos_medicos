namespace TurnosMedicos.Api.Domain
{
    public class Especialidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        // FK
        public int UnidadTratamientoId { get; set; }

        // Navegación
        public UnidadTratamiento UnidadTratamiento { get; set; } = null!;

        public ICollection<MedicoEspecialidad> MedicosEspecialidades { get; set; } = new List<MedicoEspecialidad>();
    }
}
