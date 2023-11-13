using DevelopmentChallenge.Repository.Interfaces;
using DevelopmentChallenge.Repository.Services;
using DevelpmentChallenge.Application.Shapes;

namespace DevelpmentChallenge.API.Configuration
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IReporteFigurasService, ReporteFigurasService>();
            services.AddScoped<IShapeRepository, ShapeRepository>();
            services.AddScoped<IReporting, Reporting>();

            return services;
        }
    }
}
