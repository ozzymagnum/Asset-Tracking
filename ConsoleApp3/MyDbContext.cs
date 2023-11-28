using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    internal class MyDbContext : DbContext
    {
        string connectionString = "Data Source=DESKTOP-U6RE9DO;Initial Catalog=AssetsTracking2;Integrated Security=True;Encrypt=False";

        public DbSet<Phone> Phones { get; set; }
        public DbSet<Laptop> Laptops { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // We tell the app to use the connectionstring.
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phone>().HasData(new Phone
            {
                Id = 1,
                Model = "Samsung",
                PurchaseDate = new DateTime(2023, 1, 1),
                Price = 3500
            });

            modelBuilder.Entity<Phone>().HasData(new Phone
            {
                Id = 2,
                Model = "Iphone",
                PurchaseDate = new DateTime(2020, 5, 10),
                Price = 6000
            });

            modelBuilder.Entity<Phone>().HasData(new Phone
            {
                Id = 4,
                Model = "Iphone",
                PurchaseDate = new DateTime(2023, 5, 10),
                Price = 6000
            });

            modelBuilder.Entity<Phone>().HasData(new Phone
            {
                Id = 3,
                Model = "Android",
                PurchaseDate = new DateTime(2018, 2, 15),
                Price = 2500
            });

            modelBuilder.Entity<Laptop>().HasData(new Laptop
            {
                Id = 1,
                Model = "Lenovo",
                PurchaseDate = new DateTime(2010, 7, 10),
                Price = 5500
            });

            modelBuilder.Entity<Laptop>().HasData(new Laptop
            {
                Id = 2,
                Model = "MAC",
                PurchaseDate = new DateTime(2014, 3, 4),
                Price = 8000
            });

            modelBuilder.Entity<Laptop>().HasData(new Laptop
            {
                Id = 3,
                Model = "HP",
                PurchaseDate = new DateTime(2017, 3, 1),
                Price = 3455
            });
         }
    }
}

