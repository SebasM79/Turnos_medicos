namespace TurnosMedicos.Api.Domain
{
    public class UnidadTratamiento
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        // Relaciones
        public ICollection<Especialidad> Especialidades { get; set; } = new List<Especialidad>();
        public ICollection<Medico> Medicos { get; set; } = new List<Medico>();
    }
}
