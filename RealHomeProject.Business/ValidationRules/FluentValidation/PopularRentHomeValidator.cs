using FluentValidation;
using RealHomeProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.Business.ValidationRules.FluentValidation
{
    public class PopularRentHomeValidator: AbstractValidator<PopularRentHome>
    {
        public PopularRentHomeValidator()
        {
            RuleFor(x => x.RentHomeImage).NotEmpty().WithMessage("Bu alan boş geçilemez!");
            RuleFor(x => x.RentHomeImage).MaximumLength(6);

            RuleFor(x => x.RentHomeName).NotEmpty().WithMessage("Bu alan boş geçilemez!");
            RuleFor(x => x.RentHomeName).MaximumLength(50).WithMessage("Maximum karakter sayısına ulaştınız!");
            
            RuleFor(x => x.RentHomeDescription).NotEmpty().WithMessage("Bu alan boş geçilemez!");
            RuleFor(x => x.RentHomeDescription).MaximumLength(50).WithMessage("Maximum karakter sayısına ulaştınız!");

            RuleFor(x => x.RentHomePrice).NotEmpty().WithMessage("Bu alan boş geçilemez!");

        }
    }
}
