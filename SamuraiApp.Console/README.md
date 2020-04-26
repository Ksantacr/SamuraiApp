Este proyecto es del curso [Entity Framework Core: Getting Started](https://app.pluralsight.com/library/courses/c99828cd-6812-41f9-bf1c-3ce2227b9a89/table-of-contents).

add migrations

- Microsoft.EntityFrameworkCore.Tools

-s or --startup-project
dotnet ef migration add init -s ../ConsoleApp

## Comandos mas usados
add-migration init
update-database
script-migration

## Extensiones
[EFCorePowerTools] https://github.com/ErikEJ/EFCorePowerTools


## Context from Database
scaffold-dbcontext -provider Microsoft.EntityFrameworkCore.SqlServer -connection "Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = SamuraiAppData"


## EFCore 3

