using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Threading;
using System.Web;
using FirstAskisiOmadiki.Data;
using FirstAskisiOmadiki.Models;

namespace FirstAskisiOmadiki.Repositories
{
    public class ProductRepos
    {
        public MyDatabase ProductContext;

        public ProductRepos()
        {
            ProductContext= new MyDatabase();
        }

        public ICollection<Product> GetAllProducts()
        {
           var products = ProductContext.ProductsDbSet.ToList();
           return products;
        }

        public Product FindById(int? id)
        {
            var product = ProductContext.ProductsDbSet.Find(id);
            return product;
        }

        public void Create(Product product)
        {
            ProductContext.Entry(product).State = EntityState.Added;
            SaveChanges();
        }

        public void Edit(Product product)
        {
            ProductContext.Entry(product).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(Product product)
        {
            ProductContext.Entry(product).State = EntityState.Deleted;
            SaveChanges();
        }

        public void Dispose()
        {
            ProductContext.Dispose();
        }

        public void SaveChanges()
        {
            ProductContext.SaveChanges();
        }
    }
}