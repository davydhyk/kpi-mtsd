using System.Collections.Generic;
using Models;

namespace ShopCLI.Interfaces
{
    public interface ICLIWriter
    {
        public void ShowMenu();
        public void ShowCatalog(IEnumerable<ProductModel> products);
        public void ShowProduct(ProductModel product);
        public void ShowDeliveryMap(IEnumerable<DestinationModel> destinations);
        public void ShowMessage(string message);
        public void ShowMessage(bool warning, string message);
        public void ShowDestination(DestinationModel destination);
        public void ShowOrder(OrderModel orderModel);
    }
}