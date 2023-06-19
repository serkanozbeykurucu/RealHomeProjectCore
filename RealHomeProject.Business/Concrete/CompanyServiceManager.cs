using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RealHomeProject.Business.Abstract;
using RealHomeProject.DataAccess.Abstract;
using RealHomeProject.Entities.Concrete;

namespace RealHomeProject.Business.Concrete
{
    public class CompanyServiceManager: ICompanyService
    {
        private readonly ICompanyServiceDal _companyServiceDal;

        public CompanyServiceManager(ICompanyServiceDal companyServiceDal)
        {
            _companyServiceDal = companyServiceDal;
        }

        public void TAdd(CompanyService t)
        {
            _companyServiceDal.Insert(t);
        }

        public void TDelete(CompanyService t)
        {
            _companyServiceDal.Delete(t);   
        }

        public List<CompanyService> TGetAll(Expression<Func<CompanyService, bool>> filter = null)
        {
            return _companyServiceDal.GetAll(filter);   
        }

        public CompanyService TGetById(int id)
        {
            return _companyServiceDal.GetById(id);
        }

        public void TUpdate(CompanyService t)
        {
            _companyServiceDal.Update(t);
        }
    }
}
