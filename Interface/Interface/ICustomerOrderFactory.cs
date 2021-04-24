using Model.Models;
using ViewModel.ViewModels;

namespace Interface.Interface
{
    public interface ICustomerOrderFactory
    {
        /// <summary>
        /// Convert CustomerOrder Model to CustomerOrderViewModel
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        CustomerOrder create(CustomerOrderViewModel input);
    }
}