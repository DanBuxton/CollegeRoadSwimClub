using CollegeRoadSwimClub.Application.Common.Interfaces;
//using CollegeRoadSwimClub.Infrastructure.Files;
using CollegeRoadSwimClub.Infrastructure.Identity;
using CollegeRoadSwimClub.Infrastructure.Persistence;
using CollegeRoadSwimClub.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CollegeRoadSwimClub.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(configuration);

            return services;
        }
    }
}
