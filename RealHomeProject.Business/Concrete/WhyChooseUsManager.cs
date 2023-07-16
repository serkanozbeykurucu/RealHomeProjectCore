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
    public class WhyChooseUsManager : IWhyChooseUsService
    {
        private readonly IWhyChooseUsDal _whyChooseUsDal;

        public WhyChooseUsManager(IWhyChooseUsDal whyChooseUsDal)
        {
            _whyChooseUsDal = whyChooseUsDal;
        }

       

        public void TAdd(WhyChooseUs t)
        {
            _whyChooseUsDal.Insert(t);
        }

        public void TDelete(WhyChooseUs t)
        {
            _whyChooseUsDal.Delete(t);
        }

        public List<WhyChooseUs> TGetAll(Expression<Func<WhyChooseUs, bool>>? filter)
        {
            if (filter == null)
            {
                return _whyChooseUsDal.GetAll();
            }
            return _whyChooseUsDal.GetAllByFilter(filter);

        }

        public WhyChooseUs TGetByFilter(Expression<Func<WhyChooseUs, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
        public void TUpdate(WhyChooseUs t)
        {
           _whyChooseUsDal.Update(t);
        }
    }
}
