using FluentValidation;
using RealHomeProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.Business.ValidationRules.FluentValidation
{
    public class OurPartnerValidator : AbstractValidator<OurPartner>
    {
        public OurPartnerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu alan boş geçilemez!"); ;
            RuleFor(x => x.Name).MaximumLength(70).WithMessage("Maximum Karakter Sınırına Ulaştınız!");

            RuleFor(x => x.Image).NotEmpty();
            RuleFor(x => x.Name).MaximumLength(70).WithMessage("Maximum Karakter Sınırına Ulaştınız!");

        }
    }
}
