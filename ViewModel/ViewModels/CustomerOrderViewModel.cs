using System;

namespace ViewModel.ViewModels
{
    public class CustomerOrderViewModel
    {
        public int order_id { get; set; }
        public int customer_id { get; set; }
        public int total_order_quantity { get; set; }
        public double total_amount { get; set; }
        public string order_status { get; set; }
        public DateTime order_datetime { get; set; }
        public string payment_status { get; set; }
        public int delivered_quantity { get; set; }    
    }
}