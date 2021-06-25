using System.Windows;
using BLL;
using DAL;
using Microsoft.Extensions.DependencyInjection;
using ShopMVVM.View;
using ShopMVVM.ViewModel;

namespace ShopMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            IServiceCollection services = new ServiceCollection();
            services.RegisterDALDependencies();
            services.RegisterBLLDependencies();
            services.RegisterMVVMDependencies();
            _serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainViewModel viewModel = _serviceProvider.GetService<MainViewModel>();
            MainWindow mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.DataContext = viewModel;
            mainWindow.Show();
        }
    }
}