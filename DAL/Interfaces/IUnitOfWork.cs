using DAL.Interfaces.Repositories;

namespace DAL.Interfaces
{
    public interface IUnitOfWork
    {
        public IProductTypeRepository ProductTypeRepository { get; }
        public IProductRepository ProductRepository { get; }
        public IVehicleTypeRepository VehicleTypeRepository { get; }
        public IVehicleRepository VehicleRepository { get; }
        public IDestinationRepository DestinationRepository { get; }
        public IOrderRepository OrderRepository { get; }
        public void Save();
    }
}