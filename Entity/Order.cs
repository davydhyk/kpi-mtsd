using System;

namespace Entity
{
    public class Order : BaseEntity<int>
    {
        public DateTime StartDate { get; set; }
        public DateTime DeliveryStartDate { get; set; }
        public DateTime DeliveryEndDate { get; set; }
        
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        
        public int DestinationId { get; set; }
        public virtual Destination Destination { get; set; }
        
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}