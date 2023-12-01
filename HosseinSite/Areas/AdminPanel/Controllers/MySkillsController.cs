using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interface;
using Resume.Domain.Models.Entities.MySkills;

namespace HosseinSite.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class MySkillsController : Controller
    {
        #region Ctor
        public MySkillsController(IMySkillsService mySkillsService)
        {
            MySkillsService = mySkillsService;
        }

        public IMySkillsService MySkillsService { get; }
        #endregion
        #region list of my skills
        public IActionResult ListOfMySkills()
        {
            var skills = MySkillsService.GetAllMySkills();
            return View(skills);
        }
        #endregion
        #region Create
        public IActionResult CreateMySkill()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateMySkill(MySkills myskill)
        {
            await MySkillsService.AddMySkillToTheDataBase(myskill);
            return RedirectToAction(nameof(ListOfMySkills));
        }
        #endregion
        #region Edit
        public async Task<IActionResult> EditMySkill(int myskillId)
        {
            var myskill = await MySkillsService.GetMySkillsById(myskillId);
            return View(myskill);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> EditMySkill(MySkills mySkill)
        {
            await MySkillsService.EditMySkill(mySkill);
            return RedirectToAction(nameof(ListOfMySkills));
        }
        #endregion
        public async Task<IActionResult> DeleteMySkill(int myskillId)
        {
            var myskill = await MySkillsService.GetMySkillsById(myskillId);
            return View(myskill);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteMySkill(MySkills mySkill)
        {
            await MySkillsService.DeleteMySkill(mySkill);
            return RedirectToAction(nameof(ListOfMySkills));
        }
    }
}
