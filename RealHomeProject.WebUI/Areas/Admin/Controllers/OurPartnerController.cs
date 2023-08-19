using Microsoft.AspNetCore.Mvc;
using RealHomeProject.Business.Abstract;
using RealHomeProject.Entities.Concrete;

namespace RealHomeProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class OurPartnerController : Controller
    {
        private readonly IOurPartnerService _ourPartnerService;

        public OurPartnerController(IOurPartnerService ourPartnerService)
        {
            _ourPartnerService = ourPartnerService;
        }

        public IActionResult Index()
        {
            var ourPartnerList = _ourPartnerService.TGetAll();
            return View(ourPartnerList);
        }
        [HttpGet]
        public IActionResult OurPartnerAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OurPartnerAdd(OurPartner ourPartner)
        {
            if (ModelState.IsValid)
            {
                ourPartner.Status = false;
                _ourPartnerService.TAdd(ourPartner);
                return RedirectToAction("Index");
            }
            return View(ourPartner);
        }
        [HttpGet]
        public IActionResult OurPartnerUpdate(int id)
        {
            var ourPartnerUpdateValue = _ourPartnerService.TGetByFilter(x => x.ID == id);
            return View(ourPartnerUpdateValue);
        }

        [HttpPost]
        public IActionResult OurPartnerUpdate(OurPartner ourPartner)
        {
            if (ModelState.IsValid)
            {
                _ourPartnerService.TUpdate(ourPartner);
                return RedirectToAction("Index");
            }
            return View(ourPartner);
        }

		public IActionResult OurPartnerDelete(int id)
		{

			if (id != null)
			{
				var dealerDeleteValue = _ourPartnerService.TGetByFilter(x => x.ID == id);
				_ourPartnerService.TDelete(dealerDeleteValue);
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
