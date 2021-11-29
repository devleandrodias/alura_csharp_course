using Microsoft.EntityFrameworkCore;

namespace AluraStore
{
    internal class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=uzumymwsql9432!;Persist Security Info=True;User ID=sa;Initial Catalog=AluraStore;Data Source=localhost,1433");
        }
    }
}
