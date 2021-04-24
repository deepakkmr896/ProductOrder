﻿using Business.Business;
using Factories.Factories;
using Model.Models;
using System.Web.Http;
using ViewModel;
using ViewModel.ViewModels;

namespace Product_Orders.Controllers.Api
{
    public class OrdersController : ApiController
    {
        #region Variables
        private readonly CustomerOrderFactory _customerOrderFactory;
        private readonly OrderDetailsFactory _orderDetailsFactory;
        private readonly CustomerOrderBusiness _customerOrderBusiness;
        private readonly OrderDetailsBusiness _orderDetailsBusiness;
        #endregion

        #region ctor
        public OrdersController(CustomerOrderFactory customerOrderFactory, 
                                OrderDetailsFactory orderDetailsFactory,
                                CustomerOrderBusiness customerOrderBusiness,                   
                                OrderDetailsBusiness orderDetailsBusiness)
        {
            this._customerOrderFactory  = customerOrderFactory;
            this._orderDetailsFactory   = orderDetailsFactory;
            this._customerOrderBusiness = customerOrderBusiness;
            this._orderDetailsBusiness  = orderDetailsBusiness;
        }
        #endregion

        [Route("api/SaveCustomerOrder"), HttpPost]
        public IHttpActionResult Post([FromBody] CustomerOrderViewModel cusomerOrderViewModel)
        {
            // Convert the CustomerOrderViewModel data into CustomerOrder model entity
            CustomerOrder customerOrder = this._customerOrderFactory.create(cusomerOrderViewModel);

            // Save the Customer Order details into the Customer_Order table, here I have used the dummy method to return true
            bool result = this._customerOrderBusiness.SaveCustomerOrder(customerOrder);
            
            return Ok(result);
        }

        [Route("api/SaveOrderDetails"), HttpPost]
        public IHttpActionResult Post([FromBody] OrderDetailsViewModel orderDetailsViewModel)
        {
            // Convert the OrderDetailsViewModel data into OrderDetails model entity
            OrderDetails orderDetails = this._orderDetailsFactory.create(orderDetailsViewModel);

            // Save the Order Details into the Order_Details table, here I have used the dummy method to return true
            bool result = this._orderDetailsBusiness.SaveOrderDetails(orderDetails);
            
            return Ok(result);
        }
    }
}