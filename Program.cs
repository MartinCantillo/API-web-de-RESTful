using Microsoft.EntityFrameworkCore;
using DataContext.Context;
using ServicesUserService.UserService;
using RepositoriesUserRepository.UserRepository;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios  de la config de la bd al contenedor.
builder.Services.AddDbContext<BDContext>(options =>
    options.UseMySQL("server=localhost;port=3306;database=bdroles;user=root;"));

// Agregar el servicio UserService al contenedor, aqui agrego todos los servicios necesarios para que la ioc me la reconozca
builder.Services.AddScoped<IUserRepository,UserService>();

builder.Services.AddControllers();
//Agregar Swager
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure el pipeline de solicitudes HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
