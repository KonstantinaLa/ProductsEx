using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using FirstAskisiOmadiki.Models;

namespace FirstAskisiOmadiki.Data.Configurations
{
    public class SupplierConfig :EntityTypeConfiguration<Supplier>
    {
        public SupplierConfig()
        {
            //SuppliersProducts
            HasMany(p => p.Products)
                .WithMany(s => s.Suppliers)
                .Map(m =>
                {
                    m.ToTable("SuppliersProducts");
                    m.MapLeftKey("SupplierId");
                    m.MapRightKey("ProductId");
                });

            //Supplier Table
            Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}