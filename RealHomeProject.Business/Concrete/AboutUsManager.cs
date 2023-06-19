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
    public class AboutUsManager : IAboutUsService
    {
        private readonly IAboutUsDal _aboutUsDal;

        public AboutUsManager(IAboutUsDal aboutUsDal)
        {
            _aboutUsDal = aboutUsDal;
        }

        public void TAdd(AboutUs t)
        {
           _aboutUsDal.Insert(t);
        }

        public void TDelete(AboutUs t)
        {
            _aboutUsDal.Delete(t);
        }

        public List<AboutUs> TGetAll(Expression<Func<AboutUs, bool>> filter = null)
        {
           return _aboutUsDal.GetAll(filter);
        }

        public AboutUs TGetById(int id)
        {
             return _aboutUsDal.GetById(id);
        }

        public void TUpdate(AboutUs t)
        {
            _aboutUsDal.Update(t);  
        }
    }
}
