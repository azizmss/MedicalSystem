using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Domain.Interface
{
    public interface IUnitOfWork
    {
        IDoctorRepository _doctorRepository { get; }
        IAppointmentRepository _appointmentRepository { get; }

        IRepository<T> Repository<T>() where T : class;
    }
}
