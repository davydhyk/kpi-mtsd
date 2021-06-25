using System;
using System.Linq;
using Entity;
using Models;

namespace BLL.Mappers
{
    public static class VehicleTypeMapper
    {
        public static VehicleType ModelToEntity(this VehicleTypeModel vehicleTypeModel)
        {
            return new VehicleType()
            {
                Id = vehicleTypeModel.Id,
                Name = vehicleTypeModel.Name,
                ProductTypes = vehicleTypeModel.ProductTypeModels
                    ?.Select(ptm => ptm.ModelToEntity())
                    .ToList()
            };
        }

        public static VehicleTypeModel EntityToModel(this VehicleType vehicleType)
        {
            return new VehicleTypeModel()
            {
                Id = vehicleType.Id,
                Name = vehicleType.Name,
                ProductTypeModels = vehicleType.ProductTypes
                    ?.Select(pt => pt.EntityToModel())
                    .ToList()
            };
        }
    }
}