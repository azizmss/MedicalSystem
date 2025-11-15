using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Infrastructure.Presistance.Data;
public class DBContextApplicationFactory:IDesignTimeDbContextFactory<ApplicationDBContext>  
{
    public ApplicationDBContext CreateDbContext(string[] args)
    {
        var basepath = Path.Combine(Directory.GetCurrentDirectory());//,"../Medical.API");
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(basepath)
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString= configuration.GetConnectionString("DefaultConnection");

        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDBContext>();
        optionsBuilder.UseSqlServer(connectionString);
        return new ApplicationDBContext(optionsBuilder.Options);
    }
}
