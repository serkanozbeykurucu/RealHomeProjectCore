using FluentValidation;
using RealHomeProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.Business.ValidationRules.FluentValidation
{
    public class TestimonialValidator : AbstractValidator<Testimonial>
    {
        public TestimonialValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu alan boş geçilemez!"); ;
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Maximum karakter sayısına ulaştınız!"); ;

            RuleFor(x => x.Image).NotEmpty();
            RuleFor(x => x.Image).MaximumLength(200).WithMessage("Maximum karakter sayısına ulaştınız!"); ;

            RuleFor(x => x.Appelation).NotEmpty();
            RuleFor(x => x.Appelation).MaximumLength(100).WithMessage("Maximum karakter sayısına ulaştınız!"); ;

            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Description).MaximumLength(400).WithMessage("Maximum karakter sayısına ulaştınız!"); ;

        }
    }
}
