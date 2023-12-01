using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTOs.SiteSide.ContactUs;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;

namespace HosseinSite.Controllers
{
	public class ContactUsController : Controller
	{
		#region Ctor
		public ContactUsController(IContactUsService contactUsService)
		{
			ContactUsService = contactUsService;
		}

		public IContactUsService ContactUsService { get; }
		#endregion

		public IActionResult ContactUs()
		{
			return View();
		}
		[HttpPost, ValidateAntiForgeryToken]
		public async Task<IActionResult> ContactUs(ContactUsDTO contactUsDTO)
		{
			if (ModelState.IsValid)
			{
				await ContactUsService.AddNewContactUs(contactUsDTO);
				return RedirectToAction("Index", "Home");
			}
			
			return View();
		}
	}
}
