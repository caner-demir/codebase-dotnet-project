using Codebase.Core.DataAccess;
using Codebase.Entities.Concrete;
using Codebase.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebase.DAL.Abstract
{
    public interface IOrderRepository : IEntityRepository<CustomerProduct>
    {
        AddOrderDTO FillAddOrderDTO(int customerId = 0, int productId = 0, int quantity = 0);
        public void PlaceOrder(int customerId, int productId, int orderQuantity);
    }
}
