using System;
using System.Data.Entity;
using Interface.Interface;
using Model.Models;

namespace Business.Business
{
    public class OrderDetailsBusiness : IOrderDetailsBusiness
    {
        private readonly DbContext _context;
        public bool SaveOrderDetails(OrderDetails orderDetails)
        {
            bool result = false;
            try
            {
                this._context.Set<OrderDetails>().Add(orderDetails);
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