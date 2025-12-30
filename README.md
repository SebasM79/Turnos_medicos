# Turnos Médicos API

API REST desarrollada en .NET para la gestión de turnos médicos en una clínica o centro de salud.

El sistema permite administrar unidades de tratamiento, especialidades, médicos, pacientes, obras sociales y turnos, manteniendo relaciones claras entre las entidades y una arquitectura escalable.

---

## Funcionalidades principales

- Gestión de Unidades de Tratamiento (Cardiología, Clínica Médica, etc.)
- Administración de Especialidades por unidad
- Asociación de Médicos a unidades y especialidades
- Registro de Pacientes
- Gestión de Turnos médicos
- Soporte para Obras Sociales
- Seed de datos iniciales

---

## Tecnologías utilizadas

- **.NET 8**
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **SQL Server**
- **LINQ**
- **Fluent API**
- **Swagger / OpenAPI**
- **Dapper** (previsto para consultas específicas)
- **Git & GitHub**

---

## Arquitectura y decisiones técnicas

- Uso de **Entity Framework Core** como ORM principal
- Configuración de relaciones mediante **Fluent API**
- Separación clara entre:
  - Dominio (`Domain`)
  - Persistencia (`Data`)
- Implementación de **migraciones** para versionado del esquema
- **Seed de datos** ejecutado al iniciar la aplicación
- Preparado para combinar **EF + Dapper** según necesidad de performance

---

## Modelo de datos (resumen)

- UnidadTratamiento → Especialidades (1 a N)
- UnidadTratamiento → Médicos (1 a N)
- Médico → Especialidades (N a N)
- Turno → Médico / Paciente / Especialidad / ObraSocial

---

## Cómo ejecutar el proyecto localmente

### Requisitos

- .NET SDK 10
- SQL Server
- Visual Studio Code

### Pasos

1. Clonar el repositorio

```bash
git clone https://github.com/tu-usuario/turnos-medicos.git

"ConnectionStrings":
  "DefaultConnection": "Server=DESKTOP-BTO7U3A;Database=TurnosMedicosDb;Trusted_Connection=True;TrustServerCertificate=True;"

Ejecutar migraciones
dotnet ef database update

Levantar la aplicación:
dotnet run

```
