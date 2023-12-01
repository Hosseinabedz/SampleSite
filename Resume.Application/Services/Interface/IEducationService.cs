using Resume.Application.DTOs.AdminSide.Education;
using Resume.Domain.Models.Entities.Education;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interface
{
	public interface IEducationService
	{
		List<Education> GetAllEducations();

		// get list of educations for show in admin panel
		List<ListOfEduactionsAdminSideDTO> GetListOfEduactionsForShowInAdminPanel();

		//add education 
		Task AddEducationToTheDataBase(CreateAnEducationAdminSideDTO education);

		// get education
		Task<Education> GetAnEducation(int educationId);

		Task EditAnEducation(Education education);
        Task DeleteAnEducation(Education education);
    }
}
