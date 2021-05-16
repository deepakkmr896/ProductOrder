using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Product_Orders.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailsId { get; set; }
        public int FertilizerId { get; set; }
        public int OrderQty { get; set; }
        public double Amount { get; set; }
        public int DepartmentId { get; set; }
        public IQueryable<CustomerOrder> CustomerOrders {get; set;}
    }
}