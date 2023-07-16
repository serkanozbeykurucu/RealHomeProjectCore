using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RealHomeProject.WebUI.Email;
using RealHomeProject.WebUI.Models;

namespace RealHomeProject.WebUI.Controllers
{
    [AllowAnonymous]

    public class ContactController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(ContactViewModel contactViewModel)
		{
			if (ModelState.IsValid)
			{
				EmailHelper emailHelper = new EmailHelper();
				bool emailResponse = emailHelper.SendEmail(
					contactViewModel.Email,
					contactViewModel.Name,
					contactViewModel.Subject,
					contactViewModel.Message
					);
				if (emailResponse)
				{
					TempData["Message"] = "Mesajınız iletilmiştir. En kısa zamanda size geri dönüş sağlanacaktır.";
					return RedirectToAction("Index");
				}
			}
			ModelState.AddModelError("", "Lütfen ilgili alanları doldurunuz!");
			return View(contactViewModel);
		}
	}
}
