using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model.Models
{
    public class OrderDetails
    {
        public int order_detail_id { get; set; }
        public int order_id { get; set; }
        public int fertilizer_id { get; set; }
        public int order_qty { get; set; }
        public double amount { get; set; }
        public int department_id { get; set; }        
    }
}