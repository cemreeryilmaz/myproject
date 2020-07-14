using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using MvcWebUI.Models;

namespace MvcWebUI.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator:AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Adınızı Giriniz");
            RuleFor(x => x.FirstName).MinimumLength(3);
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyadınızı Giriniz"); ;
            RuleFor(x => x.Address).NotEmpty().WithMessage("Adresinizi Giriniz"); ;
            RuleFor(x => x.City).NotEmpty().When(x => x.Age < 18).WithMessage("Yaşınız 18den Küçükse Lütfen Şehir Giriniz.!");

        }
    }
}
