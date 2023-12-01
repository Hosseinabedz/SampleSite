using Resume.Domain.Entities.ContactUs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.RepositoryInterface
{
	public interface IContactUsRepository
	{
		Task AddContactUsToTheDataBase(ContactUs contactUs);
		Task AddLocationToTheDataBase(ContactUsLocation location);
	}
}
