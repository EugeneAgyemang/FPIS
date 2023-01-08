using Microsoft.EntityFrameworkCore;

namespace FPIS.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=FPIS;Username=postgres;Password=eugene");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasIndex(user => user.EmpID).IsUnique();
        }
    }
}
