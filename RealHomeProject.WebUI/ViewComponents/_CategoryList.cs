using Microsoft.AspNetCore.Mvc;
using RealHomeProject.Business.Abstract;

namespace RealHomeProject.WebUI.ViewComponents
{
    public class _CategoryList: ViewComponent
    {
        private readonly IBlogCategoryService _blogCategoryService;

        public _CategoryList(IBlogCategoryService blogCategoryService)
        {
            _blogCategoryService = blogCategoryService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _blogCategoryService.TGetAll();
            return View(result);  
        }
    }
}
