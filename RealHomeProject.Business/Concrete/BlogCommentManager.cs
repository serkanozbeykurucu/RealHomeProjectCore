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
    public class BlogCommentManager : IBlogCommentService
    {
        private readonly IBlogCommentDal _blogCommentDal;

        public BlogCommentManager(IBlogCommentDal blogCommentDal)
        {
            _blogCommentDal = blogCommentDal;
        }

        public void TAdd(BlogComment t)
        {
            _blogCommentDal.Insert(t);
        }

        public void TDelete(BlogComment t)
        {
            _blogCommentDal.Delete(t);
        }

        public List<BlogComment> TGetAll(Expression<Func<BlogComment, bool>>? filter)
        {
            if (filter == null)
            {
                return _blogCommentDal.GetAll();
            }
            return _blogCommentDal.GetAllByFilter(filter);

        }

        public BlogComment TGetByFilter(Expression<Func<BlogComment, bool>> filter = null)
        {
            return _blogCommentDal.GetByFilter(filter);
        }

        public void TUpdate(BlogComment t)
        {
            _blogCommentDal.Update(t);
        }
    }
}
