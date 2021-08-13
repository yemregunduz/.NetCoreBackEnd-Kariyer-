using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidaton
{
    public class AdayTecrubeValidator:AbstractValidator<AdayTecrube>
    {
        public AdayTecrubeValidator()
        {
            RuleFor(a => a.SirketId)
                .NotNull().WithMessage(Messages.SirketGirmekZorunlu);
            RuleFor(a => a.PozisyonId)
                .NotNull().WithMessage(Messages.SirkettekiPozisyonGirilmeli);
            RuleFor(a => a.GirisTarih)
                .NotNull().WithMessage(Messages.GirisTarihiZorunlu);
        }
    }
}
