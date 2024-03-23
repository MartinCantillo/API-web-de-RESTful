using Microsoft.EntityFrameworkCore;
using DataContext.Context;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor.
builder.Services.AddDbContext<BDContext>(options =>
    options.UseMySQL("server=localhost;port=3306;database=bdroles;user=root;"));

builder.Services.AddControllers();

var app = builder.Build();

// Configure el pipeline de solicitudes HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
