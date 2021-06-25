using DAL.Interfaces;
using DAL.Interfaces.Repositories;
using DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DAL
{
    public static class DALDependencies
    {
        public static IServiceCollection RegisterDALDependencies(this IServiceCollection services)
        {
            services.AddScoped<ShopContext, ShopContext>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<IVehicleTypeRepository, VehicleTypeRepository>();
            services.AddScoped<IProductTypeRepository, ProductTypeRepository>();
            services.AddScoped<IDestinationRepository, DestinationRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}