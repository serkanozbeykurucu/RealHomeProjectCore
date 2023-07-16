using Microsoft.AspNetCore.Mvc;
using RealHomeProject.Business.Abstract;

namespace RealHomeProject.WebUI.ViewComponents
{
    public class _WhyChooseUs: ViewComponent
    {
        private readonly IWhyChooseUsService _whyChooseUsService;

        public _WhyChooseUs(IWhyChooseUsService whyChooseUsService)
        {
            _whyChooseUsService = whyChooseUsService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _whyChooseUsService.TGetAll(x=> x.Status == true);
            return View(result);
        }
    }
}
