using System;
using Interface.Interface;
using Model.Models;
using System.Data.Entity;

namespace Business.Business
{
    public class CustomerOrderBusiness : ICustomerOrderBusiness
    {
        private readonly DbContext _context;
        public bool SaveCustomerOrder(CustomerOrder customerOrder)
        {
            bool result = false;
            try
            {
                this._context.Set<CustomerOrder>().Add(customerOrder);
                this._context.SaveChanges();
                result = true;
            }

            catch (Exception ex)
            {
            }
            return result;
        }
    }
}