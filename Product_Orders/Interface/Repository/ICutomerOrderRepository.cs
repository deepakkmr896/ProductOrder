using Product_Orders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_Orders.Interface.Repository
{
    public interface ICutomerOrderRepository
    {
        /// <summary>
        /// Get all customer orders
        /// </summary>
        /// <returns></returns>
        IQueryable<CustomerOrder> GetAllCustomerOrders();

        /// <summary>
        /// Get Customer Order by customerOrderId
        /// </summary>
        /// <param name="customerOrderId"></param>
        /// <returns></returns>
        CustomerOrder GetCustomerOrderById(int customerOrderId);

        /// <summary>
        /// Add Customer Order
        /// </summary>
        /// <param name="customerOrder"></param>
        void AddCustomerOrder(CustomerOrder customerOrder);

        /// <summary>
        /// Delete Customer Order
        /// </summary>
        /// <param name="customerOrderId"></param>
        void DeleteCustomerOrderById(int customerOrderId);
    }
}