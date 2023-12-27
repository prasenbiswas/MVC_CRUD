
# MVC CRUD
A lightweight CRUD application developed in .NET Core 8, following the MVC architectural pattern. This project simplifies data management tasks with a user-friendly interface and integrates Toastr for enhanced notification capabilities.

# 
## Configuration
Follow these steps to configure the appsettings.json connection string:

1. Open the appsettings.json file in the root of your project.
2. Add "ConnectionStrings" section:
   - {
        "ConnectionStrings": {
        "DefaultConnection": "Server=your-server;
         Database=your-database;
         Trusted_Connection=True;TrustServerCertificate=True;"
                            }
        }
4. Save the appsettings.json file.
5. Run **Update-Database** Command on Package Manager Console

## Installation
- .NET Core 8 SDK: Download and install the .NET Core 8 SDK from the official .NET website: https://dotnet.microsoft.com/download
- Visual Studio 2022: Download and install Visual Studio 2019 from https://visualstudio.microsoft.com/
- SQL Server Download the SQL Server installer from https://www.microsoft.com/en-us/sql-server/sql-server-downloads.
