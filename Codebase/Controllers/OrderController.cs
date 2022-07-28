using Codebase.BL.Abstract;
using Codebase.Entities.Concrete;
using Codebase.BL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Codebase.Entities.DTOs;

namespace Codebase.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public IActionResult GetAll()
        {
            var orders = _orderService.GetAll(includeProperties: "Customer, Product");
            return View(orders);
        }

        public IActionResult Order(int id)
        {
            var addOrderDTO = _orderService.FillAddOrderDTO(productId: id);
            return View(addOrderDTO);
        }

        [HttpPost]
        public IActionResult Order(AddOrderVM addOrderVM)
        {
            if (ModelState.IsValid)
            {
                _orderService.PlaceOrder(addOrderVM.CustomerId, addOrderVM.ProductId, addOrderVM.OrderQuantity);
                return RedirectToAction(nameof(GetAll));
            }
            return View(_orderService.FillAddOrderDTO(productId: addOrderVM.ProductId));
        }
    }
}
