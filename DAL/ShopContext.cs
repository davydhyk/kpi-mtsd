using System;
using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DAL
{
    public class ShopContext : DbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=;database=shop",
                new MariaDbServerVersion(new Version(10, 3))
            );
            optionsBuilder.UseLoggerFactory(MyLoggerFactory);
            // optionsBuilder.UseSqlServer(@"server=localhost;user=root;password=;database=shop");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            
            modelBuilder.Entity<VehicleType>()
                .HasMany(vt => vt.ProductTypes)
                .WithMany(pt => pt.VehicleTypes);
        }
        
        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });
    }
}