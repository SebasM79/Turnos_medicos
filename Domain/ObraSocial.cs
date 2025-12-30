namespace TurnosMedicos.Api.Domain
{
    public class ObraSocial
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Plan { get; set; } = null!;

        public ICollection<Turno> Turnos { get; set; } = new List<Turno>();
    }
}
