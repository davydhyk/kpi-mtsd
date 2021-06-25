using System.Collections.Generic;
using BLL.Interfaces.Services;
using BLL.Mappers;
using DAL.Interfaces;
using DAL.Repositories;
using Entity;
using Models;

namespace BLL.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IUnitOfWork _uof;
        private readonly IVehicleService _vehicleService;

        public VehicleService(IUnitOfWork unitOfWork, IVehicleService vehicleService)
        {
            _uof = unitOfWork;
            _vehicleService = vehicleService;
        }
    }
}