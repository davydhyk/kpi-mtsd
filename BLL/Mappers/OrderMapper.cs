using System.Linq;
using Entity;
using Models;

namespace BLL.Mappers
{
    public static class OrderMapper
    {
        public static Order ModelToEntity(this OrderModel orderModel)
        {
            return new Order()
            {
                Id = orderModel.Id,
                StartDate = orderModel.StartDate,
                DeliveryStartDate = orderModel.DeliveryStartDate,
                DeliveryEndDate = orderModel.DeliveryEndDate,
                ProductId = orderModel.ProductModel.Id,
                Product = orderModel.ProductModel?.ModelToEntity(),
                DestinationId = orderModel.DestinationModel.Id,
                Destination = orderModel.DestinationModel?.ModelToEntity(),
                VehicleId = orderModel.VehicleModel.Id,
                Vehicle = orderModel.VehicleModel?.ModelToEntity(),
            };
        }

        public static OrderModel EntityToModel(this Order order)
        {
            return new OrderModel()
            {
                Id = order.Id,
                StartDate = order.StartDate,
                DeliveryStartDate = order.DeliveryStartDate,
                DeliveryEndDate = order.DeliveryEndDate,
                ProductModel = order.Product?.EntityToModel(),
                DestinationModel = order.Destination?.EntityToModel(),
                VehicleModel = order.Vehicle?.EntityToModel()
            };
        }
    }
}