using BLL.Interfaces.Services;
using Models;
using ShopCLI.Interfaces;

namespace ShopCLI
{
    public class CLInterface : ICLInterface
    {
        private readonly ICLIReader _cliReader;
        private readonly ICLIWriter _cliWriter;
        private readonly IProductService _productService;
        private readonly IDestinationService _destinationService;
        private readonly IOrderService _orderService;

        private ProductModel _product;
        private DestinationModel _destination;
        
        public CLInterface(ICLIReader cliReader, ICLIWriter cliWriter, 
            IProductService productService, IDestinationService destinationService,
            IOrderService orderService)
        {
            _cliReader = cliReader;
            _cliWriter = cliWriter;
            _productService = productService;
            _destinationService = destinationService;
            _orderService = orderService;
        }
        
        public void Start()
        {
            bool isWorking = true;
            int menuItem;
            while (isWorking)
            {
                _cliWriter.ShowMenu();
                menuItem = _cliReader.GetMenuItemNumber();
                switch (menuItem)
                {
                    case 1:
                        _cliWriter.ShowCatalog(_productService.GetAllProducts());
                        break;
                    case 2:
                        int productId = _cliReader.GetProductId();
                        ProductModel product = _productService.GetProduct(productId);
                        if (product == null) break;
                        _cliWriter.ShowProduct(product);
                        break;
                    case 3:
                        _product = _productService.GetProduct(_cliReader.GetProductId());
                        if (_product == null)
                        {
                            _cliWriter.ShowMessage(true, "Product with that id not exist!");
                            break;
                        }
                        _cliWriter.ShowMessage("You have chosen the product successfully!");
                        break;
                    case 4:
                        _cliWriter.ShowDeliveryMap(_destinationService.GetAllDestinations());
                        break;
                    case 5:
                        _destination = _destinationService.GetDestination(_cliReader.GetDestinationId());
                        if (_destination == null)
                        {
                            _cliWriter.ShowMessage(true, "Destination with that id not exist!");
                            break;
                        }
                        _cliWriter.ShowMessage("You have chosen the place of delivery successfully!");
                        break;
                    case 6:
                        if (_product == null)
                        {
                            _cliWriter.ShowMessage(true, "You need to choose product!");
                            break;
                        }
                        if (_destination == null)
                        {
                            _cliWriter.ShowMessage(true, "You need to choose delivery place!");
                            break;
                        }
                        _cliWriter.ShowProduct(_product);
                        _cliWriter.ShowDestination(_destination);
                        bool confirm = _cliReader.GetConfirm();
                        if (!confirm)
                        {
                            _cliWriter.ShowMessage("The order was canceled!");
                            break;
                        }
                        OrderModel orderModel = _orderService.ProcessOrder(_product, _destination);
                        _cliWriter.ShowMessage("Order processed!");
                        _cliWriter.ShowOrder(orderModel);
                        _destination = null;
                        _product = null;
                        break;
                    case 7:
                        isWorking = false;
                        break;
                }
            }
        }
    }
}