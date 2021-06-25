using System.Collections.Generic;
using Entity;

namespace DAL.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepository<int, Product>
    {
        public IList<Product> GetAllProducts();
        public Product GetProduct(int id);
    }
}