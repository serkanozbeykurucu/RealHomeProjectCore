using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RealHomeProject.Business.Abstract;
using RealHomeProject.Entities.Concrete;

namespace RealHomeProject.WebUI.Controllers
{
	public class CommentController : Controller
	{
		private readonly IBlogCommentService _blogCommentService;
		private readonly UserManager<AppUser> _userManager;
		public CommentController(IBlogCommentService blogCommentService, UserManager<AppUser> userManager)
		{
			_blogCommentService = blogCommentService;
			_userManager = userManager;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public PartialViewResult CommentAdd()
		{
			return PartialView();
		}
		[HttpPost]
		public IActionResult CommentAdd(BlogComment blogComment)
		{
			if (ModelState.IsValid)
			{
				var result = _userManager.FindByNameAsync(User.Identity.Name);
				blogComment.AppUserId = result.Id;
				_blogCommentService.TAdd(blogComment);
				return RedirectToAction("Index", "Blog");
			}
			return View(blogComment);
		}
	}
}
