using System.Collections.Generic;
using Models;

namespace BLL.Interfaces.Services
{
    public interface IProductService
    {
        public IEnumerable<ProductModel> GetAllProducts();
        public ProductModel GetProduct(int id);
    }
}