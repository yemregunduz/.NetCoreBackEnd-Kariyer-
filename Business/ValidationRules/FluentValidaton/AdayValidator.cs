using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidaton
{
    public class AdayValidator:AbstractValidator<Aday>
    {
        public AdayValidator()
        {
            RuleFor(a => a.Ad)
                .NotEmpty().WithMessage(Messages.AdGirmekZorunludur)
                .MinimumLength(2).WithMessage(Messages.AdGecerlilik);
            RuleFor(a=>a.Soyad)
                .NotEmpty().WithMessage(Messages.SoyAdGirmekZorunludur)
                .MinimumLength(2).WithMessage(Messages.SoyAdGecerlilik);
            RuleFor(a => a.DogumYili)
                .NotNull().WithMessage(Messages.DogumYiliGirmekZorunludur)
                .GreaterThan(1900).WithMessage(Messages.GecerliBirDogumTarihiGirin);
            RuleFor(a => a.TcNo)
                .NotEmpty().WithMessage(Messages.TcGirmekZorunludur)
                .MinimumLength(11).WithMessage(Messages.TcNoMinimum11Hane)
                .MaximumLength(11).WithMessage(Messages.TcNoMax11Hane);
            RuleFor(a => a.Email)
                .NotEmpty().WithMessage(Messages.EmailZorunlu);
        }
    }
}
