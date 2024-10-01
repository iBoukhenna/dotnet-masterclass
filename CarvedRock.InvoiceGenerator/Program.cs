using Serilog;
using Serilog.Events;

var name = typeof(Program).Assembly.GetName().Name;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
    .Enrich.FromLogContext()
    .Enrich.WithMachineName()
    .Enrich.WithProperty("Assembly", name)
    .WriteTo.Seq("http://host.docker.internal:5341")
    .WriteTo.Console()
    .CreateLogger();

try
{
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




