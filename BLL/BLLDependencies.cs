using BLL.Interfaces.Services;
using BLL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BLL
{
    public static class BLLDependencies
    {
        public static IServiceCollection RegisterBLLDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<IDestinationService, DestinationService>();
            services.AddSingleton<IVehicleService, VehicleService>();
            services.AddSingleton<IOrderService, OrderService>();
            return services;
        }
    }
}