using System;
using Interface.Interface;
using Model.Models;

namespace Business.Business
{
    public class CustomerOrderBusiness : ICustomerOrderBusiness
    {
        public bool SaveCustomerOrder(CustomerOrder customerOrder)
        {
            return true;
        }
    }
}