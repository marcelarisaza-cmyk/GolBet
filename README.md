# GolBet

Simulador de casa de apuestas de fútbol con FutCoins (moneda virtual, sin dinero real).
Proyecto académico del curso de Desarrollo de Software.

## Tecnologías

- .NET 8
- ASP.NET Core MVC
- Entity Framework Core 8 (Code First) con SQL Server
- AutoMapper 13
- Bootstrap 5
- Arquitectura N-Capas

## Estructura de la solución

| Proyecto | Responsabilidad |
|---|---|
| GolBet.Web | Presentación: controllers y vistas |
| GolBet.Services | Lógica de negocio, DTOs y mapeo con AutoMapper |
| GolBet.Repositories | Acceso a datos: DbContext, repositorios, migraciones y seeder |
| GolBet.Entities | Entidades del dominio y enums |

Cada capa solo conoce a la de abajo:

```
Web → Services → Repositories → Entities
```

## Cómo ejecutarlo

Requisitos: .NET 8 SDK o superior, Visual Studio con soporte para `.slnx` y SQL Server LocalDB (viene con Visual Studio).

1. Clonar el repositorio.
2. Abrir `GolBet.slnx` en Visual Studio.
3. Establecer `GolBet.Web` como proyecto de inicio y ejecutar con F5 (perfil `https`).

No hace falta crear la base de datos a mano. Al arrancar, la aplicación aplica la migración, crea `GolBetDB` y la llena con 8 equipos y 6 partidos. Si la base ya tiene datos, el seeder no los duplica.

La cadena de conexión está en `GolBet.Web/appsettings.json` y apunta a `(localdb)\MSSQLLocalDB`.

Los escudos de los equipos se cargan desde `placehold.co`, así que se necesita conexión a internet para verlos.

## Funcionalidades (Módulos 1 a 5)

- Página de inicio con identidad GolBet.
- Cartelera de partidos en `/Matches`, con escudos, fecha en hora de Colombia, estado en español, marcador en los partidos finalizados y cuotas 1 X 2.
- Filtros por estado: `/Matches?status=Scheduled`, `InProgress` o `Finished`.
- Detalle de cada partido en `/Matches/Detail/{id}`. Un id inexistente responde 404.

## Módulos y tags

| Tag | Contenido |
|---|---|
| modulo-1 | Solución con 4 proyectos y página de inicio |
| modulo-2 | Entidades, AppDbContext con Fluent API y migración inicial |
| modulo-3 | Repositorio genérico, MatchRepository y seeder |
| modulo-4 | Servicios, DTOs, AutoMapper y cartelera |
| modulo-5 | Filtros y detalle del partido |