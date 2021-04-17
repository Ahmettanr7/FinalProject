﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            //Kendimizinde metot üretebileceğimizi göstermek adına saçma bir örnek..
            RuleFor(p => p.ProductName).Must(StarWithA).When(p => p.CategoryId == 1).WithMessage("Kategori Id si 1 olan ürünler A harfi ile başlamalı");
        }

        private bool StarWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
