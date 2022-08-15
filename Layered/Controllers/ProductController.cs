using Layered.BLL.Abstract;
using Layered.BLL.Concrete;
using Layered.DAL.Concrete.EntityFramework;
using Layered.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Layered.Entities.Concrete;

namespace Layered.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAll();
            return View(products);
        }

        public IActionResult Add()
        {
            var product = new Product();
            return View(product);
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            _productService.Add(product);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int id)
        {
            var product =_productService.Get(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            _productService.Update(product);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}