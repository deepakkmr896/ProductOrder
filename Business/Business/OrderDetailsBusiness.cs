using System;
using Interface.Interface;
using Model.Models;

namespace Business.Business
{
    public class OrderDetailsBusiness : IOrderDetailsBusiness
    {
        public bool SaveOrderDetails(OrderDetails orderDetails)
        {
            return true;
        }
    }
}