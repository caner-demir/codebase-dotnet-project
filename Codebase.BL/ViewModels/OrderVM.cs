using Codebase.BL.Utilities;
using Codebase.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebase.BL.ViewModels
{
    public class OrderVM
    {
        [ValidProductQuantity]
        public int Quantity { get; set; }
        public CustomerProduct CustomerProduct { get; set; }
        public IEnumerable<SelectListItem> CustomerList { get; set; }
    }
}
