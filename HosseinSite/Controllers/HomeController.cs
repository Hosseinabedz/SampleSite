using Resume.Infrustructure.Models.ResumeDbContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Application.DTOs.SiteSide.Home_Index;
using Resume.Domain.RepositoryInterface;
using Resume.Application.Services.Interface;

namespace HosseinSite.Controllers
{
	public class HomeController : Controller
    {
        #region Ctor
        public HomeController(IDashboardService dashboardService)
        {
			DashboardService = dashboardService;
		}

		public IDashboardService DashboardService { get; }
		#endregion
		public async Task<IActionResult> Index()
        {
            var model = await DashboardService.FillDashboardModel();
			return View(model);
             
        }
    }
}