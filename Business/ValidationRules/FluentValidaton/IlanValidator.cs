using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidaton
{
    public class IlanValidator:AbstractValidator<Ilan>
    {
        public IlanValidator()
        {
            
            RuleFor(i => i.IsverenId)
                .NotNull().WithMessage(Messages.IsverenGirilmeli);
            RuleFor(i => i.IlanYayinTarih)
                .NotNull().WithMessage(Messages.IlanTarihiGerekli);
            RuleFor(i => i.AcikPozisyonAdet)
                .NotNull().WithMessage(Messages.AcikPozisyonSayisiBelirtilmeli);
            RuleFor(i => i.SonBasvuruTarih)
                .NotNull().WithMessage(Messages.SonBasvuruTarihiGirilmeli);
            RuleFor(i => i.PozisyonId)
                .NotNull().WithMessage(Messages.SirkettekiPozisyonGirilmeli);
        }
    }
}
