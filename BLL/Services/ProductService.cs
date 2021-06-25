using System.Collections.Generic;
using System.Linq;
using BLL.Interfaces.Services;
using BLL.Mappers;
using DAL.Interfaces;
using Models;

namespace BLL.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _uof;
        
        public ProductService(IUnitOfWork unitOfWork)
        {
            _uof = unitOfWork;
        }

        public IEnumerable<ProductModel> GetAllProducts()
        {
            return _uof.ProductRepository
                .GetAllProducts()
                .Select(p => p.EntityToModel());
        }

        public ProductModel GetProduct(int id)
        {
            return _uof.ProductRepository
                .GetProduct(id)
                ?.EntityToModel();
        }
    }
}