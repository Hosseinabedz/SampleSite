using Resume.Domain.Models.Entities.Experience;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interface
{
	public interface IExperienceService
	{
		List<Experience> GetAllExperiences();
		Task AddExperienceToTheDataBase(Experience experience);
		Task<Experience> GetExperienceById(int id);
		Task EditAnExperience(Experience experience);
        Task DeleteAnExperience(Experience experience);
    }
}
