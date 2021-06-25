using System.Collections.Generic;

namespace Models
{
    public class VehicleTypeModel : BaseModel
    {
        public string Name { get; set; }
        public IList<ProductTypeModel> ProductTypeModels { get; set; }
    }
}