using System;

namespace Models
{
    public class VehicleModel : BaseModel
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int MaxWidth { get; set; }
        public int MaxHeight { get; set; }
        public int MaxLength { get; set; }
        public int MaxWeight { get; set; }
        public DateTime FreeDate { get; set; }
        public VehicleTypeModel VehicleTypeModel { get; set; }
    }
}