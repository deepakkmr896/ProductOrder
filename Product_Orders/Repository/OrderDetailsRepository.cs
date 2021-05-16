using Product_Orders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_Orders.Repository
{
    public class OrderDetailsRepository
    {
        #region Variables
        private readonly AppDbContext _dbContext;
        #endregion

        #region ctor
        public OrderDetailsRepository(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        #endregion
        #region Public Methods
        /// <summary>
        /// Get all orders details
        /// </summary>
        /// <returns></returns>
        public IQueryable<OrderDetails> GetAllOrderDetails()
        {
            return this._dbContext.OrderDetails;
        }

        /// <summary>
        /// Get order detail by customerOrderId
        /// </summary>
        /// <param name="customerOrderId"></param>
        /// <returns></returns>
        public OrderDetails GetOrderDetailById(int orderDetailId)
        {
            return this._dbContext.OrderDetails.Find(orderDetailId);
        }

        /// <summary>
        /// Add order detail
        /// </summary>
        /// <param name="customerOrder"></param>
        public void AddOrderDetail(OrderDetails orderDetail)
        {
            this._dbContext.OrderDetails.Add(orderDetail);
            this._dbContext.SaveChanges();
        }

        /// <summary>
        /// Delete order detail
        /// </summary>
        /// <param name="orderDetailId"></param>
        public void DeleteOrderDetailById(int orderDetailId)
        {
            OrderDetails orderDetail = this._dbContext.OrderDetails.Find(orderDetailId);
            if (orderDetail != null)
            {
                this._dbContext.OrderDetails.Remove(orderDetail);
                this._dbContext.SaveChanges();
            }
        }
        #endregion

    }
}