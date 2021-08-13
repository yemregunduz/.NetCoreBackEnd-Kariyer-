using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidaton
{
    public class IsverenValidator:AbstractValidator<Isveren>
    {
        public IsverenValidator()
        {
            RuleFor(i => i.Email)
                .NotNull().WithMessage(Messages.EmailZorunlu);
            RuleFor(i => i.WebSite)
                .NotNull().WithMessage(Messages.WebSitesiZorunlu);
            RuleFor(i => i.SirketId)
                .NotNull().WithMessage(Messages.SirketAdiGirilmeli);
            RuleFor(i => i.TelNo)
                .NotNull().WithMessage(Messages.TelNoGirilmeli);
        }
        
    }


    
}
