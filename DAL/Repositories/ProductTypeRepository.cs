using DAL.Interfaces.Repositories;
using Entity;

namespace DAL.Repositories
{
    public class ProductTypeRepository : GenericRepository<int, ProductType>, IProductTypeRepository
    {
        public ProductTypeRepository(ShopContext context) : base(context)
        {
            
        }
    }
}