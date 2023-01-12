using FinanceTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceTracker.Data
{
    public class FinanceTrackerContext : DbContext
    {
        public FinanceTrackerContext(DbContextOptions<FinanceTrackerContext> options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Account>(account =>
            {
                account.Property(a => a.CreationDate).HasDefaultValue(DateTime.UtcNow);
            });

            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<User>(user =>
            {
                user.Property(a => a.CreationDate).HasDefaultValue(DateTime.UtcNow);
            });
        }
    }
}