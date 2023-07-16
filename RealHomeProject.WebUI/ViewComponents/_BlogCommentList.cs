using Microsoft.AspNetCore.Mvc;
using RealHomeProject.Business.Abstract;

namespace RealHomeProject.WebUI.ViewComponents
{
	public class _BlogCommentList:ViewComponent
	{
		private readonly IBlogCommentService _blogCommentService;

		public _BlogCommentList(IBlogCommentService blogCommentService)
		{
			_blogCommentService = blogCommentService;
		}

		public IViewComponentResult Invoke(int id)
		{
			var result = _blogCommentService.TGetAll(x=> x.BlogId == id);
			return View(result);	
		}
	}
}
