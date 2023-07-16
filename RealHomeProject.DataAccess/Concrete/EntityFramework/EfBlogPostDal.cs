using Microsoft.EntityFrameworkCore;
using RealHomeProject.Core.DataAccess.Concrete;
using RealHomeProject.DataAccess.Abstract;
using RealHomeProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.DataAccess.Concrete.EntityFramework
{
    public class EfBlogPostDal : EfEntityRepositoryBase<Blog, Context>, IBlogPostDal
    {
        public List<Blog> GetListBlogByCategoryWithUser()
        {
            using (var context = new Context())
            {
                return context.Blogs.Include(x => x.BlogCategories).
                    Include(x=> x.AppUser).ToList();
            }
        }
    }
}
