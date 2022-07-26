using Microsoft.EntityFrameworkCore;
using VideogamesStore.Models.Entities;

namespace VideogamesStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }

        public DbSet<Videogame> Videogames { get; set; }
    }
}
