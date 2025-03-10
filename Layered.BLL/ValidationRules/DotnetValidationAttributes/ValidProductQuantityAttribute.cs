﻿using Layered.BLL.Abstract;
using Layered.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered.BLL.ValidationRules.DotnetValidationAttributes
{
    public class ValidProductQuantityAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var quantity = Convert.ToInt32(value);
            var AddOrderVM = (AddOrderVM)validationContext.ObjectInstance;
            if (quantity < AddOrderVM.ProductQuantity)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Stokta belirtilen miktarda ürün yok.");
        }
    }
}
