using Microsoft.EntityFrameworkCore;
using LoyaltyApp.Models;

namespace LoyaltyApp.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Business> Businesses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<RewardScheme> RewardSchemes { get; set; }
        public DbSet<Stamp> Stamps { get; set; }
    }
}
