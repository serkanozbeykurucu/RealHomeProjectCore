using Microsoft.AspNetCore.Mvc;

namespace RealHomeProject.WebUI.ViewComponents
{
	public class _BlogCommentList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();	
		}
	}
}
