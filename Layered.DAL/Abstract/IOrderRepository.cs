using Layered.Core.DataAccess;
using Layered.Entities.Concrete;
using Layered.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered.DAL.Abstract
{
    public interface IOrderRepository : IEntityRepository<CustomerProduct>
    {
        AddOrderDTO FillAddOrderDTO(int customerId = 0, int productId = 0, int quantity = 0);
        public void PlaceOrder(int customerId, int productId, int orderQuantity);
    }
}
