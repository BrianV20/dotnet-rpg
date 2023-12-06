/*
1. correr el comando dotnet new api
2. correr el comando dotnet watch run
3. crear los modelos (que usan a los servicios y dtos)
4. Crear los servicios (que usan a los modelos y dtos)
5. crear los dtos e implementarlos a los modelos y servicios.
6. correr el comando dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection para instalar automapper
7. hacer los mappings necesarios en los servicios.
8. crear el archivo AutoMapperProfile y configurar los distintos mappings.
9. correr el comando dotnet add package Microsoft.EntityFrameworkCore, dotnet add package Microsoft.EntityFrameworkCore.SQLServer, dotnet add package Microsoft.EntityFrameworkCore.Design
10. Crear la carpeta context con el archivo DataContext, donde se definirán los modelos.
11. dotnet ef migrations add InitialCreate para crear la migracion.
12. dotnet ef database update para crear las tablas en sql.
13. agregar el contexto en el constructor del character service
*/