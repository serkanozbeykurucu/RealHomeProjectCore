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
    public class EfBlogPostDal: EfEntityRepositoryBase<Blog,Context>, IBlogPostDal
    {
    }
}
