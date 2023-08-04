using CrudEfCoreNet6.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudEfCoreNet6.Data;

public class AppDbContext: DbContext
{
    public DbSet<Team> Teams { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
}