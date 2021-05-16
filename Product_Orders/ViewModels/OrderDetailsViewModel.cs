namespace Product_Orders.ViewModel
{
    public class OrderDetailsViewModel
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int FertilizerId { get; set; }
        public int OrderQty { get; set; }
        public double Amount { get; set; }
        public int DepartmentId { get; set; }        
    }
}