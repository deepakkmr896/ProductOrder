using System;

namespace Product_Orders.ViewModels
{
    public class CustomerOrderViewModel
    {
        public int CustomerOrderId { get; set; }
        public int CustomerId { get; set; }
        public int TotalOrderQuantity { get; set; }
        public double TotalAmount { get; set; }
        public bool OrderStatus { get; set; }
        public DateTime OrderDatetime { get; set; }
        public bool PaymentStatus { get; set; }
        public int DeliveredQuantity { get; set; }    
    }
}