using CrudCarrosFabricantes.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudCarrosFabricantes.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Carro> Carros { get; set; }
    public DbSet<Fabricante> Fabricantes { get; set; }
}