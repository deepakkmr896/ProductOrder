using Product_Orders.Interface;
using Product_Orders.Models;
using Product_Orders.ViewModel;

namespace Product_Orders.Factories
{
    public class OrderDetailsFactory : IOrderDetailsFactory
    {
        public OrderDetails create(OrderDetailsViewModel input)
        {
            return new OrderDetails()
            {
                OrderDetailsId      = input.OrderDetailId,
                FertilizerId        = input.FertilizerId,
                OrderQty            = input.OrderQty,
                Amount              = input.Amount,
                DepartmentId        = input.DepartmentId,
            };
        }
    }
}