using Layered.BLL.Abstract;
using Layered.DAL.Abstract;
using Layered.DAL.Concrete.EntityFramework;
using Layered.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered.BLL.Concrete
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

        public void Delete(int id)
        {
            var product = _productRepository.Get(id);
            product.IsAvailable = false;
            _productRepository.Update(product);
        }
    }
}
