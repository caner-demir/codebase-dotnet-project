using Codebase.BL.ValidationRules.DotnetValidationAttributes;
using Codebase.Entities.DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebase.BL.ViewModels
{
    public class AddOrderVM
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        //[ValidProductQuantity]
        public int OrderQuantity { get; set; }
        public IEnumerable<SelectListItem> CustomersSelectList { get; set; }
    }
}
