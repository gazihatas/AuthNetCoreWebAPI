# Dotnet Core 5 WEbAPI

## Using Packages

- Microsoft.EntityFrameworkCore
  - ```dotnet add package Microsoft.EntityFrameworkCore --version 6.0.0-preview.4.21253.1```
- Microsoft.EntityFrameworkCore.Design
  - ```dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.0-preview.4.21253.1```	
- Microsoft.EntityFrameworkCore.SqlServer
  - ```dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.0-preview.4.21253.1```
- Microsoft.EntityFrameworkCore.Identity.EntityFrameworkCore
  - ```dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 6.0.0-preview.4.21253.5``` 

 ## Install EntityFramework CLI
  - ```dotnet tool install --global dotnet-ef```
- dotnet ef

 ## Swagger Packages
  - ```dotnet add package Swashbuckle.AspNetCore --version 6.1.5```
  
##  ConnectionString => appsetting.json
-  ```"DefaultConnection":"Server=localhost;Initial Catalog=projectDB;Integrated Security=false;Timeout=30;User ID=userName;Password=Demo123456;"```

## Migrations
- first project build ```dotnet build```
- ```dotnet ef migrations add InitialMigration --output-dir "Data/Migrations"```
- ```dotnet ef database update```
  
  