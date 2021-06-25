using DAL.Interfaces;
using DAL.Interfaces.Repositories;
using DAL.Repositories;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShopContext _context;
        public IProductRepository ProductRepository { get; }
        public IVehicleTypeRepository VehicleTypeRepository { get; }
        public IVehicleRepository VehicleRepository { get; }
        public IProductTypeRepository ProductTypeRepository { get; }
        public IDestinationRepository DestinationRepository { get; }
        public IOrderRepository OrderRepository { get; }
        
        public UnitOfWork(ShopContext context, IProductRepository productRepository, 
            IVehicleTypeRepository vehicleTypeRepository, IVehicleRepository vehicleRepository, 
            IProductTypeRepository productTypeRepository, IDestinationRepository destinationRepository,
            IOrderRepository orderRepository)
        {
            _context = context;
            ProductRepository = productRepository;
            VehicleTypeRepository = vehicleTypeRepository;
            VehicleRepository = vehicleRepository;
            ProductTypeRepository = productTypeRepository;
            DestinationRepository = destinationRepository;
            OrderRepository = orderRepository;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}