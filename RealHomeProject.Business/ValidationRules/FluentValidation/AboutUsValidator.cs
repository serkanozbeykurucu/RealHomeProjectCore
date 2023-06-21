using FluentValidation;
using RealHomeProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.Business.ValidationRules.FluentValidation
{
    public class AboutUsValidator: AbstractValidator<AboutUs>
    {
        public AboutUsValidator() 
        {
            RuleFor(x=> x.Title).NotEmpty().WithMessage("Bu Alan Boş Geçilemez!");
            RuleFor(x => x.Title).Length(10,50);
            RuleFor(x => x.Title).MaximumLength(50);
            
            RuleFor(x=> x.Description).NotEmpty().WithMessage("Bu Alan Boş Geçilemez!");
            RuleFor(x => x.Description).Length(10,300);
            RuleFor(x => x.Description).MaximumLength(300).WithMessage("Maximum Karakter Sınırına Ulaştınız!");
            
            RuleFor(x=> x.ImageURL).NotEmpty().WithMessage("Bu Alan Boş Geçilemez!");
            RuleFor(x => x.ImageURL).Length(5,300);
        }
    }
}
