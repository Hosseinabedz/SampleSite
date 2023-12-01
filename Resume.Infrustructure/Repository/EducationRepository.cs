using Resume.Domain.Models.Entities.Education;
using Resume.Domain.RepositoryInterface;
using Resume.Infrustructure.Models.ResumeDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Infrustructure.Repository
{
    public class EducationRepository : IEducationRepository
	{
		#region Ctor
		private ResumeDbContext _context;
		public EducationRepository(ResumeDbContext context)
		{
			_context = context;
		}

        
        #endregion

        public List<Education> GetListOfEducations()
		{
			return _context.Educations.ToList();
		}
        public async Task AddEducationToTheDataBase(Education education)
        {
            await _context.Educations.AddAsync(education);
			await _context.SaveChangesAsync();
        }

        public async Task<Education> GetEducationById(int educationId)
        {
            return _context.Educations.FirstOrDefault(e => e.Id == educationId);
        }

        public async Task EditAnEducation(Education education)
        {
            _context.Educations.Update(education);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAnEducation(Education education)
        {
            _context.Educations.Remove(education);
            await _context.SaveChangesAsync();
        }
    }
}
