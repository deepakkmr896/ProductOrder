using Product_Orders.Interface.Repository;
using Product_Orders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_Orders.Repository
{
    public class CustomerOrderRepository : ICutomerOrderRepository
    {
        #region Variables
        private readonly AppDbContext _dbContext;
        #endregion

        #region ctor
        public CustomerOrderRepository(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Add Customer Order
        /// </summary>
        /// <param name="customerOrder"></param>
        public void AddCustomerOrder(CustomerOrder customerOrder)
        {
            this._dbContext.CustomerOrder.Add(customerOrder);
            this._dbContext.SaveChanges();
        }

        /// <summary>
        /// Get all customer orders
        /// </summary>
        /// <returns></returns>
        public IQueryable<CustomerOrder> GetAllCustomerOrders()
        {
            return this._dbContext.CustomerOrder;
        }

        /// <summary>
        /// Get Customer Order by customerOrderId
        /// </summary>
        /// <param name="customerOrderId"></param>
        /// <returns></returns>
        public CustomerOrder GetCustomerOrderById(int customerOrderId)
        {
            return this._dbContext.CustomerOrder.Find(customerOrderId);
        }

        /// <summary>
        /// Delete Customer Order
        /// </summary>
        /// <param name="customerOrderId"></param>
        public void DeleteCustomerOrderById(int customerOrderId)
        {
            CustomerOrder customerOrder = this._dbContext.CustomerOrder.Find(customerOrderId);
            if (customerOrder != null)
            {
                this._dbContext.CustomerOrder.Remove(customerOrder);
                this._dbContext.SaveChanges();
            }
        }
        #endregion
    }
}