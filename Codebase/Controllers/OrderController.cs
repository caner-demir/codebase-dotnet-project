using Codebase.BL.Abstract;
using Codebase.Entities;
using Codebase.BL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Codebase.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;

        public OrderController(IOrderService orderService, IProductService productService, ICustomerService customerService)
        {
            _orderService = orderService;
            _productService = productService;
            _customerService = customerService;
        }
        public IActionResult Index()
        {
            var orders = _orderService.GetAll(includeProperties: "Customer,Product");
            return View(orders);
        }

        public IActionResult Order(int id)
        {
            var orderVM = new OrderVM();
            orderVM.CustomerProduct = new CustomerProduct()
            {
                Product = _productService.Get(id)
            };
            orderVM.CustomerList = _customerService.GetAll().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            return View(orderVM);
        }

        [HttpPost]
        public IActionResult Order(OrderVM orderVM)
        {
            if (ModelState.IsValid)
            {
                var customerProduct = new CustomerProduct()
                {
                    CustomerId = orderVM.CustomerProduct.Customer.Id,
                    ProductId = orderVM.CustomerProduct.Product.Id,
                    Quantity = orderVM.CustomerProduct.Product.Quantity,
                    Date = DateTime.Now
                };
                _productService.DecreaseProductQuantity(orderVM.CustomerProduct.Product, orderVM.Quantity);
                _orderService.Order(customerProduct, orderVM.Quantity);
                return RedirectToAction(nameof(Index));
            }

            orderVM.CustomerList = _customerService.GetAll().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            return View(orderVM);
        }
    }
}
