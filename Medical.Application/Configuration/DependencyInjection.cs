using Medical.Application.Service.Interface;
using Medical.Application.Service.ServiceClass;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Medical.Application.AutoMapper;
namespace Medical.Application.Configuration;
public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Add application services here
        services.AddScoped<IDoctorService, DocterService>();
        services.AddScoped<IAppointmentService, AppointmentService>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<ITokenService, TokenService>();
        services.AddAutoMapper(typeof(AppointmentProfile).Assembly);
        return services;
    }
    public static WebApplication AddApplicationWeb(this WebApplication app) // Fix type name to WebApplication
    {
        return app;
    }
}
