using System.Collections.Generic;
using System.Linq;
using DAL.Interfaces.Repositories;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class VehicleRepository : GenericRepository<int, Vehicle>, IVehicleRepository
    {
        public VehicleRepository(ShopContext context) : base(context)
        {

        }

        public IList<Vehicle> GetAllVehicles()
        {
            return context.Vehicles
                .Include(v => v.VehicleType)
                .ToList();
        }

        public Vehicle GetVehicle(int id)
        {
            return context.Vehicles
                .Include(v => v.VehicleType)
                .FirstOrDefault(v => v.Id == id);
        }

        public Vehicle GetVehicleByProductType(ProductType productType)
        {
            return context.Vehicles
                .Include(v => v.VehicleType)
                .Include(v => v.VehicleType.ProductTypes)
                .Where(v => v.VehicleType.ProductTypes.Select(pt => pt.Id).Contains(productType.Id))
                .OrderBy(v => v.FreeDate)
                .FirstOrDefault();
        }

        public Vehicle GetVehicleByProduct(Product product)
        {
            return context.Vehicles
                .Include(v => v.VehicleType)
                .Include(v => v.VehicleType.ProductTypes)
                .Where(v => v.VehicleType.ProductTypes.Select(pt => pt.Id).Contains(product.ProductTypeId))
                .Where(v => v.MaxWidth >= product.Width
                            && v.MaxHeight >= product.Height
                            && v.MaxLength >= product.Length
                            && v.MaxWeight >= product.Weight)
                .OrderBy(v => v.FreeDate)
                .FirstOrDefault();
        }
    }
}