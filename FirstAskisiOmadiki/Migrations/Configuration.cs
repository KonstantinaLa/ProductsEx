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
            context.ProductsDbSet.AddOrUpdate(p => new { p.Title, p.Price },

                new Product()
                {
                    Title = "Chips",
                    IsExpired = true,
                    DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                    Price = 3
                    
                },
                new Product()
                {
                    Title = "French Coffee",
                    IsExpired = false,
                    DateModified = new DateTime(2021, 5, 20, 21, 15, 0),
                    Price = 6
                },
                new Product()
                {
                    Title = "Cappuccino",
                    IsExpired = true,
                    DateModified = new DateTime(2021, 5, 17, 21, 15, 0),
                    Price = 4
                },
                new Product()
                {
                    Title = "Chicken wings",
                    IsExpired = true,
                    DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                    Price = 6
                },
                new Product()
                {
                    Title = "Spaghetti",
                    IsExpired = false,
                    DateModified = new DateTime(2021, 4, 2, 10, 12, 0),
                    Price = 3
                },
                new Product()
                {
                    Title = "Jack Daniels",
                    IsExpired = false,
                    DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                    Price = 25
                },
                new Product()
                {
                    Title = "Tanqueray",
                    IsExpired = false,
                    DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                    Price = 21
                },
                new Product()
                {
                    Title = "Drambuie",
                    IsExpired = false,
                    DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                    Price = 29
                },
                new Product()
                {
                    Title = "Havana Club",
                    IsExpired = false,
                    DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                    Price = 23
                },
                new Product()
                {
                    Title = "Jose Cuervo",
                    IsExpired = true,
                    DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                    Price = 24
                },
                new Product()
                {
                    Title = "Bacardi",
                    IsExpired = false,
                    DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                    Price = 27
                },
                new Product()
                {
                    Title = "Pampers Pack",
                    IsExpired = false,
                    DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                    Price = 38
                },
                new Product()
                {
                    Title = "Onions",
                    IsExpired = false,
                    DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                    Price = 1
                },
                new Product()
                {
                    Title = "Spinach",
                    IsExpired = true,
                    DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                    Price = 2
                },
                new Product()
                {
                    Title = "Kettle",
                    IsExpired = false,
                    DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                    Price = 75
                },
                new Product()
                {
                    Title = "Pizza",
                    IsExpired = true,
                    DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                    Price = 7
                }
            );
            context.SaveChanges();

        }
    }
}
