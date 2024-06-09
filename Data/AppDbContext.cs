using EntityFrameworkCoreMySQL.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreMySQL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base(options) { }

        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Article> Articles  { get; set; }
        public DbSet<Conference> Conferences { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Optional: Configure relationships and constraints
            modelBuilder.Entity<Conference>()
                .HasMany(c => c.Articles)
                .WithOne(a => a.Conference)
                .HasForeignKey(a => a.ConferenceId);
        }

    }
}
