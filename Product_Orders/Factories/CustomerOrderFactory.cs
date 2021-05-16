using Product_Orders.Interface;
using Product_Orders.Models;
using Product_Orders.ViewModels;

namespace Product_Orders.Factories
{
    public class CustomerOrderFactory : ICustomerOrderFactory
    {
        public CustomerOrder create(CustomerOrderViewModel input)
        {
            return new CustomerOrder()
            {
                CustomerOrderId     = input.CustomerOrderId,
                CustomerId          = input.CustomerId,
                TotalOrderQuantity  = input.TotalOrderQuantity,
                TotalAmount         = input.TotalAmount,
                OrderStatus         = input.OrderStatus,
                OrderDatetime       = input.OrderDatetime,
                PaymentStatus       = input.PaymentStatus,
                DeliveredQuantity   = input.DeliveredQuantity
            };
        }
    }
}