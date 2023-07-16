using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealHomeProject.Business.Abstract;

namespace RealHomeProject.WebUI.Controllers
{
    [AllowAnonymous]

    public class DealerController : Controller
	{
		private readonly IDealerService _dealerService;

		public DealerController(IDealerService dealerService)
		{
			_dealerService = dealerService;
		}

		public IActionResult Index()
		{
			var result = _dealerService.TGetAll();
			return View(result);
		}
	}
}
