using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Events;

// Build configuration
var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory()) // Optionnel : Spécifie le chemin du fichier
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables()
    .Build();

// Retrieve values from configuration
var connectionString = configuration.GetConnectionString("Db");
var simpleProperty = configuration["SimpleProperty"];
var nestedProp = configuration["Inventory:NestedProperty"];

var name = typeof(Program).Assembly.GetName().Name;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
    .Enrich.FromLogContext()
    .Enrich.WithMachineName()
    .Enrich.WithProperty("Assembly", name)
//    .Enrich.WithProperty("ConnectionString", connectionString)  // Ajout des propriétés
//    .Enrich.WithProperty("SimpleProperty", simpleProperty)
//    .Enrich.WithProperty("Inventory:NestedProperty", nestedProp)
    .WriteTo.Seq("http://host.docker.internal:5341")
    .WriteTo.Console()
    .CreateLogger();

try
{
    Log.ForContext("ConnectionString", connectionString)
        .ForContext("SimpleProperty", simpleProperty)
        .ForContext("Inventory:NestedProperty", nestedProp)
        .Information("Loaded configuration!", connectionString);
    Log.Information("Starting host");
    Console.WriteLine("Hello, World!");
    Log.Information("Finished execution!");
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}




