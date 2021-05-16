using Product_Orders.Models;

namespace Product_Orders.Interface
{
    public interface ICustomerOrderBusiness
    {
        /// <summary>
        /// Save customer order details
        /// </summary>
        /// <param name="customerOrder"></param>
        /// <returns></returns>
        bool SaveCustomerOrder(CustomerOrder customerOrder);
    }
}
