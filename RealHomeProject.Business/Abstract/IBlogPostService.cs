using RealHomeProject.Entities.Concrete;

namespace RealHomeProject.Business.Abstract
{
    public interface IBlogPostService: IGenericRepository<Blog>
    {
        public List<Blog> TGetListBlogByCategoryWithUser();
    }
}