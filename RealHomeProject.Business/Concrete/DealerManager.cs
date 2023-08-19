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
    public class DealerManager : IDealerService
    {
        private readonly IDealerDal _dealerDal;

        public DealerManager(IDealerDal dealerDal)
        {
            _dealerDal = dealerDal;
        }

        public void TAdd(Dealer t)
        {
            _dealerDal.Insert(t);
        }

        public void TDelete(Dealer t)
        {
            _dealerDal.Delete(t);
        }

        public List<Dealer> TGetAll(Expression<Func<Dealer, bool>>? filter)
        {
            if (filter == null)
            {
                return _dealerDal.GetAll();
            }
            return _dealerDal.GetAllByFilter(filter);

        }

        public Dealer TGetByFilter(Expression<Func<Dealer, bool>> filter = null)
        {
            return _dealerDal.GetByFilter(filter);
        }
        public void TUpdate(Dealer t)
        {
            _dealerDal.Update(t);
        }
    }
}
