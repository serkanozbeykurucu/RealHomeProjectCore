using Microsoft.EntityFrameworkCore.Query;
using RealHomeProject.Core.DataAccess.Abstract;
using RealHomeProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.DataAccess.Abstract
{
    public interface IBlogPostDal: IEntityRepository<Blog>
    {
        public List<Blog> GetListBlogByCategoryWithUser();
    }
}
