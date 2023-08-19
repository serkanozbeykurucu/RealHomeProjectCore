using Microsoft.AspNetCore.Mvc;
using RealHomeProject.Business.Abstract;
using RealHomeProject.Entities.Concrete;

namespace RealHomeProject.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class DealerController : Controller
	{
		private readonly IDealerService _dealerService;

        public DealerController(IDealerService dealerService)
        {
            _dealerService = dealerService;
        }

        public IActionResult Index()
		{
			var dealerList = _dealerService.TGetAll();
			return View(dealerList);
		}

        [HttpGet]
        public IActionResult DealerAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DealerAdd(Dealer dealer)
        {
            if (ModelState.IsValid)
            {
                dealer.Status = false;
                _dealerService.TAdd(dealer);
                return RedirectToAction("Index");
            }
            return View(dealer);
        }
        
        [HttpGet]
        public IActionResult DealerUpdate(int id)
        {
            var dealerUpdateData = _dealerService.TGetByFilter(x=> x.Id == id);
            return View(dealerUpdateData);
        }
        [HttpPost]
        public IActionResult DealerUpdate(Dealer dealer)
        {
            if (ModelState.IsValid)
            {
                _dealerService.TUpdate(dealer);
                return RedirectToAction("Index");
            }
            return View(dealer);
        }

		public IActionResult DealerDelete(int id)
		{
            
			if (id != null)
			{
                var dealerDeleteValue = _dealerService.TGetByFilter(x => x.Id == id);
				_dealerService.TDelete(dealerDeleteValue);
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
