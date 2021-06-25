using Entity;
using Models;

namespace BLL.Mappers
{
    public static class DestinationMapper
    {
        public static Destination ModelToEntity(this DestinationModel destinationModel)
        {
            return new Destination()
            {
                Id = destinationModel.Id,
                Name = destinationModel.Name,
                Distance = destinationModel.Distance
            };
        }

        public static DestinationModel EntityToModel(this Destination destination)
        {
            return new DestinationModel()
            {
                Id = destination.Id,
                Name = destination.Name,
                Distance = destination.Distance
            };
        }
    }
}