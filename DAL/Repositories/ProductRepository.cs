using System.Collections.Generic;
using System.Linq;
using DAL.Interfaces.Repositories;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class ProductRepository : GenericRepository<int, Product>, IProductRepository
    {
        public ProductRepository(ShopContext context) : base(context)
        {
            
        }
        
        public IList<Product> GetAllProducts()
        {
            return context.Products.Include(p => p.ProductType).ToList();
        }

        public Product GetProduct(int id)
        {
            return context.Products
                .Include(p => p.ProductType)
                .FirstOrDefault(p => p.Id == id);
        }
    }
}