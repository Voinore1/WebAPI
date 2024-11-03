using Data.Entities.VenichleInfo;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class DBSeedExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<BodyStyle>().HasData(new[]
            {
                new BodyStyle { Id = 1, Style = "Sedan" },
                new BodyStyle { Id = 2, Style = "Coupe" },
                new BodyStyle { Id = 3, Style = "Hatchback" },
                new BodyStyle { Id = 4, Style = "SUV" },
                new BodyStyle { Id = 5, Style = "Crossover" },
                new BodyStyle { Id = 6, Style = "Convertible" },
                new BodyStyle { Id = 7, Style = "Wagon" },
                new BodyStyle { Id = 8, Style = "Van" },
                new BodyStyle { Id = 9, Style = "Truck" },
                new BodyStyle { Id = 10, Style = "Minivan" },
                new BodyStyle { Id = 11, Style = "Pickup" },
                new BodyStyle { Id = 12, Style = "Bus" },
                new BodyStyle { Id = 13, Style = "Limousine" },
                new BodyStyle { Id = 14, Style = "Cabriolet" },
                new BodyStyle { Id = 15, Style = "Roadster" }
            });

            modelBuilder.Entity<Brand>().HasData(new[]
            {
                new Brand { Id = 1, Name = "Audi" },
                new Brand { Id = 2, Name = "BMW" },
                new Brand { Id = 3, Name = "Chevrolet" },
                new Brand { Id = 4, Name = "Ford" },
                new Brand { Id = 5, Name = "Honda" },
                new Brand { Id = 6, Name = "Hyundai" },
                new Brand { Id = 7, Name = "Kia" },
                new Brand { Id = 8, Name = "Mazda" },
                new Brand { Id = 9, Name = "Mercedes-Benz" },
                new Brand { Id = 10, Name = "Nissan" },
                new Brand { Id = 11, Name = "Toyota" },
                new Brand { Id = 12, Name = "Volkswagen" }
            });

            modelBuilder.Entity<FuelType>().HasData(new[]
            {
                new FuelType { Id = 1, Name = "Gasoline" },
                new FuelType { Id = 2, Name = "Diesel" },
                new FuelType { Id = 3, Name = "Electric" },
                new FuelType { Id = 4, Name = "Hybrid" },
                new FuelType { Id = 5, Name = "LPG" },
                new FuelType { Id = 6, Name = "CNG" }
            });

            modelBuilder.Entity<Transmission>().HasData(new[]
            {
                new Transmission { Id = 1, Name = "Manual" },
                new Transmission { Id = 2, Name = "Automatic" },
                new Transmission { Id = 3, Name = "CVT" },
                new Transmission { Id = 4, Name = "DCT" }
            });

            modelBuilder.Entity<Model>().HasData(new[] {
                new Model { Id = 1, Name = "A3", BrandId = 1 },
                new Model { Id = 2, Name = "A4", BrandId = 1 },
                new Model { Id = 3, Name = "A5", BrandId = 1 },
                new Model { Id = 4, Name = "A6", BrandId = 1 },
                new Model { Id = 5, Name = "A7", BrandId = 1 },
                new Model { Id = 6, Name = "A8", BrandId = 1 },
                new Model { Id = 7, Name = "Q3", BrandId = 1 },
                new Model { Id = 8, Name = "Q5", BrandId = 1 },
                new Model { Id = 9, Name = "Q7", BrandId = 1 },
                new Model { Id = 10, Name = "Q8", BrandId = 1 },
                new Model { Id = 11, Name = "X1", BrandId = 2 },
                new Model { Id = 12, Name = "X2", BrandId = 2 },
                new Model { Id = 13, Name = "X3", BrandId = 2 },
                new Model { Id = 14, Name = "X4", BrandId = 2 },
                new Model { Id = 15, Name = "X5", BrandId = 2 },
                new Model { Id = 16, Name = "X6", BrandId = 2 },
                new Model { Id = 17, Name = "X7", BrandId = 2 },
                new Model { Id = 18, Name = "Corvette", BrandId = 3 },
                new Model { Id = 19, Name = "Camaro", BrandId = 3 },
                new Model { Id = 20, Name = "Malibu", BrandId = 3 },
                new Model { Id = 21, Name = "Impala", BrandId = 3 },
                new Model { Id = 22, Name = "Mustang", BrandId = 4 },
                new Model { Id = 23, Name = "Fiesta", BrandId = 4 },
                new Model { Id = 24, Name = "Focus", BrandId = 4 },
            });

            
        }
    }
}
