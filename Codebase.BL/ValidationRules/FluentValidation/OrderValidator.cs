using Codebase.BL.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebase.BL.ValidationRules.FluentValidation
{
    public class OrderValidator : AbstractValidator<AddOrderVM>
    {
        public OrderValidator()
        {
            RuleFor(o => o.OrderQuantity).Must((model, field) => field <= model.ProductQuantity)
                .WithMessage("Stokta belirtilen miktarda ürün yok.");
        }
    }
}
