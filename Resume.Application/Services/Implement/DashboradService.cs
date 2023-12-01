
using Resume.Application.DTOs.SiteSide.Home_Index;
using Resume.Application.Services.Interface;
using Resume.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implement
{
	public class DashboradService : IDashboardService
	{
        #region Ctor
        public DashboradService(IEducationService educationService,
								IExperienceService experienceService,
								IMySkillsService mySkillsService)
        {
			EducationService = educationService;
			ExperienceService = experienceService;
			MySkillsService = mySkillsService;
		}

		public IEducationService EducationService { get; }
		public IExperienceService ExperienceService { get; }
		public IMySkillsService MySkillsService { get; }


		#endregion
		public async Task<HomeIndexModelDTO> FillDashboardModel()
		{
			var Education = EducationService.GetAllEducations();
			var Experience = ExperienceService.GetAllExperiences();
			var MySkills = MySkillsService.GetAllMySkills();

			HomeIndexModelDTO model = new HomeIndexModelDTO()
			{
				Educations = Education,
				Experiences = Experience,
				Skills = MySkills
			};
			return model;
		}
	}
}
