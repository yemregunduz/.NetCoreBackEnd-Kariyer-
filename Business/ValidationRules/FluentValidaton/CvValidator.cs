using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidaton
{
    class CvValidator:AbstractValidator<Cv>
    {
        public CvValidator()
        {
            RuleFor(c => c.AdayId)
                .NotNull().WithMessage(Messages.CvKimeAit);
            RuleFor(c => c.OnYazi)
                .MaximumLength(500).WithMessage(Messages.OnyaziKarakterSiniri);
            
        }
    }
}
