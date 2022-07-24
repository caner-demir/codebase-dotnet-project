using Codebase.Entities;
using Codebase.BL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebase.BL.Abstract
{
    public interface IOrderService
    {
        public void Order(CustomerProduct customerProduct, int quantity);
        List<CustomerProduct> GetAll(string includeProperties = null);
    }
}
