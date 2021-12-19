using System;

namespace _037Interfaces
{
    public class Order
    {
        public float TotalPrice;
        public int Id { get; set; } 
      
        public Shipment Shipment { get; set; }
        public bool IsShipped {
            get { return Shipment != null; } }
        public DateTime DatePlaced { get;  set; }
     

       
    }
}