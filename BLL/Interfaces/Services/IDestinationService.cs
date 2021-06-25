using System.Collections.Generic;
using Models;

namespace BLL.Interfaces.Services
{
    public interface IDestinationService
    {
        public IEnumerable<DestinationModel> GetAllDestinations();
        public DestinationModel GetDestination(int id);
    }
}