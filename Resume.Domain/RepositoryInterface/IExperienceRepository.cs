using Resume.Domain.Models.Entities.Experience;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.RepositoryInterface
{
	public interface IExperienceRepository
	{
		List<Experience> GetListOfExperiences();
		Task AddExperienceToTheDataBase(Experience experience);
		Task<Experience> GetExperienceById(int experienceId);
		Task EditAnExperience(Experience experience);
        Task DeleteAnExperience(Experience experience);
    }
}
