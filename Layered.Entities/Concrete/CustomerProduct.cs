using Layered.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered.Entities.Concrete
{
    public class CustomerProduct : IEntity
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
    }
}
