using Entity;
using Models;

namespace BLL.Mappers
{
    public static class ProductMapper
    {
        public static Product ModelToEntity(this ProductModel productModel)
        {
            return new Product()
            {
                Id = productModel.Id,
                Name = productModel.Name,
                Price = productModel.Price,
                Width = productModel.Width,
                Height = productModel.Height,
                Length = productModel.Length,
                Weight = productModel.Weight,
                ProductTypeId = productModel.ProductTypeModel.Id,
                ProductType = productModel.ProductTypeModel?.ModelToEntity()
            };
        }
        
        public static ProductModel EntityToModel(this Product product)
        {
            return new ProductModel()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Width = product.Width,
                Height = product.Height,
                Length = product.Length,
                Weight = product.Weight,
                ProductTypeModel = product.ProductType?.EntityToModel()
            };
        }
    }
}