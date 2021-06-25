using System;
using Entity;
using Models;

namespace BLL.Mappers
{
    public static class VehicleMapper
    {
        public static Vehicle ModelToEntity(this VehicleModel vehicleModel)
        {
            return new Vehicle()
            {
                Id = vehicleModel.Id,
                Name = vehicleModel.Name,
                Speed = vehicleModel.Speed,
                MaxWidth = vehicleModel.MaxWidth,
                MaxHeight = vehicleModel.MaxHeight,
                MaxLength = vehicleModel.MaxLength,
                MaxWeight = vehicleModel.MaxWeight,
                FreeDate = vehicleModel.FreeDate,
                VehicleTypeId = vehicleModel.VehicleTypeModel.Id
            };
        }
        
        public static VehicleModel EntityToModel(this Vehicle vehicle)
        {
            return new VehicleModel()
            {
                Id = vehicle.Id,
                Name = vehicle.Name,
                Speed = vehicle.Speed,
                MaxWidth = vehicle.MaxWidth,
                MaxHeight = vehicle.MaxHeight,
                MaxLength = vehicle.MaxLength,
                MaxWeight = vehicle.MaxWeight,
                FreeDate = vehicle.FreeDate,
                VehicleTypeModel = vehicle.VehicleType?.EntityToModel()
            };
        }
    }
}