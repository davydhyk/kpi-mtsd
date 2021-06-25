using BLL;
using DAL;
using Microsoft.Extensions.DependencyInjection;
using ShopCLI.Interfaces;

namespace ShopCLI
{
    class App
    {
        private readonly ServiceProvider serviceProvider;
        
        public App()
        {
            IServiceCollection services = new ServiceCollection();
            services.RegisterDALDependencies();
            services.RegisterBLLDependencies();
            services.RegisterCLIDependencies();
            serviceProvider = services.BuildServiceProvider();
        }

        public void Run()
        {
            ICLInterface cli = serviceProvider.GetRequiredService<ICLInterface>();
            cli.Start();
        }
    }
}