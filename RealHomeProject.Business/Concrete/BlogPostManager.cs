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
    public class BlogPostManager: IBlogPostService
    {
        private readonly IBlogPostDal _blogPostDal;

        public BlogPostManager(IBlogPostDal blogPostDal)
        {
            _blogPostDal = blogPostDal;
        }

        public void TAdd(BlogPost t)
        {
            _blogPostDal.Insert(t);
        }

        public void TDelete(BlogPost t)
        {
            _blogPostDal.Delete(t);
        }

        public List<BlogPost> TGetAll(Expression<Func<BlogPost, bool>> filter = null)
        {
            return _blogPostDal.GetAll(filter);
        }

        public BlogPost TGetById(int id)
        {
            return _blogPostDal.GetById(id);
        }

        public void TUpdate(BlogPost t)
        {
            _blogPostDal.Update(t);
        }
    }
}
