using MyWebApp.Interfaces;
using MyWebApp.Services;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddSingleton<IWelcomeService, WelcomeService>();
//builder.Services.AddScoped<IWelcomeService, WelcomeService>();
builder.Services.AddTransient<IWelcomeService, WelcomeService>();

var app = builder.Build();

//app.MapGet("/", (IWelcomeService welcomeService) => welcomeService.GetWelcomeMessage());
app.MapGet("/", async (IWelcomeService welcomeService1, IWelcomeService welcomeService2) => 
    {
        string message1 = $"Message1: {welcomeService1.GetWelcomeMessage()}";
        string message2 = $"Message2: {welcomeService2.GetWelcomeMessage()}";
        return $"{message1}\n{message2}";
    });

app.Run();
