using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Interface.Interface;
using Model.Models;
using ViewModel;

namespace Factories.Factories
{
    public class OrderDetailsFactory : IOrderDetailsFactory
    {
        public OrderDetails create(OrderDetailsViewModel input)
        {
            return new OrderDetails()
            {
                order_id        = input.order_id,
                fertilizer_id   = input.fertilizer_id,
                order_qty       = input.order_qty,
                amount          = input.amount,
                department_id   = input.department_id,
            };
        }
    }
}