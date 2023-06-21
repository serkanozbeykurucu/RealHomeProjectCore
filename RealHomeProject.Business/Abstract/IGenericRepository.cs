using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.Business.Abstract
{
    public interface IGenericRepository<T>
    {
        public void TAdd(T t);
        public void TUpdate(T t);
        public void TDelete(T t);
        public T TGetById(int id);
        public List<T> TGetAll(Expression<Func<T, bool>> filter = null);
    }
}
