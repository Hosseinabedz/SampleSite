
using Resume.Domain.Models.Entities.Education;
using Resume.Domain.Models.Entities.Experience;
using Resume.Domain.Models.Entities.MySkills;

namespace Resume.Application.DTOs.SiteSide.Home_Index
{
	public class HomeIndexModelDTO
	{
        public List<Education> Educations { get; set; }
		public List<Experience> Experiences { get; set; }
		public List<MySkills> Skills { get; set; }
	}
}
