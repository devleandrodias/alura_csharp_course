using AluraMovies.Models;
using Microsoft.EntityFrameworkCore;

namespace AluraMovies.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> opt) : base(opt)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Address> Address { get; set; }
    }
}
