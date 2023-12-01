using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities.Experience;
using Resume.Domain.RepositoryInterface;
using Resume.Infrustructure.Models.ResumeDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Infrustructure.Repository
{
    public class ExperienceRepository : IExperienceRepository
	{
		#region Ctor
		private ResumeDbContext _context;
		public ExperienceRepository(ResumeDbContext context)
		{
			_context = context;
		}

        
        #endregion

        public List<Experience> GetListOfExperiences()
		{
			return _context.Experiences.ToList();
		}

        public async Task AddExperienceToTheDataBase(Experience experience)
        {
            await _context.Experiences.AddAsync(experience);
			await _context.SaveChangesAsync();
        }

        public async Task<Experience> GetExperienceById(int experienceId)
        {
            var edu = await _context.Experiences.FirstOrDefaultAsync(x => x.Id == experienceId);
            return edu;
        }

        public async Task EditAnExperience(Experience experience)
        {
            _context.Experiences.Update(experience);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAnExperience(Experience experience)
        {
            _context.Experiences.Remove(experience);
            await _context.SaveChangesAsync();
        }
    }
}
