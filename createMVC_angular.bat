@REM if [%1]==[] goto :blank
@REM if "%~1"=="-b" (goto specific) else goto unknown
md %1
cd %1
md Domain
md Entities
md Repositories
md Context
md BL
md WebApp


cd Domain
dotnet new classlib
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools


cd ../Entities
dotnet new classlib
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools

cd ../Context
dotnet new classlib
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools

cd ../BL
dotnet new classlib
cd ../Repositories
dotnet new classlib
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools

cd ../WebApp
dotnet new angular -au Individual
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet add package Microsoft.AspNetCore.Identity.UI
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools

cd ..
dotnet new solution
dotnet sln add WebApp
dotnet sln add Domain
dotnet sln add Entities
dotnet sln add Context
dotnet sln add Repositories
dotnet sln add BL

