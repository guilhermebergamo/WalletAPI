using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Wallet.Application.Commands.Usuario;
using Wallet.Domain.Interfaces.Repositories;
using Wallet.Infrastructure.Data;
using Wallet.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

builder.Services.AddControllers();
builder.Services.AddOpenApi();

// Add services to the container.
builder.Services.AddControllers();

// Configuração correta do Swagger
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(AdicionarUsuarioCommandHandler).Assembly));


services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
services.AddTransient<IUsuarioRepository, UsuarioRepository>();

var app = builder.Build();

await using var scope = app.Services.CreateAsyncScope();
var serviceProvider = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
await serviceProvider.Database.MigrateAsync();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    options.SwaggerEndpoint("/openapi/v1.json", "Wallet api"));

}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

await app.RunAsync();