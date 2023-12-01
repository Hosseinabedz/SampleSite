using Resume.Application.Services.Interface;
using Resume.Domain.Models.Entities.Experience;
using Resume.Domain.RepositoryInterface;
using Resume.Infrustructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implement
{
    public class ExperienceService : IExperienceService
    {
        #region Ctor
        public ExperienceService(IExperienceRepository experienceRepository)
        {
        ExperienceRepository = experienceRepository;
        }
    #endregion
        public IExperienceRepository ExperienceRepository { get; }

        public async Task AddExperienceToTheDataBase(Experience experience)
        {
            await ExperienceRepository.AddExperienceToTheDataBase(experience);
            
        }

        public async Task DeleteAnExperience(Experience experience)
        {
            await ExperienceRepository.DeleteAnExperience(experience);
        }

        public async Task EditAnExperience(Experience experience)
        {
            await ExperienceRepository.EditAnExperience(experience);
        }

        public List<Experience> GetAllExperiences()
        {
            return ExperienceRepository.GetListOfExperiences();
        }

        public async Task<Experience> GetExperienceById(int experienceId)
        {
            var exp = await ExperienceRepository.GetExperienceById(experienceId);
            return exp;
        }
    }
    
    
	
}
