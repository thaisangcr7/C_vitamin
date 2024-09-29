using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Data
{
    public class ApplicationDBContexts : DbContext
    {
        public ApplicationDBContexts(DbContextOptions<ApplicationDBContexts> options)
            : base(options)
        {
        }

        public DbSet<Stocks> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }

        // Add the OnModelCreating method here
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stocks>()
                .HasMany(s => s.Comments)  // Stocks has many Comments
                .WithOne(c => c.Stocks)     // Each Comment has one Stock
                .HasForeignKey(c => c.StockId);  // Foreign key

            base.OnModelCreating(modelBuilder);
        }
    }
}
