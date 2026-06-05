using OnionArch.Application;
using OnionArch.Persistance;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddApplicationServices();

// Configure the HTTP request pipeline.
app.UseAuthorization();
app.MapControllers();
app.MapOpenApi();
app.MapScalarApiReference();

app.Run();
