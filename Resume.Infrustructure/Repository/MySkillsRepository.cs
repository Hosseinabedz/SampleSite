using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities.MySkills;
using Resume.Domain.RepositoryInterface;
using Resume.Infrustructure.Models.ResumeDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Infrustructure.Repository
{
	public class MySkillsRepository : IMySkillsRepository
	{
		#region Ctor
		private ResumeDbContext _context;
		public MySkillsRepository(ResumeDbContext context)
		{
			_context = context;
		}

        #endregion

        public List<MySkills> GetListOfMySkills()
		{
			return _context.MySkills.ToList();
		}
        public async Task AddMySkillToTheDataBase(MySkills mySkills)
        {
			await _context.MySkills.AddAsync(mySkills);
			await _context.SaveChangesAsync();
        }

        public async Task<MySkills> GetMySkillById(int myskillId)
        {
            var model = await _context.MySkills.FirstOrDefaultAsync(e => e.Id == myskillId);
			return model;
        }

        public  async Task EditMySkill(MySkills mySkills)
        {
            _context.MySkills.Update(mySkills);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteMySkill(MySkills mySkills)
        {
            _context.MySkills.Remove(mySkills);
            await _context.SaveChangesAsync();
        }
    }
}
