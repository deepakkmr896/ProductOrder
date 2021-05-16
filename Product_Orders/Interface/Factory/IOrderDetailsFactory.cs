using Product_Orders.Models;
using Product_Orders.ViewModel;

namespace Product_Orders.Interface
{
    public interface IOrderDetailsFactory
    {
        /// <summary>
        /// Convert orderDetails Model to OrderDetailsViewModel
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        OrderDetails create(OrderDetailsViewModel input);
    }
}