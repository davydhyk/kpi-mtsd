using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Interfaces.Services;
using BLL.Mappers;
using DAL.Interfaces;
using Entity;
using Models;

namespace BLL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _uof;
        
        public OrderService(IUnitOfWork unitOfWork)
        {
            _uof = unitOfWork;
        }

        public IEnumerable<OrderModel> GetAllOrders()
        {
            return _uof.OrderRepository
                .GetAllOrders()
                .Select(o => o.EntityToModel());
        }
        
        public OrderModel GetLatestOrder()
        {
            return _uof.OrderRepository
                .GetLatestOrder()
                .EntityToModel();
        }

        public OrderModel ProcessOrder(ProductModel productModel, DestinationModel destinationModel)
        {
            ProductType productType = productModel.ProductTypeModel.ModelToEntity();
            // Vehicle vehicle = _uof.VehicleRepository
            //     .GetVehicleByProductType(productType);
            Vehicle vehicle = _uof.VehicleRepository
                .GetVehicleByProduct(productModel.ModelToEntity());
            Order order = new Order()
            {
                ProductId = productModel.Id,
                DestinationId = destinationModel.Id,
                VehicleId = vehicle.Id,
                StartDate = DateTime.Now
            };
            order.DeliveryStartDate = order.StartDate.Add(productType.ProcessingTime);
            TimeSpan deliveryTime = TimeSpan.FromSeconds(1.0 * destinationModel.Distance / (vehicle.Speed * 1000 / 3600));
            Console.WriteLine(destinationModel.Distance);
            Console.WriteLine(vehicle.Speed);
            Console.WriteLine(vehicle.Speed * 1000 / 3600);
            Console.WriteLine(deliveryTime);
            if (order.DeliveryStartDate <= vehicle.FreeDate)
            {
                order.DeliveryStartDate = vehicle.FreeDate;
            }
            else
            {
                vehicle.FreeDate = order.DeliveryStartDate;
            }
            order.DeliveryEndDate = order.DeliveryStartDate.Add(deliveryTime);
            vehicle.FreeDate = vehicle.FreeDate.Add(deliveryTime * 2);
            _uof.VehicleRepository.Update(vehicle);
            _uof.OrderRepository.Create(order);
            return order.EntityToModel();
        }
    }
}