using Microsoft.EntityFrameworkCore;

namespace AluraStore
{
    internal class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<Sale> Sales { get; set; }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Address>()
                .ToTable("Adresses");

            builder
                .Entity<Address>()
                .Property<int>("CustomerId");

            builder
                .Entity<Address>()
                .HasKey("CustomerId");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=uzumymwsql9432!;Persist Security Info=True;User ID=sa;Initial Catalog=AluraStore;Data Source=localhost,1433");
        }
    }
}
