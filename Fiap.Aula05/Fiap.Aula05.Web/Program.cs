using Fiap.Aula05.Web.Persistencia;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Recuperar a string de conex�o do banco do arquivo appsettings.json
var conn = builder.Configuration.GetConnectionString("conexao");

//Configurar o servi�o de DbContext, inje��o de depend�ncia 
builder.Services.AddDbContext<GestaoAereaContext>(o => o.UseSqlServer(conn));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
