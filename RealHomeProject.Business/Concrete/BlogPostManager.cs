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
    public class BlogPostManager : IBlogPostService
	{
		private readonly IBlogPostDal _blogPostDal;

		public BlogPostManager(IBlogPostDal blogPostDal)
		{
			_blogPostDal = blogPostDal;
		}

		public void TAdd(Blog t)
		{
			_blogPostDal.Insert(t);
		}

		public void TDelete(Blog t)
		{
			_blogPostDal.Delete(t);
		}

		public List<Blog> TGetAll(Expression<Func<Blog, bool>>? filter)
		{
			if (filter == null)
			{
				return _blogPostDal.GetAll();
			}
			return _blogPostDal.GetAllByFilter(filter);

		}

		public Blog TGetByFilter(Expression<Func<Blog, bool>> filter = null)
		{
			return _blogPostDal.GetByFilter(filter);
		}

        public List<Blog> TGetListBlogByCategoryWithUser()
        {
           return _blogPostDal.GetListBlogByCategoryWithUser();
        }

        public void TUpdate(Blog t)
		{
			_blogPostDal.Update(t);
		}
	}
}
