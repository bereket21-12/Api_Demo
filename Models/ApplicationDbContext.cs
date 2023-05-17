using apidb2.Models;
using Microsoft.EntityFrameworkCore;
namespace apidb2.Services;

public class ApplicationDbContext : DbContext {

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Agent> Agents { get; set; }

    

  
}