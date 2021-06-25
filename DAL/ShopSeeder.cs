using System;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public static class ShopSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Destination>().HasData(
                new Destination() { Id = 1, Name = "New Orleans", Distance = 20000},
                new Destination() { Id = 2, Name = "Baton Rouge", Distance = 122000},
                new Destination() { Id = 3, Name = "Lafayette", Distance = 196000},
                new Destination() { Id = 4, Name = "Houma", Distance = 70000},
                new Destination() { Id = 5, Name = "Kansas City", Distance = 54000}
            );
            
            modelBuilder.Entity<ProductType>().HasData(
                new ProductType() { Id = 1, Name = "Machinery", ProcessingTime = new TimeSpan(0, 30, 0)},
                new ProductType() { Id = 2, Name = "Furniture", ProcessingTime = new TimeSpan(0, 45, 0)},
                new ProductType() { Id = 3, Name = "Animals", ProcessingTime = new TimeSpan(1, 30, 0)},
                new ProductType() { Id = 4, Name = "Medicine", ProcessingTime = new TimeSpan(0, 15, 0)}
            );

            modelBuilder.Entity<VehicleType>().HasData(
                new VehicleType() { Id = 1, Name = "Truck"},
                new VehicleType() { Id = 2, Name = "Van"},
                new VehicleType() { Id = 3, Name = "Car"},
                new VehicleType() { Id = 4, Name = "F1 Car"}
            );

            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Jerboa", Price = 500, Width = 50, Height = 50, Length = 50, Weight = 5123, ProductTypeId = 3},
                new Product() { Id = 2, Name = "Cage", Price = 55, Width = 50, Height = 50, Length = 50, Weight = 5000, ProductTypeId = 2},
                new Product() { Id = 3, Name = "Pills", Price = 15, Width = 43, Height = 24, Length = 37, Weight = 2000, ProductTypeId = 4},
                new Product() { Id = 4, Name = "Feeding Station", Price = 4499, Width = 100, Height = 50, Length = 20, Weight = 4500, ProductTypeId = 1}
            );

            modelBuilder.Entity("ProductTypeVehicleType", b =>
            {
                b.HasData(
                    new {ProductTypesId = 1, VehicleTypesId = 1},
                    new {ProductTypesId = 2, VehicleTypesId = 1},
                    new {ProductTypesId = 4, VehicleTypesId = 1},
                    new {ProductTypesId = 2, VehicleTypesId = 2},
                    new {ProductTypesId = 4, VehicleTypesId = 2},
                    new {ProductTypesId = 4, VehicleTypesId = 3},
                    new {ProductTypesId = 3, VehicleTypesId = 4},
                    new {ProductTypesId = 4, VehicleTypesId = 4}
                );
            });

            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle()
                {
                    Id = 1, Name = "McLaren MCL34", Speed = 350, MaxWidth = 50, MaxHeight = 50, MaxLength = 50, MaxWeight = 5500,
                    FreeDate = DateTime.Now, VehicleTypeId = 4
                },
                new Vehicle()
                {
                    Id = 2, Name = "Ferrari SF1000", Speed = 354, MaxWidth = 45, MaxHeight = 30, MaxLength = 40, MaxWeight = 4654,
                    FreeDate = DateTime.Now, VehicleTypeId = 4
                },
                new Vehicle()
                {
                    Id = 3, Name = "Ford Mustang", Speed = 215, MaxWidth = 45, MaxHeight = 30, MaxLength = 40, MaxWeight = 4550,
                    FreeDate = DateTime.Now, VehicleTypeId = 3
                },
                new Vehicle()
                {
                    Id = 4, Name = "Ford Transit", Speed = 135, MaxWidth = 110, MaxHeight = 65, MaxLength = 21, MaxWeight = 75000,
                    FreeDate = DateTime.Now, VehicleTypeId = 2
                },
                new Vehicle()
                {
                    Id = 5, Name = "Mercedes-Benz Actros 6", Speed = 105, MaxWidth = 180, MaxHeight = 210, MaxLength = 450, MaxWeight = 2025000,
                    FreeDate = DateTime.Now, VehicleTypeId = 1
                }
            );
        }
    }
}