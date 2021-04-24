using Model.Models;

namespace Interface.Interface
{
    public interface ICustomerOrderBusiness
    {
        /// <summary>
        /// Save sustomer order details
        /// </summary>
        /// <param name="customerOrder"></param>
        /// <returns></returns>
        bool SaveCustomerOrder(CustomerOrder customerOrder);
    }
}
