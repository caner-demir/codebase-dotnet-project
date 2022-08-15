using Layered.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered.BLL.Abstract
{
    public interface IProductService
    {
        Product Get(int id);
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
