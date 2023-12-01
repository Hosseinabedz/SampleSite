using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;
using Resume.Infrustructure.Models.ResumeDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Infrustructure.Repository
{
	public class ContactUsRepository : IContactUsRepository
	{
        public ContactUsRepository(ResumeDbContext context)
        {
			Context = context;
		}

		public ResumeDbContext Context { get; }

		public async Task AddContactUsToTheDataBase(ContactUs contactUs)
		{
			await Context.ContactUs.AddAsync(contactUs);
			await Context.SaveChangesAsync();
		}

		public async Task AddLocationToTheDataBase(ContactUsLocation location)
		{
			await Context.Locations.AddAsync(location);
			await Context.SaveChangesAsync();
		}
	}
}