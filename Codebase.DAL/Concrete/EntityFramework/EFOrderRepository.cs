using Codebase.Core.DataAccess.EntityFramework;
using Codebase.DAL.Abstract;
using Codebase.Entities.Concrete;
using Codebase.Entities.DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebase.DAL.Concrete.EntityFramework
{
    public class EFOrderRepository : EFEntityRepository<CustomerProduct, ApplicationDbContext>, IOrderRepository
    {
        public void PlaceOrder(int customerId, int productId, int orderQuantity)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var product = context.Set<Product>().Find(productId);
                if (product != null)
                {
                    product.Quantity -= orderQuantity;
                    context.Update(product);
                }
                var order = new CustomerProduct()
                {
                    CustomerId = customerId,
                    ProductId = productId,
                    Date = DateTime.Now,
                    Quantity = orderQuantity
                };
                context.Add(order);
                context.SaveChanges();
            }
        }

        public AddOrderDTO FillAddOrderDTO(int customerId = 0, int productId = 0, int quantity = 0)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var productDetails = context.Set<Product>().Find(productId);
                return new AddOrderDTO()
                {
                    CustomerId = customerId,
                    ProductId = productId,
                    ProductName = productDetails?.Name,
                    ProductQuantity = productDetails?.Quantity,
                    OrderQuantity = quantity,
                    CustomersSelectList = context.Set<Customer>().ToList().Select(i => new SelectListItem
                    {
                        Text = i.Name,
                        Value = i.Id.ToString()
                    })

                };
            }
        }
    }
}
