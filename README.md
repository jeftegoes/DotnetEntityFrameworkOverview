# Entity Framework overview <!-- omit in toc -->

## Contents <!-- omit in toc -->

- [1. Package dependencies](#1-package-dependencies)
- [2. Commands](#2-commands)

## 1. Package dependencies

- dotnet add package Microsoft.EntityFrameworkCore
- dotnet add package Microsoft.EntityFrameworkCore.Sqlite
- dotnet add package Microsoft.EntityFrameworkCore.SqlServer
- dotnet add package Microsoft.EntityFrameworkCore.Tools

## 2. Commands
- Install globally dotnet ef into machine
  - dotnet tool install --global dotnet-ef
  - dotnet tool install --global dotnet-ef --version 6.X.X
- Unistall globally dotnet ef into machine
  - dotnet tool uninstall --global dotnet-ef
  - dotnet tool install --global dotnet-ef
- Add migration into the project
  - dotnet ef migrations add `<name_migrations>` –o `<output_path>`
  - dotnet ef migrations add `<name_migrations>` -p `<project_name>` -s `<name_solution>` -o `<output_path>` # Ex: dotnet ef migrations add InitialCreate -p Infrastructure -s API 
-o Data/Migrations
- Create or update database with migrations
  - dotnet ef database update
  - dotnet ef database update -p `<project_name>` -s `<name_solution>` # Ex: dotnet ef database update -p Infrastructure -s API
- Drop database/migrations
  - dotnet ef database drop -p `<project_name>` -s `<name_solution>` # Ex: dotnet ef database drop -p Infrastructure -s API
- Remove migrations
  - dotnet ef migrations remove -p `<project_name>` -s `<name_solution>` # Ex: dotnet ef migrations remove -p Infrastructure -s API
