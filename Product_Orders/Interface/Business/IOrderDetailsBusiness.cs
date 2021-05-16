using Product_Orders.Models;

namespace Product_Orders.Interface
{
    public interface IOrderDetailsBusiness
    {
        /// <summary>
        /// Save order details
        /// </summary>
        /// <param name="orderDetails"></param>
        /// <returns></returns>
        bool SaveOrderDetails(OrderDetails orderDetails);
    }
}