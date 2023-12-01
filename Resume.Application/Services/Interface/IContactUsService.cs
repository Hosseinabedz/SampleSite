using Resume.Application.DTOs.SiteSide.ContactUs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interface
{
	public interface IContactUsService
	{
		Task AddNewContactUs(ContactUsDTO contactUs);
	}
}
