using Resume.Application.DTOs.SiteSide.ContactUs;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implement
{
	public class ContactUsService : IContactUsService
	{
		#region Ctor
		public ContactUsService(IContactUsRepository contactUsRepository)
		{
			ContactUsRepository = contactUsRepository;
		}

		public IContactUsRepository ContactUsRepository { get; }


		#endregion
		public async Task AddNewContactUs(ContactUsDTO contactUsDTO)
		{
			ContactUs contactUs = new()
			{
				FullName = contactUsDTO.FullName,
				Mobile = contactUsDTO.Mobile,
				Message = contactUsDTO.Message
			};
			ContactUsLocation location = new()
			{
				Address = contactUsDTO.Address
			};
			await ContactUsRepository.AddContactUsToTheDataBase(contactUs);
			await ContactUsRepository.AddLocationToTheDataBase(location);
		}

	}
}
