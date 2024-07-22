using ASPNETCORE.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCORE.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {         
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<Actor_Movie>()
                .HasOne(m => m.Movie)                      // Configuring a navigation property
                .WithMany(am => am.Actor_Movies)             // Configuring the inverse navigation property
                .HasForeignKey(m => m.MovieId);              // Configuring the foreign key property

            modelBuilder.Entity<Actor_Movie>()
                .HasOne(a => a.Actor)                      // Configuring a navigation property
                .WithMany(am => am.Actor_Movies)             // Configuring the inverse navigation property
                .HasForeignKey(a => a.ActorId);              // Configuring the foreign key property
   
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Cinema> Cinemas { get; set; }

        public DbSet<Producer> Producers { get; set; }

        public DbSet<Actor_Movie> Actors_Movies { get; set; }

    }
}
