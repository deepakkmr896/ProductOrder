using Interface.Interface;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewModel.ViewModels;

namespace Factories.Factories
{
    public class CustomerOrderFactory : ICustomerOrderFactory
    {
        public CustomerOrder create(CustomerOrderViewModel input)
        {
            return new CustomerOrder()
            {
                order_id = input.order_id,
                customer_id = input.customer_id,
                total_order_quantity = input.total_order_quantity,
                total_amount = input.total_amount,
                order_status = input.order_status,
                order_datetime = input.order_datetime,
                payment_status = input.payment_status,
                delivered_quantity = input.delivered_quantity
            };
        }
    }
}