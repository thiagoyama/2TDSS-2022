using Fiap.Aula06.Api.Persistencia;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Recuperar a string de conexão do appsettings.json
var sql = builder.Configuration.GetConnectionString("conexao");

//Configurar a injeção de dependencia do DbContext
builder.Services.AddDbContext<DoceriaContext>(op => op.UseSqlServer(sql));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
