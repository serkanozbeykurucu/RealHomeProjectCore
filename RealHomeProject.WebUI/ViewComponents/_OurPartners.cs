using Microsoft.AspNetCore.Mvc;
using RealHomeProject.Business.Abstract;

namespace RealHomeProject.WebUI.ViewComponents
{
	public class _OurPartners: ViewComponent
	{
		private readonly IOurPartnerService _partnerService;
		public _OurPartners(IOurPartnerService partnerService)
		{
			_partnerService = partnerService;
		}
		public IViewComponentResult Invoke()
		{
			var result = _partnerService.TGetAll();
			return View(result);
		}
	}
}
