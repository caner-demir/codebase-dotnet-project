using Layered.BLL.Abstract;
using Layered.DAL.Abstract;
using Layered.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layered.Entities.Concrete;
using Layered.Entities.DTOs;
using Layered.Core.Aspects.Autofac.Caching;

namespace Layered.BLL.Concrete
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

        [CacheAspect]
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
