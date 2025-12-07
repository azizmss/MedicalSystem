using Medical.Domain.Entity;
using Medical.Domain.Interface;
using Medical.Infrastructure.Presistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Infrastructure.Repository;
public class AppointmentRepository : Repository<Appointment>, IAppointmentRepository
{
    private ApplicationDBContext _context;
    public AppointmentRepository(ApplicationDBContext context) : base(context) { }

    public Task CustomFuncton()
    {
        throw new NotImplementedException();
    }
}
