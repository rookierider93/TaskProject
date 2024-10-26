Install Package

1. dotnet add package Microsoft.EntityFrameworkCore --version 8.0.10
2. dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.10
3. dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.10
4. dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 8.0.10
5. dotnet tool install -g dotnet-aspnet-codegenerator
6. dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 8.0.6

EF Commands :-

1. dotnet ef migrations add InitCreate
2. dotnet ef database update
3. dotnet aspnet-codegenerator controller -name TaskController -m Tasks -dc TaskDemo.Data.AppDBContext --relativeFolderPath Co
   ntrollers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite
