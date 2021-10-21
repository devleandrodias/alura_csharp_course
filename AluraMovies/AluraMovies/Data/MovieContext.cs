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
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<MovieTheater> MovieTheaters { get; set; }
    }
}
