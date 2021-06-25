using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class ProductTypeVehicleType
    {
        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }
        
        [ForeignKey("VehicleType")]
        public int VehicleTypeId { get; set; }
        public virtual VehicleType VehicleType { get; set; }
    }
}