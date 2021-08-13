using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidaton
{
    public class BolumValidator:AbstractValidator<Bolum>
    {
        public BolumValidator()
        {
            RuleFor(b => b.BolumAdi)
                .NotNull().WithMessage(Messages.BolumAdiGirilmeli)
                .MinimumLength(5).WithMessage(Messages.BolumAdiEnAz5Karakter);
            
            
        }
    }
}
