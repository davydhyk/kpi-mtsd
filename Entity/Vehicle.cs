using System;

namespace Entity
{
    public class Vehicle : BaseEntity<int>
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int MaxWidth { get; set; }
        public int MaxHeight { get; set; }
        public int MaxLength { get; set; }
        public int MaxWeight { get; set; }
        public DateTime FreeDate { get; set; }
        public int VehicleTypeId { get; set; }
        public virtual VehicleType VehicleType { get; set; }
    }
}