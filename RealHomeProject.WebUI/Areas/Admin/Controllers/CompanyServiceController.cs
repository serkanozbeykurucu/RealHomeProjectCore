using Microsoft.AspNetCore.Mvc;
using RealHomeProject.Business.Abstract;
using RealHomeProject.Entities.Concrete;

namespace RealHomeProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class CompanyServiceController : Controller
    {
        private readonly ICompanyService _companyService;

        public CompanyServiceController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public IActionResult Index()
        {
            var result = _companyService.TGetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult CompanyServiceAdd()
        {
            return View();
        }

        [HttpPost]  
		public IActionResult CompanyServiceAdd(CompanyService companyService)
		{
            if (ModelState.IsValid)
            {
                companyService.Status = false;
				_companyService.TAdd(companyService);
				return RedirectToAction("Index");
			}
            return View(companyService);
		}

		[HttpGet]
		public IActionResult CompanyServiceUpdate(int id)
		{
            var companyService = _companyService.TGetByFilter(x => x.ID == id);
			return View(companyService);
		}

		[HttpPost]
		public IActionResult CompanyServiceUpdate(CompanyService companyService)
		{
			if (ModelState.IsValid)
			{
				_companyService.TUpdate(companyService);
				return RedirectToAction("Index");
			}
			return View(companyService);
		}

		public IActionResult CompanyServiceDelete(int id)
		{
			if (id !=null)
			{
				var deletedComoantServiceValues = _companyService.TGetByFilter(x => x.ID == id);
				_companyService.TDelete(deletedComoantServiceValues);
				return RedirectToAction("Index");
			}
			return RedirectToAction("Index");
		}
	}
}
