using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered.Entities.DTOs
{
    public class AddOrderDTO
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? ProductQuantity { get; set; }
        public int OrderQuantity { get; set; }
        public IEnumerable<SelectListItem> CustomersSelectList { get; set; }
    }
}
