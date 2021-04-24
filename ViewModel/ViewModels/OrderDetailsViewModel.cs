namespace ViewModel
{
    public class OrderDetailsViewModel
    {
        public int order_detail_id { get; set; }
        public int order_id { get; set; }
        public int fertilizer_id { get; set; }
        public int order_qty { get; set; }
        public double amount { get; set; }
        public int department_id { get; set; }        
    }
}