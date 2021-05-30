using System.Data.Entity;
using FirstAskisiOmadiki.Models;

namespace FirstAskisiOmadiki.Data
{
    public class MyDatabase:DbContext
    {
        public DbSet<Product> ProductsDbSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(20);


            modelBuilder.Entity<Product>()
                .Property(p => p.DateModified)
                .HasColumnType("date");

        }
    }
}