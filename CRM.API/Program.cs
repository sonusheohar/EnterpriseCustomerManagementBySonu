using CRM.Application.DependencyInjection;
using CRM.Persistence.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddApplication();

builder.Services.AddPersistence(
    builder.Configuration);

var app = builder.Build();

app.MapControllers();

app.Run();