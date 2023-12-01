using Resume.Application.DTOs.AdminSide.Education;
using Resume.Application.Services.Interface;
using Resume.Domain.Models.Entities.Education;
using Resume.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implement
{
    public class EducationService : IEducationService
	{
		#region Ctor
		public EducationService(IEducationRepository educationRepository)
		{
			EducationRepository = educationRepository;
		}

		public IEducationRepository EducationRepository { get; }

        
        #endregion


        public List<Education> GetAllEducations()
		{
			return EducationRepository.GetListOfEducations();
		}

		public List<ListOfEduactionsAdminSideDTO> GetListOfEduactionsForShowInAdminPanel()
		{
			var educations = EducationRepository.GetListOfEducations();
			List<ListOfEduactionsAdminSideDTO> returnModel = new();

			//Object Mapping
            foreach (var edu in educations)
            {
				
				ListOfEduactionsAdminSideDTO ChildModel = new()
				{
					EducationTitle = edu.EducationTitle,
					Duration = edu.EducationDuration,
					Id = edu.Id,
					Description = edu.Description
				};
				returnModel.Add(ChildModel);

			}
			return returnModel;
        }
        public async Task AddEducationToTheDataBase(CreateAnEducationAdminSideDTO model)
        {
			//Object Mapping
			Education edu = new();
			edu.EducationTitle = model.EducationTitle;
			edu.EducationDuration = model.Duration;
			edu.Description = model.Description;

			// add edu to the data base(repository)
			await EducationRepository.AddEducationToTheDataBase(edu);
			

        }

        public async Task<Education> GetAnEducation(int educationId)
        {
            var edu = await EducationRepository.GetEducationById(educationId);
			return edu;
        }

		public async Task EditAnEducation(Education education)
		{
			await EducationRepository.EditAnEducation(education);
		}

        public async Task DeleteAnEducation(Education education)
        {
			await EducationRepository.DeleteAnEducation(education);
        }
    }
}
