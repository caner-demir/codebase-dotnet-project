using Codebase.BL.Abstract;
using Codebase.DAL.Abstract;
using Codebase.BL.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codebase.Entities.Concrete;
using Codebase.Entities.DTOs;

namespace Codebase.BL.Concrete
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void PlaceOrder(int customerId, int productId, int orderQuantity)
        {
            _orderRepository.PlaceOrder(customerId, productId, orderQuantity);
        }

        public List<CustomerProduct> GetAll(string includeProperties = null)
        {
            return _orderRepository.GetAll(includeProperties: includeProperties);
        }

        public AddOrderDTO FillAddOrderDTO(int customerId = 0, int productId = 0, int quantity = 0)
        {
            return _orderRepository.FillAddOrderDTO(customerId, productId, quantity);
        }
    }
}
