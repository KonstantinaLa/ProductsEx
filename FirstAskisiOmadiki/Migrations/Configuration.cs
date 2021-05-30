using System.Collections.Generic;
using FirstAskisiOmadiki.Models;

namespace FirstAskisiOmadiki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<FirstAskisiOmadiki.Data.MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FirstAskisiOmadiki.Data.MyDatabase context)
        {
            var p1 = new Product()
            { Title = "Patatakia", IsExpired = true, DateModified = new DateTime(2021, 5, 25, 21, 15, 0) , Price = 2};
            var p2 = new Product()
            { Title = "Sokolates", IsExpired = false, DateModified = new DateTime(2021, 5, 25, 21, 15, 0) ,Price = 3};
            var p3 = new Product()
            { Title = "Fistikia", IsExpired = true, DateModified = new DateTime(2021, 5, 25, 21, 15, 0),Price = 5};
            var p4 = new Product()
            { Title = "Whiskey", IsExpired = true, DateModified = new DateTime(2021, 5, 25, 21, 15, 0) ,Price = 70};

            var products = new List<Product>(){p1,p2,p3,p4};

            foreach (var product in products)
            {
                context.ProductsDbSet.AddOrUpdate(p=>new{p.Title,p.Price},product);
            }

        }
    }
}
