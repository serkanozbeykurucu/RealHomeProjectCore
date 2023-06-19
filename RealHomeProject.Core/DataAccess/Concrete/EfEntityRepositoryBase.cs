using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealHomeProject.Core.DataAccess.Abstract;
using RealHomeProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.Core.DataAccess.Concrete
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, new()
        where TContext : DbContext, new()
    {
        public void Delete(TEntity t)
        {
            using (var c = new TContext())
            {
                c.Remove(t);
                c.SaveChanges();    
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var c = new TContext())
            {
                return c.Set<TEntity>().ToList();
            }
        }

        public TEntity GetById(int id)
        {
            using (var c = new TContext())
            {
                return c.Set<TEntity>().Find(id);
            }
        }

        public void Insert(TEntity t)
        {
            using (var c = new TContext())
            {
                c.Add(t);
                c.SaveChanges();
            }
        }

        public void Update(TEntity t)
        {
            using (var c = new TContext())
            {
                c.Update(t);
                c.SaveChanges();
            }
        }
    }
}
