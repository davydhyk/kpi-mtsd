using System.Collections.Generic;

namespace Entity
{
    public class VehicleType : BaseEntity<int>
    {
        public string Name { get; set; }
        public virtual IList<ProductType> ProductTypes { get; set; }
    }
}