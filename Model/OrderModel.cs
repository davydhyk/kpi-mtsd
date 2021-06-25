using System;
using Entity;

namespace Models
{
    public class OrderModel : BaseModel
    {
        public DateTime StartDate { get; set; }
        public DateTime DeliveryStartDate { get; set; }
        public DateTime DeliveryEndDate { get; set; }
        public ProductModel ProductModel { get; set; }
        public DestinationModel DestinationModel { get; set; }
        public VehicleModel VehicleModel { get; set; }
    }
}