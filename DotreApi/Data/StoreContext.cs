using DotreApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotreApi.Data;

public class StoreContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    
}