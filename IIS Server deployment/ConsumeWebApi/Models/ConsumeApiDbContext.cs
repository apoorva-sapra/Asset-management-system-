using Microsoft.EntityFrameworkCore;
using ConsumeWebApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace ConsumeWebApi.Models
{

public class ConsumeApiDbContext :IdentityDbContext
{
    
    public DbSet<Request> Requests{get;set;}
    public ConsumeApiDbContext(DbContextOptions<ConsumeApiDbContext> options)
    :base(options)
    { }
     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
      
    }

}
}