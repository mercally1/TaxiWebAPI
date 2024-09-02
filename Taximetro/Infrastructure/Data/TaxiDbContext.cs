using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class TaxiDbContext : DbContext
{
    public TaxiDbContext(DbContextOptions<TaxiDbContext> options): base(options)
    {
    }

    public DbSet<Taxi> taxis { get; set; }

    public DbSet<Conductor> conductores { get; set; }

    public DbSet<Trayecto> trayectos { get; set; }
} 
