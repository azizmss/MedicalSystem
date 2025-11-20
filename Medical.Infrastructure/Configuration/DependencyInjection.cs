using Medical.Domain.Interface;
using Medical.Infrastructure.Presistance.Data;
using Medical.Infrastructure.Presistance.Models;
using Medical.Infrastructure.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Medical.Infrastructure.Presistance.Data;

namespace Medical.Infrastructure.Configuration;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        // Add application services here
        services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
        {
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequiredLength = 4;
            options.Password.RequiredUniqueChars = 0;
        })
        .AddEntityFrameworkStores<ApplicationDBContext>()
        .AddDefaultTokenProviders();

        services.AddScoped<IAppointmentRepository, AppointmentRepository>();

        return services;
    }
    public static WebApplication AddInfrastructureWeb(this WebApplication app) // Fix type name to WebApplication
    {
        return app;
    }
}
