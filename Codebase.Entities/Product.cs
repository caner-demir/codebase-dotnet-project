using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebase.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Ürün Adı")]
        public string Name { get; set; }
        [Display(Name = "Adedi")]
        public int Quantity { get; set; }
        [Display(Name = "Fiyatı")]
        public virtual double Price { get; set; }
        public bool IsAvailable { get; set; } = true;
        public ICollection<CustomerProduct> CustomerProducts { get; set; }
    }
}
