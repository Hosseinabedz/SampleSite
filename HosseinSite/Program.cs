using Resume.Application.Services.Implement;
using Resume.Application.Services.Interface;
using Resume.Domain.RepositoryInterface;
using Resume.Infrustructure.Models.ResumeDbContext;
using Resume.Infrustructure.Repository;

namespace HosseinSite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ResumeDbContext>();
			#region Repositories
			builder.Services.AddScoped<IEducationRepository, EducationRepository>();
			builder.Services.AddScoped<IExperienceRepository, ExperienceRepository>();
			builder.Services.AddScoped<IMySkillsRepository, MySkillsRepository>();
			builder.Services.AddScoped<IContactUsRepository, ContactUsRepository>();
            #endregion
            #region Services
            builder.Services.AddScoped<IContactUsService, ContactUsService>();
            builder.Services.AddScoped<IDashboardService, DashboradService>();
            builder.Services.AddScoped<IEducationService, EducationService>();
			builder.Services.AddScoped<IExperienceService, ExperienceService>();
			builder.Services.AddScoped<IMySkillsService, MySkillsService>();
			#endregion


			var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

			app.MapControllerRoute(
				name: "area",
				pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

			app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}