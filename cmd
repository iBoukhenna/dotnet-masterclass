
dotnet new aspire-starter --output eShop

dotnet add eShop.AppHost.csproj package Aspire.Hosting.Redis --version 8.0.0 
dotnet add eShop.Web.csproj package Aspire.StackExchange.Redis.OutputCaching --version 8.0.0
