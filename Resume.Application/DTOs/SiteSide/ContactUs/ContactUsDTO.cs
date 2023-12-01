using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.DTOs.SiteSide.ContactUs
{
	public class ContactUsDTO
	{
		public string FullName { get; set; }
		[Required]
		public string Mobile { get; set; }
		public string Message { get; set; }
		public string Address { get; set; }
	}
}
