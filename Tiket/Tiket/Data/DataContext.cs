using Microsoft.EntityFrameworkCore;
using Tiket.Data.Entities;
namespace Tiket.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Entrance> Entrances { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasIndex(t => t.Id).IsUnique();
            modelBuilder.Entity<Entrance>().HasIndex(e=> e.Id).IsUnique();
        }
    }
}
