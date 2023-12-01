using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interface;
using Resume.Domain.Models.Entities.Experience;

namespace HosseinSite.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ExperienceController : Controller
    {
        #region Ctor
        public ExperienceController(IExperienceService experienceService)
        {
            ExperienceService = experienceService;
        }

        public IExperienceService ExperienceService { get; }
        #endregion
        #region List of experiences
        public IActionResult ListOfExperiences()
        {
            var experiences =  ExperienceService.GetAllExperiences();
            return View(experiences);
        }
        #endregion
        #region Create
        public IActionResult CreateAnExperience()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAnExperience(Experience experience)
        {
            if (ModelState.IsValid)
            {
                await ExperienceService.AddExperienceToTheDataBase(experience);
                return RedirectToAction(nameof(ListOfExperiences));
            }
            
            return View();
        }
        #endregion
        #region Edit
        public async Task<IActionResult> EditAnExperience(int experienceId)
        {
            var exp = await ExperienceService.GetExperienceById(experienceId);
            return View(exp);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAnExperience(Experience experience)
        {
            await ExperienceService.EditAnExperience(experience);
            return RedirectToAction(nameof(ListOfExperiences));
        }
        #endregion
        #region Delete
        public async Task<IActionResult> DeleteAnExperience(int experienceId)
        {
            var exp = await ExperienceService.GetExperienceById(experienceId);
            return View(exp);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAnExperience(Experience experience)
        {
            await ExperienceService.DeleteAnExperience(experience);
            return RedirectToAction(nameof(ListOfExperiences));
        }
        #endregion
    }
}
