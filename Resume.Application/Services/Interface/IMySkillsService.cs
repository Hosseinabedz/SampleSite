using Resume.Domain.Models.Entities.MySkills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interface
{
	public interface IMySkillsService
	{
		List<MySkills> GetAllMySkills();
		Task AddMySkillToTheDataBase(MySkills skill);
		Task<MySkills> GetMySkillsById(int myskillId);
		Task EditMySkill(MySkills skill);
        Task DeleteMySkill(MySkills skill);
    }
}
