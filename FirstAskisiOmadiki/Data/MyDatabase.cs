using System.Data.Entity;
using FirstAskisiOmadiki.Data.Configurations;
using FirstAskisiOmadiki.Models;

namespace FirstAskisiOmadiki.Data
{
    public class MyDatabase:DbContext
    {
        public DbSet<Product> ProductsDbSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new SupplierConfig());

            modelBuilder.Configurations.Add(new ProductConfig());
        }
    }
}