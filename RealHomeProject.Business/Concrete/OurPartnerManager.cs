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
    public class OurPartnerManager : IOurPartnerService
    {
        private readonly IOurPartnerDal _ourPartnerDal;

        public OurPartnerManager(IOurPartnerDal ourPartnerDal)
        {
            _ourPartnerDal = ourPartnerDal;
        }

        public void TAdd(OurPartner t)
        {
            _ourPartnerDal.Insert(t);
        }

        public void TDelete(OurPartner t)
        {
            _ourPartnerDal.Delete(t);
        }

        public List<OurPartner> TGetAll(Expression<Func<OurPartner, bool>> filter = null)
        {
            return _ourPartnerDal.GetAll(filter);
        }

        public OurPartner TGetById(int id)
        {
            return _ourPartnerDal.GetById(id);
        }

        public void TUpdate(OurPartner t)
        {
            _ourPartnerDal.Update(t);
        }
    }
}
