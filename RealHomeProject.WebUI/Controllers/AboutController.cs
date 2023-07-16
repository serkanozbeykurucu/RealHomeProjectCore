using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealHomeProject.Business.Abstract;

namespace RealHomeProject.WebUI.Controllers
{
    [AllowAnonymous]

    public class AboutController : Controller
    {
        private readonly IAboutUsService _aboutUsService;

        public AboutController(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }

        public IActionResult Index()
        {
            var result = _aboutUsService.TGetByFilter(x => x.Status == true);
            if (result != null)
            {
                return View(result);
            }
            return View();

        }
    }
}
