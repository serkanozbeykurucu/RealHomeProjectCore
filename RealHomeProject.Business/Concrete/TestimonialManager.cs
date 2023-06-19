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

        public List<Testimonial> TGetAll(Expression<Func<Testimonial, bool>> filter = null)
        {
           return _testimonialDal.GetAll (filter);
        }

        public Testimonial TGetById(int id)
        {
            return _testimonialDal.GetById(id);
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }
}
