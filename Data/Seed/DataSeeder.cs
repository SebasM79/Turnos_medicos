using TurnosMedicos.Api.Domain;

namespace TurnosMedicos.Api.Data.Seed
{
    public static class DataSeeder
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.UnidadesTratamiento.Any())
            {
                var cardiologia = new UnidadTratamiento { Nombre = "Cardiología" };
                var clinica = new UnidadTratamiento { Nombre = "Clínica Médica" };

                context.UnidadesTratamiento.AddRange(cardiologia, clinica);
                context.SaveChanges();

                var especialidades = new List<Especialidad>
                {
                    new Especialidad { Nombre = "Electrocardiograma", UnidadTratamientoId = cardiologia.Id },
                    new Especialidad { Nombre = "Ecocardiograma", UnidadTratamientoId = cardiologia.Id },
                    new Especialidad { Nombre = "Consulta Clínica", UnidadTratamientoId = clinica.Id }
                };

                context.Especialidades.AddRange(especialidades);
                context.SaveChanges();
            }

            if (!context.ObrasSociales.Any())
            {
                context.ObrasSociales.AddRange(
                    new ObraSocial { Nombre = "OSDE" },
                    new ObraSocial { Nombre = "Swiss Medical" },
                    new ObraSocial { Nombre = "IOMA" }
                );

                context.SaveChanges();
            }
        }
    }
}
