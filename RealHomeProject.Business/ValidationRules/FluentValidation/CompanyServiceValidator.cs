using FluentValidation;
using RealHomeProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.Business.ValidationRules.FluentValidation
{
    public class CompanyServiceValidator: AbstractValidator<CompanyService>
    {
        public CompanyServiceValidator()
        {
            RuleFor(x => x.ServiceImage).NotEmpty().WithMessage("Bu alan boş geçilemez!");
            RuleFor(x => x.ServiceImage).MaximumLength(6);

            RuleFor(x => x.ServiceName).NotEmpty().WithMessage("Bu alan boş geçilemez!");
            RuleFor(x => x.ServiceName).MaximumLength(50).WithMessage("Maximum karakter sayısına ulaştınız!");

            RuleFor(x => x.ServiceDescription).NotEmpty().WithMessage("Bu alan boş geçilemez!");
            RuleFor(x => x.ServiceDescription).MaximumLength(100).WithMessage("Maximum karakter sayısına ulaştınız!");
        }
    }
}
