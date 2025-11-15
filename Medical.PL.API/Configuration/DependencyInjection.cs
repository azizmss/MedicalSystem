using Medical.Infrastructure.Presistance.Data;
using Microsoft.EntityFrameworkCore;
namespace Medical.PL.API.Configuration;

public static class DependencyInjection
{
    public static IServiceCollection AddAPIService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDBContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
        return services;
    }
    public static WebApplication AddAPIWeb(this WebApplication app)
    {

        return app;
    }
}
