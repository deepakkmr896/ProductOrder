using System;
using Product_Orders.Interface;
using Product_Orders.Models;
using Product_Orders.Repository;

namespace Product_Orders.Business
{
    public class CustomerOrderBusiness : ICustomerOrderBusiness {

        #region Variables
        private readonly CustomerOrderRepository _customerOrderRepository;
        #endregion

        #region ctor
        public CustomerOrderBusiness(CustomerOrderRepository customerOrderRepository)
        {
            this._customerOrderRepository = customerOrderRepository;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Save customer order details
        /// </summary>
        /// <param name="customerOrder"></param>
        /// <returns></returns>
        public bool SaveCustomerOrder(CustomerOrder customerOrder)
        {
            bool result = false;
            try
            {
                this._customerOrderRepository.AddCustomerOrder(customerOrder);
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