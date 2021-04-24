using Model.Models;
namespace Interface.Interface
{
    public interface IOrderDetailsBusiness
    {
        /// <summary>
        /// Save sustomer order details
        /// </summary>
        /// <param name="orderDetails"></param>
        /// <returns></returns>
        bool SaveOrderDetails(OrderDetails orderDetails);
    }
}