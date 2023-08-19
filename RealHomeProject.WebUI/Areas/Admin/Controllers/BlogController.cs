using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RealHomeProject.Business.Abstract;
using RealHomeProject.Dto.Dtos.BlogDTOs;
using RealHomeProject.Entities.Concrete;

namespace RealHomeProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class BlogController : Controller
    {
        private readonly IBlogPostService _blogPostService;
        private readonly IBlogCategoryService _blogCategoryService;
        private readonly UserManager<AppUser> _userManager;

		public BlogController(IBlogPostService blogPostService, IBlogCategoryService blogCategoryService, UserManager<AppUser> userManager)
		{
			_blogPostService = blogPostService;
			_blogCategoryService = blogCategoryService;
			_userManager = userManager;
		}

		public IActionResult Index()
        {
            var result = _blogPostService.TGetListBlogByCategoryWithUser();
            return View(result);
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
            List<SelectListItem> valueCategory = ( from x in _blogCategoryService.TGetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.ID.ToString()
                                                   }).ToList();
            ViewBag.CategoryList = valueCategory;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BlogAdd(BlogAddDto blog)
        {
            var userID = await _userManager.FindByNameAsync(User.Identity.Name);
            _blogPostService.TAdd(new Blog
            {
                Title = blog.Title,
                Description = blog.Description,
                BlogCategoriesID = blog.BlogCategoriesID,
                PostDate = blog.PostDate,
                BlogImageURL = blog.BlogImageURL,
                AppUserId = userID.Id
            });
            return RedirectToAction("Index");
        }

		[HttpGet]
		public IActionResult BlogUpdate(int id)
		{
            var blogData = _blogPostService.TGetByFilter(x=> x.ID == id);
            List<SelectListItem> valueCategory = (from x in _blogCategoryService.TGetAll()
												  select new SelectListItem
												  {
													  Text = x.CategoryName,
													  Value = x.ID.ToString()
												  }).ToList();
			ViewBag.CategoryList = valueCategory;
			return View(blogData);
		}
        [HttpPost]
        public async Task<IActionResult> BlogUpdate(Blog blog)
        {
            var userID = await _userManager.FindByNameAsync(User.Identity.Name);
            _blogPostService.TUpdate(new Blog
            {
                ID = blog.ID,
                Title = blog.Title,
                Description = blog.Description,
                BlogCategoriesID = blog.BlogCategoriesID,
                PostDate = blog.PostDate,
                BlogImageURL = blog.BlogImageURL,
                AppUserId = userID.Id
            });
            return RedirectToAction("Index");
        }

        public IActionResult BlogDelete(int id)
        {
            var blogData = _blogPostService.TGetByFilter(x=> x.ID ==id);
            _blogPostService.TDelete(blogData);
            return RedirectToAction("Index");
        }
    }

 

}
