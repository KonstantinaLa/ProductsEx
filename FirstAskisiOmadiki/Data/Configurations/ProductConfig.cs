using System.Data.Entity.ModelConfiguration;
using FirstAskisiOmadiki.Models;

namespace FirstAskisiOmadiki.Data.Configurations
{
    public class ProductConfig : EntityTypeConfiguration<Product>
    {
        public ProductConfig()
        {
           

            //Products Table
            Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(20);
        
            Property(p => p.DateModified)
                .HasColumnType("date");



        }



    }
}