using Codebase.BL.Abstract;
using Codebase.DAL.Abstract;
using Codebase.Entities;
using Codebase.BL.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebase.BL.Concrete
{
    public class OrderService : IOrderService
    {
        private readonly ICustomerProductRepository _customerProductRepository;

        public OrderService(ICustomerProductRepository customerProductRepository)
        {
            _customerProductRepository = customerProductRepository;
        }

        public void Order(CustomerProduct customerProduct, int quantity)
        {
            customerProduct.Quantity = quantity;
            _customerProductRepository.Add(customerProduct);
        }

        public List<CustomerProduct> GetAll(string includeProperties = null)
        {
            return _customerProductRepository.GetAll(includeProperties: includeProperties);
        }
    }
}
