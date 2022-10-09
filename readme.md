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
### JwtBearer Packages
- Microsoft.AspNetCore.Authentication.JwtBearer
  -```dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 6.0.0-preview.5.21301.17```

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

## Project Photos
 ![](/swaggerAPI.PNG)


## Contributing

Pull requestler kabul edilir. Büyük değişiklikler için, lütfen önce neyi değiştirmek istediğinizi tartışmak için bir konu açınız.

## License

[MIT](https://choosealicense.com/licenses/mit/)
  
