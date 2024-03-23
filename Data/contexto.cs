using Microsoft.EntityFrameworkCore;
using ModelResidente.Residente;
using ModelsUser.User;

namespace DataContext.Context;
public class BDContext : DbContext
{

    public BDContext(DbContextOptions<BDContext> options) : base(options)
    {
    }
    //Mapear las tablas en la bd con dbset
    public DbSet<User> Users { get; set; }
    public DbSet<Residente> Residentes { get; set; }

    
}