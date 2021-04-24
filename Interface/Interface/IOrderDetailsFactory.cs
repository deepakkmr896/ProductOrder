using Model.Models;
using ViewModel;

namespace Interface.Interface
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