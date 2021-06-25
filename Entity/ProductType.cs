using System;
using System.Collections.Generic;

namespace Entity
{
    public class ProductType : BaseEntity<int>
    {
        public string Name { get; set; }
        public TimeSpan ProcessingTime { get; set; }
        public virtual IList<VehicleType> VehicleTypes { get; set; }
    }
}