using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using BLL.Interfaces.Services;
using Models;
using ShopMVVM.Commands;

namespace ShopMVVM.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly IDestinationService _destinationService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        
        public Command ProcessOrderCommand { get; private set; }
        public ObservableCollection<DestinationModel> Destinations { get; set; }
        private DestinationModel _selectedDestination { get; set; }
        public DestinationModel SelectedDestination
        {
            get { return _selectedDestination; }
            set
            {
                _selectedDestination = value;
                OnPropertyChanged();
            }
        }
        
        public ObservableCollection<ProductModel> Products { get; set; }
        private ProductModel _selectedProduct { get; set; }
        public ProductModel SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                _selectedProduct = value;
                OnPropertyChanged();
            }
        }

        private OrderModel _latestOrder;
        public OrderModel LatestOrder
        {
            get { return _latestOrder; }
            set
            {
                _latestOrder = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel(IDestinationService destinationService, IProductService productService,
            IOrderService orderService)
        {
            _destinationService = destinationService;
            _productService = productService;
            _orderService = orderService;

            ProcessOrderCommand = new Command(obj => ProcessOrder(),
                obj => CanProcessOrder());
            
            Init();
        }

        private void Init()
        {
            Destinations = new ObservableCollection<DestinationModel>(_destinationService.GetAllDestinations());
            SelectedDestination = Destinations.FirstOrDefault();

            Products = new ObservableCollection<ProductModel>(_productService.GetAllProducts());
            SelectedProduct = Products.FirstOrDefault();

            LatestOrder = _orderService.GetLatestOrder();
        }

        private void ProcessOrder()
        {
            MessageBoxResult confirm = MessageBox.Show("Are you sure you want to confirm the order?", 
                "Order processing", MessageBoxButton.YesNo);
            if (confirm == MessageBoxResult.No)
            {
                return;
            }

            _orderService.ProcessOrder(SelectedProduct, SelectedDestination);
            LatestOrder = _orderService.GetLatestOrder();
            MessageBox.Show("All information about order you can see in the right panel",
                "You successfully complete the order");
        }

        private bool CanProcessOrder()
        {
            return SelectedProduct != null 
                   && SelectedDestination != null;
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}