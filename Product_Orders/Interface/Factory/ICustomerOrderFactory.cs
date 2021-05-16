using Product_Orders.Models;
using Product_Orders.ViewModels;

namespace Product_Orders.Interface
{
    public interface ICustomerOrderFactory
    {
        /// <summary>
        /// Convert CustomerOrder Model to CustomerOrderViewModel
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        CustomerOrder create(CustomerOrderViewModel input);
    }
}