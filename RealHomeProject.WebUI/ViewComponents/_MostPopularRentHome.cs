using Microsoft.AspNetCore.Mvc;
using RealHomeProject.Business.Abstract;

namespace RealHomeProject.WebUI.ViewComponents
{
    public class _MostPopularRentHome: ViewComponent
    {
        private readonly IPopularRentHomeService _popularRentHomeService;

        public _MostPopularRentHome(IPopularRentHomeService popularRentHomeService)
        {
            _popularRentHomeService = popularRentHomeService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _popularRentHomeService.TGetAll();
            return View(result);
        }
    }
}
