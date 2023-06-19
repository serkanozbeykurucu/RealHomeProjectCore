using RealHomeProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.Core.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class ,new()
    {
        public void Insert(T t);
        public void Update(T t);
        public void Delete(T t);
        public T GetById(int id);
        public List<T> GetAll(Expression<Func<T, bool>> filter = null);
    }    
}
