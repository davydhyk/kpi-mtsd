using System;
using System.Collections.Generic;
using DAL.Interfaces.Repositories;
using Entity;

namespace DAL.Repositories
{
    public class VehicleTypeRepository : GenericRepository<int, VehicleType>, IVehicleTypeRepository
    {
        public VehicleTypeRepository(ShopContext context) : base(context)
        {
            
        }
    }
}