using Codebase.BL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codebase.Entities.Concrete;
using Codebase.Entities.DTOs;

namespace Codebase.BL.Abstract
{
    public interface IOrderService
    {
        public void PlaceOrder(int customerId, int productId, int orderQuantity);
        List<CustomerProduct> GetAll(string includeProperties = null);
        AddOrderDTO FillAddOrderDTO(int customerId = 0, int productId = 0, int quantity = 0);
    }
}
