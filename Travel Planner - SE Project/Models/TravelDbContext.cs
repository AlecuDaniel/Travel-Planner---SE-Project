using Microsoft.EntityFrameworkCore;
using Travel_Planner___SE_Project.Models;

namespace Travel_Planner___SE_Project.Data
{
    public class TravelDbContext : DbContext
    {
        public TravelDbContext(DbContextOptions<TravelDbContext> options) : base(options)
        {
        }

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<SearchHistory> SearchHistories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // You can add seed data or further configuration here
        }
    }
}
