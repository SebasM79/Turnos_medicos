namespace TurnosMedicos.Api.Domain
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Dni { get; set; } = null!;
        public int Cel { get; set; } 
        public string Email { get; set; } = null!;
        public string Direccion { get; set; } = null!;

        public ICollection<Turno> Turnos { get; set; } = new List<Turno>();
    }
}
