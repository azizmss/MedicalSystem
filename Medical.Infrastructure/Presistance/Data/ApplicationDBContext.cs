using Medical.Domain.Entity;
using Medical.Infrastructure.Presistance.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Infrastructure.Presistance.Data;
public class ApplicationDBContext: IdentityDbContext<ApplicationUser, ApplicationRole, string>
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
        
    }

    public DbSet<Appointment> Appointments { get; set; }
}
