using Microsoft.EntityFrameworkCore;
using zadatak.Models;

namespace zadatak.Data;

public class BazaContext: DbContext
{
    public BazaContext(DbContextOptions<BazaContext> options) : base(options)
    {
        
    }

    public DbSet<Restoran> Restorani { get; set; }
    public DbSet<Jelo> Jela { get; set; }

}