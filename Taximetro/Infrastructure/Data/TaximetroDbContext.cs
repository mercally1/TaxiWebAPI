using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class TaximetroDbContext : DbContext
{
    public TaximetroDbContext(DbContextOptions<TaximetroDbContext> options) : base(options)
    { }

    public DbSet<Conductor> conductores { get; set; }

    public DbSet<Taxi> taxis { get; set; }

    public DbSet<Trayecto> trayectos { get; set; }
}
