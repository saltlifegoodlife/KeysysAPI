# KeysysAPI

### Web API that allows services to fetch invoice options from a local database(MySQL).
  - May need to install nuget Packages:
    - Microsoft.EntityFrameworkCore.Design
    - Microsoft.EntityFrameworkCore.Tools
    - MySql.EntityFrameworkCore
    - Microsoft.AspNet.WebApi.Cors
  - Database needs to be called keysys_db.
  - Data needs to be ingested into a table called invoice_options.
  - Will need to update the appsettings.json to current user's local database connection properties.
