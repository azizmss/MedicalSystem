using Medical.Application.DTO.Auth;
using Medical.Application.Repository.Interfaces;
using Medical.Domain.Interface;
using Medical.Infrastructure.AutoMapper;
using Medical.Infrastructure.Presistance.Data;
using Medical.Infrastructure.Presistance.Data;
using Medical.Infrastructure.Presistance.Models;
using Medical.Infrastructure.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Security;

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
        services.AddScoped<IAuthRepository, AuthRepository>();
        services.AddScoped<IPermissionRepository, PermissionRepository>();
        services.AddAutoMapper(typeof(RegisterProfile));
        return services;
    }
    public static WebApplication AddInfrastructureWeb(this WebApplication app) // Fix type name to WebApplication
    {
        return app;
    }
}
