using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            var s1 = new Supplier() { Name = "Darth Vader" };
            var s2 = new Supplier() { Name = "Harry Potter" };
            var s3 = new Supplier() { Name = "Vaggelis" };
            var s4 = new Supplier() { Name = "Kostas" };
            var s5 = new Supplier() { Name = "Nikos" };
            var s6 = new Supplier() { Name = "Kostantina" };
            var s7 = new Supplier() { Name = "Mixalis" };
            var s8 = new Supplier() { Name = "Stefanos" };
            var s9 = new Supplier() { Name = "Petros" };
            var s10 = new Supplier() { Name = "Giannis" };
            var s11 = new Supplier() { Name = "Giorgos" };
            var s12 = new Supplier() { Name = "Legolas" };


            var suppliers = new List<Supplier>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12 };

            foreach (var supplier in suppliers)
            {
                context.SuppliersDbSet.AddOrUpdate(s => s.Name, supplier);
            }


            var p1 = new Product()
            {
                Title = "Chips",
                IsExpired = true,
                DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                Price = 3,
                Suppliers = new Collection<Supplier>() { s1, s2 }

            };
            var p2 = new Product()
            {
                Title = "French Coffee",
                IsExpired = false,
                DateModified = new DateTime(2021, 5, 20, 21, 15, 0),
                Price = 6
            };
            var p3 = new Product()
            {
                Title = "Cappuccino",
                IsExpired = true,
                DateModified = new DateTime(2021, 5, 17, 21, 15, 0),
                Price = 4
            };
            var p4 = new Product()
            {
                Title = "Chicken wings",
                IsExpired = true,
                DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                Price = 6
            };
            var p5 = new Product()
            {
                Title = "Spaghetti",
                IsExpired = false,
                DateModified = new DateTime(2021, 4, 2, 10, 12, 0),
                Price = 3
            };
            var p6 = new Product()
            {
                Title = "Jack Daniels",
                IsExpired = false,
                DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                Price = 25
            };
            var p7 = new Product()
            {
                Title = "Tanqueray",
                IsExpired = false,
                DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                Price = 21
            };
            var p8 = new Product()
            {
                Title = "Drambuie",
                IsExpired = false,
                DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                Price = 29
            };
            var p9 = new Product()
            {
                Title = "Havana Club",
                IsExpired = false,
                DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                Price = 23
            };
            var p10 = new Product()
            {
                Title = "Jose Cuervo",
                IsExpired = true,
                DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                Price = 24
            };
            var p11 = new Product()
            {
                Title = "Bacardi",
                IsExpired = false,
                DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                Price = 27
            };
            var p12 = new Product()
            {
                Title = "Pampers Pack",
                IsExpired = false,
                DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                Price = 38,
                Suppliers = new Collection<Supplier>() { s11, s9, s8 }
            };
            var p13 = new Product()
            {
                Title = "Onions",
                IsExpired = false,
                DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                Price = 1,
                Suppliers = new Collection<Supplier>() { s10, s11, s12 }
            };
            var p14 = new Product()
            {
                Title = "Spinach",
                IsExpired = true,
                DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                Price = 2,
                Suppliers = new Collection<Supplier>() { s10, s9, s8 }
            };
            var p15 = new Product()
            {
                Title = "Kettle",
                IsExpired = false,
                DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                Price = 75,
                Suppliers = new Collection<Supplier>() { s4, s5, s7 }
            };
            var p16 = new Product()
            {
                Title = "Pizza",
                IsExpired = true,
                DateModified = new DateTime(2021, 5, 25, 21, 15, 0),
                Price = 7,
                Suppliers = new Collection<Supplier>() {s1,s2,s3 }
            };


            var products = new List<Product>() {p1,p2,p3,p4,p5,p6,p7,p8,p9,p10,p11,p12,p13,p14,p15,p16};

            foreach (var product in products)
            {
                context.ProductsDbSet.AddOrUpdate(p=> new {p.Title , p.Price }, product);
            }

            context.SaveChanges();
        }
    }
}

