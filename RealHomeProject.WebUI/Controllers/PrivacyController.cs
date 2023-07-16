using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealHomeProject.Business.Abstract;

namespace RealHomeProject.WebUI.Controllers
{
    [AllowAnonymous]

    public class PrivacyController : Controller
    {
        private readonly IPrivacyPolicyService _privacyPolicyService;

        public PrivacyController(IPrivacyPolicyService privacyPolicyService)
        {
            _privacyPolicyService = privacyPolicyService;
        }

        public IActionResult Index()
        {
            var result = _privacyPolicyService.TGetByFilter(x=> x.Status == true);
            return View(result);
        }
    }
}
