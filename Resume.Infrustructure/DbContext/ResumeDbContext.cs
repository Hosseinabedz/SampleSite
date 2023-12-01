using Resume.Domain.Models.Entities.Education;
using Resume.Domain.Models.Entities.Experience;
using Resume.Domain.Models.Entities.MySkills;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Resume.Domain.Entities.ContactUs;

namespace Resume.Infrustructure.Models.ResumeDbContext
{
	public class ResumeDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=HOSSEIN\\HOSSEINSQLSERVER;Initial Catalog=ResumeDaneshkar;Integrated Security=True;TrustServerCertificate=true;");
			base.OnConfiguring(optionsBuilder);
		}
		public DbSet<Experience> Experiences { get; set; }
		public DbSet<MySkills> MySkills { get; set; }
		public DbSet<Education> Educations { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<ContactUsLocation> Locations { get; set; }
    }

}
