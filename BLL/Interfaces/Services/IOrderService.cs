using System.Collections.Generic;
using Entity;
using Models;

namespace BLL.Interfaces.Services
{
    public interface IOrderService
    {
        public OrderModel ProcessOrder(ProductModel productModel, DestinationModel destinationModel);
        public IEnumerable<OrderModel> GetAllOrders();
        public OrderModel GetLatestOrder();
    }
}