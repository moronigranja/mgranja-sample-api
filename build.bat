:: Generated by: https://github.com/swagger-api/swagger-codegen.git
::

@echo off

dotnet restore src\Mgranja.api1
dotnet build src\Mgranja.api1
dotnet restore src\Mgranja.api2
dotnet build src\Mgranja.api2
echo Now, run the following to start the project: dotnet run -p src\Mgranja.api1\Mgranja.api1.csproj --launch-profile web.
echo.
