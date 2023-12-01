using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTOs.AdminSide.Education;
using Resume.Application.Services.Interface;
using Resume.Domain.Models.Entities.Education;

namespace HosseinSite.Areas.AdminPanel.Controllers;


[Area("AdminPanel")]
public class EducationController : Controller
{
	#region Ctor
	public EducationController(IEducationService educationService)
	{
		EducationService = educationService;
	}

	public IEducationService EducationService { get; }
	#endregion

	#region List Of Educations
	public IActionResult ListOfEducations()
	{

		var model = EducationService.GetListOfEduactionsForShowInAdminPanel();
		return View(model);
	}
	#endregion

	#region Create
	public IActionResult CreateAnEducation()
	{
		return View();
	}

	[HttpPost, ValidateAntiForgeryToken]
	public async Task<IActionResult> CreateAnEducation(CreateAnEducationAdminSideDTO model)
	{
		if (ModelState.IsValid)
		{
			await EducationService.AddEducationToTheDataBase(model);
			return RedirectToAction(nameof(ListOfEducations));
		}
		return View();
	}
	#endregion

	#region Edit
	public async Task<IActionResult> EditAnEducation(int educationId)
	{
		// get an education by id
		var edu = await EducationService.GetAnEducation(educationId);
		return View(edu);
	}
	[HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> EditAnEducation(Education education)
    {
		await EducationService.EditAnEducation(education);
		return RedirectToAction(nameof(ListOfEducations));
    }
    #endregion

    #region Delete
	public async Task<IActionResult> DeleteAnEducation(int educationId)
	{
        var edu = await EducationService.GetAnEducation(educationId);
        return View(edu);
    }
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteAnEducation(Education education)
    {
        await EducationService.DeleteAnEducation(education);
        return RedirectToAction(nameof(ListOfEducations));
    }
    #endregion

}
