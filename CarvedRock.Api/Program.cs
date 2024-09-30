using CarvedRock.Api.Domain;
using CarvedRock.Api.Interfaces;
using CarvedRock.Api.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Register Logic with its implementation
builder.Services.AddScoped<IProductLogic, ProductLogic>();
builder.Services.AddScoped<IQuickOrderLogic, QuickOrderLogic>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
