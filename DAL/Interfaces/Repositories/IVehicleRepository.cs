using System.Collections.Generic;
using Entity;

namespace DAL.Interfaces.Repositories
{
    public interface IVehicleRepository : IGenericRepository<int, Vehicle>
    {
        public IList<Vehicle> GetAllVehicles();
        public Vehicle GetVehicle(int id);

        public Vehicle GetVehicleByProductType(ProductType productType);

        public Vehicle GetVehicleByProduct(Product product);
    }
}