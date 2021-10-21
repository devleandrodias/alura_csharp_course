using AluraMovies.Models;
using Microsoft.EntityFrameworkCore;

namespace AluraMovies.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Address>()
                .HasOne(x => x.MovieTheater)
                .WithOne(x => x.Address)
                .HasForeignKey<MovieTheater>(x => x.AddressId);

            builder.Entity<MovieTheater>()
                .HasOne(x => x.Manager)
                .WithMany(x => x.MoviesTheaters)
                .HasForeignKey(x => x.ManagerId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<MovieTheater> MovieTheaters { get; set; }

        public DbSet<Manager> Managers { get; set; }
    }
}
