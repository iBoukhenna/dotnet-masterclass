using System.Data;
using System.Data.SqlClient;
using CarvedRock.Api;
using CarvedRock.Api.Domain;
using CarvedRock.Api.Interfaces;
using CarvedRock.Api.Middleware;
using CarvedRock.Api.Integrations;
using CarvedRock.Api.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Serilog;
using Serilog.Events;

var builder = WebApplication.CreateBuilder(args);

// Retrieve values from appsettings.json
var connectionString = builder.Configuration.GetConnectionString("Db");
var simpleProperty = builder.Configuration["SimpleProperty"];
var seqUrl = builder.Configuration["SeqUrl"];
var nestedProp = builder.Configuration["Inventory:NestedProperty"];

var name = typeof(Program).Assembly.GetName().Name;

// Configure Serilog
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
    .Enrich.FromLogContext()
    .Enrich.WithMachineName()
    .Enrich.WithProperty("Assembly", name)
    // available sinks: https://github.com/serilog/serilog/wiki/Provided-Sinks
    // Seq: https://datalust.co/seq
    // Seq with Docker: https://docs.datalust.co/docs/getting-started-with-docker
    .WriteTo.Seq(serverUrl: seqUrl)
    .WriteTo.Console()
    .CreateLogger();

builder.Host.UseSerilog();

Log.ForContext("ConnectionString", connectionString)
    .ForContext("SimpleProperty", simpleProperty)
    .ForContext("Inventory:NestedProperty", nestedProp)
    .Information("Loaded Configuration", connectionString);

var dbgView = (builder.Configuration as IConfigurationRoot)?.GetDebugView();
Log.ForContext("ConfigurationDebug", dbgView)
    .Information("Configuration dump.");

// Add services to the container.
builder.Services.AddControllers();

// Register Logic with its implementation
builder.Services.AddScoped<IProductLogic, ProductLogic>();
builder.Services.AddScoped<IQuickOrderLogic, QuickOrderLogic>();
builder.Services.AddSingleton<IOrderProcessingNotification, OrderProcessingNotification>();
builder.Services.AddScoped<IDbConnection>(d => new SqlConnection(connectionString));
builder.Services.AddScoped<ICarvedRockRepository, CarvedRockRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseMiddleware<CustomExceptionHandlingMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCustomRequestLogging();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Configure logging for the application
try
{
    Log.Information("Starting web host");
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}
