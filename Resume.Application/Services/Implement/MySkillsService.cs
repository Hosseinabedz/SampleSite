using Resume.Application.Services.Interface;
using Resume.Domain.Models.Entities.MySkills;
using Resume.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implement
{
	public class MySkillsService : IMySkillsService
	{
		public MySkillsService(IMySkillsRepository mySkillsRepository)
		{
			MySkillsRepository = mySkillsRepository;
		}

		public IMySkillsRepository MySkillsRepository { get; }

        public async Task AddMySkillToTheDataBase(MySkills skill)
        {
            await MySkillsRepository.AddMySkillToTheDataBase(skill);
        }

        public async Task DeleteMySkill(MySkills skill)
        {
            await MySkillsRepository.DeleteMySkill(skill);
        }

        public async Task EditMySkill(MySkills skill)
        {
            await MySkillsRepository.EditMySkill(skill);
        }

        public List<MySkills> GetAllMySkills()
		{
			return MySkillsRepository.GetListOfMySkills();
		}

        public async Task<MySkills> GetMySkillsById(int myskillId)
        {
            var myskill = await MySkillsRepository.GetMySkillById(myskillId);
            return myskill;
        }
    }
}
