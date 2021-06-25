using System.Collections.Generic;
using System.Linq;
using BLL.Interfaces.Services;
using BLL.Mappers;
using DAL.Interfaces;
using Models;

namespace BLL.Services
{
    public class DestinationService : IDestinationService
    {
        private readonly IUnitOfWork _uof;

        public DestinationService(IUnitOfWork unitOfWork)
        {
            _uof = unitOfWork;
        }
        
        public IEnumerable<DestinationModel> GetAllDestinations()
        {
            return _uof.DestinationRepository
                .ReadAll()
                .Select(d => d.EntityToModel());
        }

        public DestinationModel GetDestination(int id)
        {
            return _uof.DestinationRepository
                .Read(id)
                ?.EntityToModel();
        }
    }
}