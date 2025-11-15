using Medical.Domain.Interface;
using Medical.Infrastructure.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
namespace Medical.Infrastructure.Configuration;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        // Add application services here
        services.AddScoped<IAppointmentRepository, AppointmentRepository>();

        return services;
    }
    public static WebApplication AddInfrastructureWeb(this WebApplication app) // Fix type name to WebApplication
    {
        return app;
    }
}
