﻿using RealHomeProject.Business.Abstract;
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
    public class BlogCategoryManager : IBlogCategoryService
    {
        private readonly IBlogCategoryDal _blogCategoryDal;

        public BlogCategoryManager(IBlogCategoryDal blogCategoryDal)
        {
            _blogCategoryDal = blogCategoryDal;
        }

        public void TAdd(BlogCategory t)
        {
            _blogCategoryDal.Insert(t); 
        }

        public void TDelete(BlogCategory t)
        {
            _blogCategoryDal.Delete(t);
        }

        public List<BlogCategory> TGetAll(Expression<Func<BlogCategory, bool>> filter = null)
        {
            return _blogCategoryDal.GetAll(filter); 
        }

        public BlogCategory TGetById(int id)
        {
            return _blogCategoryDal.GetById(id);    
        }

        public void TUpdate(BlogCategory t)
        {
            _blogCategoryDal.Update(t); 
        }
    }
}
