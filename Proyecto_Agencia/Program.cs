/********************************************************  
 *    Autor:Pérez Hernández Jazziel.                    *
 *    Fecha creación: 06 de febrero del 2023.           *
 *    Fecha actualización: 08 de febrero del 2023.      *
 *    Descripción: Actualización de Program.            *
 ********************************************************/
using Microsoft.EntityFrameworkCore;
using Proyecto_Agencia.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Conexión a la base de datos
builder.Services.AddDbContext<AgenciaAutomotrizContext>(options 
    => options.UseSqlServer(builder.Configuration.GetConnectionString("conexion")));

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
