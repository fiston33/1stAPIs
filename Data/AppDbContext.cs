using Microsoft.EntityFrameworkCore;

namespace CampusEvents.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

       
        public DbSet<Models.CampusEvent> CampusEvents { get; set; }
        public DbSet<Models.Organizer> Organizers { get; set; }
        public DbSet<Models.EventCategory> EventCategories { get; set; }

       
    }
}