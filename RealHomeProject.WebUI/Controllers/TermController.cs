using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealHomeProject.Business.Abstract;

namespace RealHomeProject.WebUI.Controllers
{
    [AllowAnonymous]

    public class TermController : Controller
    {
        private readonly ITermAndConditionService _termAndConditionService;

        public TermController(ITermAndConditionService termAndConditionService)
        {
            _termAndConditionService = termAndConditionService;
        }

        public IActionResult Index()
        {
            var result = _termAndConditionService.TGetByFilter(x => x.ID == 1);
            if (result == null)
            {
                return View(result);
            }
            return View(result);
        }
    }
}
