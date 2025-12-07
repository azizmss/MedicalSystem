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
    public DbSet<City> Cities { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<TimeSlot> TimeSlots { get; set; }
}
