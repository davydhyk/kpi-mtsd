using System;
using System.Collections.Generic;

namespace Models
{
    public class ProductTypeModel : BaseModel
    {
        public string Name { get; set; }
        public TimeSpan ProcessingTime { get; set; }
        public IList<VehicleTypeModel> VehicleTypeModels { get; set; }
    }
}