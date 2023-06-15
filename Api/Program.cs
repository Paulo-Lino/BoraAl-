using BoraAli.Api.Context;
using BoraAli.Api.Infra.Data;
using BoraAli.Api.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BoraAliContext>(options => options.UseMySql("Server=localhost;Database=boraali;userId=root;password=root;"
, ServerVersion.Parse("8.0.33-mysql")));

builder.Services.AddScoped<IBaseInfraData, BaseInfraData>();
builder.Services.AddScoped<IUsuarioInfraData, UsuarioInfraData>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


