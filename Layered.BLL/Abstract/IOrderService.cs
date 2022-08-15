using Layered.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layered.Entities.Concrete;
using Layered.Entities.DTOs;

namespace Layered.BLL.Abstract
{
    public interface IOrderService
    {
        public void PlaceOrder(int customerId, int productId, int orderQuantity);
        List<CustomerProduct> GetAll(string includeProperties = null);
        AddOrderDTO FillAddOrderDTO(int customerId = 0, int productId = 0, int quantity = 0);
    }
}
