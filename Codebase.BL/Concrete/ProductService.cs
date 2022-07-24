using Codebase.BL.Abstract;
using Codebase.DAL.Abstract;
using Codebase.DAL.Concrete.EntityFramework;
using Codebase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebase.BL.Concrete
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product Get(int id)
        {
            return _productRepository.Get(id);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll().Where(p => p.IsAvailable == true).ToList();
        }

        public void Add(Product product)
        {
            _productRepository.Add(product);
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }

        public void DecreaseProductQuantity(Product product, int quantity)
        {
            product.Quantity -= quantity;
            _productRepository.Update(product);
        }

        public void Delete(int id)
        {
            var product = _productRepository.Get(id);
            product.IsAvailable = false;
            _productRepository.Update(product);
        }
    }
}
