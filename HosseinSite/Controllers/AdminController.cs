using Microsoft.AspNetCore.Mvc;

namespace HosseinSite.Controllers
{
	public class AdminController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

        [HttpPost]
        public IActionResult Index(string email)
        {
            return View();
        }
    }
}