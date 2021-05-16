using System.Data.Entity;

namespace Product_Orders.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("OrderContextConnection")
        { }
        
        public DbSet<CustomerOrder> CustomerOrder { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
    }
}