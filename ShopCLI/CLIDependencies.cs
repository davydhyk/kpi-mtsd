using Microsoft.Extensions.DependencyInjection;
using ShopCLI.Interfaces;

namespace ShopCLI
{
    public static class CLIDependencies
    {
        public static IServiceCollection RegisterCLIDependencies(this IServiceCollection services)
        {
            services.AddSingleton<ICLIReader, CLIReader>();
            services.AddSingleton<ICLIWriter, CLIWriter>();
            services.AddSingleton<ICLInterface, CLInterface>();
            return services;
        }
    }
}