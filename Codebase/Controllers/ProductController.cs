﻿using Codebase.BL.Abstract;
using Codebase.BL.Concrete;
using Codebase.DAL.Concrete.EntityFramework;
using Codebase.Entities;
using Codebase.BL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Codebase.Controllers
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