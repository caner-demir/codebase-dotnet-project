using Layered.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered.Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Ürün Adı")]
        public string Name { get; set; }
        [Display(Name = "Adedi")]
        public int Quantity { get; set; }
        [Display(Name = "Fiyatı")]
        public double Price { get; set; }
        public bool IsAvailable { get; set; } = true;
        public ICollection<CustomerProduct> CustomerProducts { get; set; }
    }
}
