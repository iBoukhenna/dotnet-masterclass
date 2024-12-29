
dotnet new aspire-starter --output eShop

dotnet add eShop.AppHost.csproj package Aspire.Hosting.Redis --version 8.0.0
dotnet add eShop.Web.csproj package Aspire.StackExchange.Redis.OutputCaching --version 8.0.0
dotnet add eShop.API.csproj package Aspire.StackExchange.Redis.DistributedCache --version 8.0.0

dotnet new aspire-apphost -o eShopLite.AppHost
dotnet sln .\eShopLite.sln add .\eShopLite.AppHost\eShopLite.AppHost.csproj
dotnet add .\eShopLite.AppHost\eShopLite.AppHost.csproj reference .\Store\Store.csproj
dotnet add .\eShopLite.AppHost\eShopLite.AppHost.csproj reference .\Products\Products.csproj

dotnet new aspire-servicedefaults -o eShopLite.ServiceDefaults
dotnet sln .\eShopLite.sln add .\eShopLite.ServiceDefaults\eShopLite.ServiceDefaults.csproj
dotnet add .\Store\Store.csproj reference .\eShopLite.ServiceDefaults\eShopLite.ServiceDefaults.csproj
dotnet add .\Products\Products.csproj reference .\eShopLite.ServiceDefaults\eShopLite.ServiceDefaults.csproj

User : test@example.com
Pass : P@$$w0rd1


