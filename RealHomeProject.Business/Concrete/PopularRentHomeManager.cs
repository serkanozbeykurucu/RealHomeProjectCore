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
    public class PopularRentHomeManager : IPopularRentHomeService
    {
        private readonly IPopularRentHomeDal _popularRentHomeDal;

        public PopularRentHomeManager(IPopularRentHomeDal popularRentHomeDal)
        {
            _popularRentHomeDal = popularRentHomeDal;
        }

        public void TAdd(PopularRentHome t)
        {
            _popularRentHomeDal.Insert(t);
        }

        public void TDelete(PopularRentHome t)
        {
            _popularRentHomeDal.Delete(t);
        }

        public List<PopularRentHome> TGetAll(Expression<Func<PopularRentHome, bool>>? filter= null)
        {
            if (filter == null)
            {
                return _popularRentHomeDal.GetAll();
            }
            return _popularRentHomeDal.GetAllByFilter(filter);

        }

        public PopularRentHome TGetByFilter(Expression<Func<PopularRentHome, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
        public void TUpdate(PopularRentHome t)
        {
            _popularRentHomeDal.Update(t);  
        }
    }
}
