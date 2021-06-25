using Microsoft.Extensions.DependencyInjection;
using ShopMVVM.View;
using ShopMVVM.ViewModel;

namespace ShopMVVM
{
    public static class MVVMDependencies
    {
        public static IServiceCollection RegisterMVVMDependencies(this IServiceCollection services)
        {
            services.AddScoped<MainViewModel, MainViewModel>();
            services.AddScoped<MainWindow, MainWindow>();
            return services;
        }
    }
}