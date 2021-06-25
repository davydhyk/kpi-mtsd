using DAL.Interfaces.Repositories;
using Entity;

namespace DAL.Repositories
{
    public class DestinationRepository : GenericRepository<int, Destination>, IDestinationRepository
    {
        public DestinationRepository(ShopContext context) : base(context)
        {
            
        }
    }
}