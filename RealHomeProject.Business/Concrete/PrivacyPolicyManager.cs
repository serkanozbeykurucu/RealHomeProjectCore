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
    public class PrivacyPolicyManager: IPrivacyPolicyService
    {
        private readonly IPrivacyPolicyDal _privacyPolicyDal;

        public PrivacyPolicyManager(IPrivacyPolicyDal privacyPolicyDal)
        {
            _privacyPolicyDal = privacyPolicyDal;
        }

        public void TAdd(PrivacyPolicy t)
        {
           _privacyPolicyDal.Insert(t);
        }

        public void TDelete(PrivacyPolicy t)
        {
           _privacyPolicyDal.Delete(t);
        }

        public List<PrivacyPolicy> TGetAll(Expression<Func<PrivacyPolicy, bool>> filter = null)
        {
            return _privacyPolicyDal.GetAll(filter);
        }

        public PrivacyPolicy TGetById(int id)
        {
            return _privacyPolicyDal.GetById(id); 
        }

        public void TUpdate(PrivacyPolicy t)
        {
            _privacyPolicyDal.Update(t);
        }
    }
}
