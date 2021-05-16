using Product_Orders.Interface;
using Product_Orders.Models;
using Product_Orders.Repository;
using System;

namespace Product_Orders.Business
{
    public class OrderDetailsBusiness : IOrderDetailsBusiness
    {
        #region Variables
        private readonly OrderDetailsRepository _orderDetailsRepository;
        #endregion

        #region ctor
        public OrderDetailsBusiness(OrderDetailsRepository orderDetailsRepository)
        {
            this._orderDetailsRepository = orderDetailsRepository;
        }
        #endregion

        #region Public Mehods
        /// <summary>
        /// Save order details
        /// </summary>
        /// <param name="orderDetails"></param>
        /// <returns></returns>
        public bool SaveOrderDetails(OrderDetails orderDetails)
        {
            bool result = false;
            try
            {
                this._orderDetailsRepository.AddOrderDetail(orderDetails);
                result = true;
            }

            catch (Exception ex)
            {
                throw new Exception("Something went wrong!");
            }
            return result;
        }
        #endregion
    }
}