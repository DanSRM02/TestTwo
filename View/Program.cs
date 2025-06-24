using DataAccess;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using FluentValidation;
using Logic.Services;
using Logic.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using View.ViewModels;
using View.ViewModels.Validators;

namespace View
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            ConfigureServices(services);
    
            using(var serviceProvider = services.BuildServiceProvider())
            {                
                Application.Run(serviceProvider.GetRequiredService<Volunteers>());
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TestTwoContext>(opt => opt.UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString));

            services.AddScoped<IVolunteerRepository, VolunteerRepository>();

            services.AddScoped<IVolunteerService, VolunteerService>();

            services.AddTransient<IValidator<VolunteerViewModel>, VolunteerViewModelValidator>();

            services.AddTransient<VolunteerViewModel>();

            services.AddTransient<Volunteers>();

        }
    }
}