# eShopSolution
## ASP.NET CORE 6 Project
## Technologies
  - ASP.NET Core 6
  -  Entity Framework Core 6
## Install Packages
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Design
  - Microsoft.EntityFrameworkCore.Tools
## How to configure and run
Clone code from Github: git clone https://github.com/teduinternational/eShopSolution
Open solution eShopSolution.sln in Visual Studio 2019
Set startup project is eShopSolution.Data
Change connection string in Appsetting.json in eShopSolution.Data project
Open Tools --> Nuget Package Manager --> Package Manager Console in Visual Studio
Run Update-database and Enter.
After migrate database successful, set Startup Project is eShopSolution.WebApp
Change database connection in appsettings.Development.json in eShopSolution.WebApp project.
Choose profile to run or press F5
## How to contribute
Fork and create your branch
Create Pull request to us.
## Admin template: https://startbootstrap.com/templates/sb-admin/
## Portal template: https://www.free-css.com/free-css-templates/page194/bootstrap-shop
## I18N (Internalization)
References: https://medium.com/swlh/step-by-step-tutorial-to-build-multi-cultural-asp-net-core-web-app-3fac9a960c43
Source code: https://github.com/LazZiya/ExpressLocalizationSampleCore3