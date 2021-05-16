using Product_Orders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_Orders.Interface.Repository
{
    public interface IOrderDetailsRepository
    {
        /// <summary>
        /// Get all orders details
        /// </summary>
        /// <returns></returns>
        IQueryable<OrderDetails> GetAllOrderDetails();

        /// <summary>
        /// Get order detail by customerOrderId
        /// </summary>
        /// <param name="customerOrderId"></param>
        /// <returns></returns>
        OrderDetails GetOrderDetailById(int orderDetailId);

        /// <summary>
        /// Add order detail
        /// </summary>
        /// <param name="customerOrder"></param>
        void AddOrderDetail(OrderDetails orderDetail);

        /// <summary>
        /// Delete order detail
        /// </summary>
        /// <param name="orderDetailId"></param>
        void DeleteOrderDetailById(int orderDetailId);
    }
}