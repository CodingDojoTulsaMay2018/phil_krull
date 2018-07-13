using Microsoft.EntityFrameworkCore;
 
namespace RelationshipDemo.Models
{
    public class Context : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Ninja> Ninjas {get;set;}
        public DbSet<Dojo> Dojos {get;set;}
    }
}