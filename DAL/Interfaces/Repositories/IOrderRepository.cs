using System.Collections.Generic;
using Entity;

namespace DAL.Interfaces.Repositories
{
    public interface IOrderRepository : IGenericRepository<int, Order>
    {
        public IList<Order> GetAllOrders();
        public Order GetLatestOrder();
    }
}