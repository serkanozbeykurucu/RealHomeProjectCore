using RealHomeProject.Business.Abstract;
using RealHomeProject.DataAccess.Abstract;
using RealHomeProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.Business.Concrete
{
    public class TestimonialManager: ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TAdd(Testimonial t)
        {
            _testimonialDal.Insert(t);
        }

        public void TDelete(Testimonial t)
        {
            _testimonialDal.Delete(t);  
        }

        public List<Testimonial> TGetAll(Expression<Func<Testimonial, bool>>? filter)
        {
            if (filter == null)
            {
                return _testimonialDal.GetAll();
            }
            return _testimonialDal.GetAllByFilter(filter);

        }

        public Testimonial TGetByFilter(Expression<Func<Testimonial, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
        public void TUpdate(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }
}
