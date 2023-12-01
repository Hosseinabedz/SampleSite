

using Resume.Domain.Models.Entities.Education;

namespace Resume.Domain.RepositoryInterface
{
	public interface IEducationRepository
	{
		List<Education> GetListOfEducations();
		Task AddEducationToTheDataBase(Education education);
		Task<Education> GetEducationById(int educationId);
		Task EditAnEducation(Education education);
        Task DeleteAnEducation(Education education);
    }
}
