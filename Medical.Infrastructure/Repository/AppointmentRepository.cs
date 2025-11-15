using Medical.Domain.Entity;
using Medical.Domain.Interface;
using Medical.Infrastructure.Presistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Infrastructure.Repository;
public class AppointmentRepository : IAppointmentRepository
{
    private ApplicationDBContext _context;
    public AppointmentRepository(ApplicationDBContext context)
    {
        _context = context;
    }
    public async Task Create(Appointment entity)
    {
         await _context.Appointments.AddAsync(entity);
         await _context.SaveChangesAsync();
    }
}
