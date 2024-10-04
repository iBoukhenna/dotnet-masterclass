using Microsoft.Extensions.Configuration;
using CarvedRock.OrderProcessor;
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
var seqUrl = configuration["SeqUrl"];
var nestedProp = configuration["Inventory:NestedProperty"];

var name = typeof(Program).Assembly.GetName().Name;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
    .Enrich.FromLogContext()
    .Enrich.WithMachineName()
    .Enrich.WithProperty("Assembly", name)
    .WriteTo.Seq(seqUrl)
    .WriteTo.Console()
    .CreateLogger();

try
{
    Log.Information("Starting host");
    IHost host = Host.CreateDefaultBuilder(args)
        .ConfigureServices(services =>
        {
            services.AddHostedService<Worker>();
        }).UseSerilog()
        .Build();

    await host.RunAsync();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}
