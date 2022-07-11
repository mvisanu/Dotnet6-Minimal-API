.Net 6 Minimal API

https://www.youtube.com/watch?v=5YB49OEmbbE

https://github.com/binarythistle/S05E03---Minimal-APIs

 dotnet new webapi -minimal -n SixMinApi

 code -r SixMinApi 

 dotnet run

--install needed packages
 dotnet add package Microsoft.EntityFrameworkCore
 dotnet add package Microsoft.EntityFrameworkCore.Design
 dotnet add package Microsoft.EntityFrameworkCore.SqlServer
 dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection

--use user-secret
 dotnet user-secrets init

--user docker compose for sqlserver
docker --version
docker ps

docker-compose.yaml
version: '3.8'
services:
  sqlserver:
    image: "mcr.microsoft.com/mssql/server:2019-latest"
    environment:
      ACCEPT_EULA: "Y"
      SA_PASSWORD: "<password>"
      MSSQL_PID: "Expression"
    ports:
      - "1433:1433"


docker-compose up -d
docker-compose stop

conect to database 127.0.0.1  sa/<password>

--set userid secret
dotnet user-secrets set "UserId" "sa"
dotnet user-secrets set "Password" "<password>"

dotnet ef migrations add initialmigration
dotnet tool update --global dotnet-ef

dotnet ef database update

--run with hot reload
dotnet watch