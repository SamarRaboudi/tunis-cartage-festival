
using FestivalCartage.Models;
using Microsoft.EntityFrameworkCore;

namespace FestivalCartage.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Concert> Concert { get; set; }

    }
}
