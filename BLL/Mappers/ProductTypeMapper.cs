using Entity;
using Models;

namespace BLL.Mappers
{
    public static class ProductTypeMapper
    {
        public static ProductType ModelToEntity(this ProductTypeModel productTypeModel)
        {
            return new ProductType()
            {
                Id = productTypeModel.Id,
                Name = productTypeModel.Name,
                ProcessingTime = productTypeModel.ProcessingTime
            };
        }
        
        public static ProductTypeModel EntityToModel(this ProductType productType)
        {
            return new ProductTypeModel()
            {
                Id = productType.Id,
                Name = productType.Name,
                ProcessingTime = productType.ProcessingTime
            };
        }
    }
}