using System.Collections.Generic;
using System.Linq;
using DAL.Interfaces.Repositories;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class OrderRepository : GenericRepository<int, Order>, IOrderRepository
    {
        public OrderRepository(ShopContext context) : base(context)
        {
            
        }

        public IList<Order> GetAllOrders()
        {
            return context.Orders
                .Include(o => o.Destination)
                .Include(o => o.Product)
                .Include(o => o.Product.ProductType)
                .Include(o => o.Vehicle)
                .ToList();
        }

        public Order GetLatestOrder()
        {
            return context.Orders
                .Include(o => o.Destination)
                .Include(o => o.Product)
                .Include(o => o.Product.ProductType)
                .Include(o => o.Vehicle)
                .OrderByDescending(o => o.StartDate)
                .FirstOrDefault();
        }
    }
}