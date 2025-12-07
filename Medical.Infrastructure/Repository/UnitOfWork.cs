using Medical.Domain.Interface;
using Medical.Infrastructure.Presistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ApplicationDBContext _context;
        public IDoctorRepository _doctorRepository { get; }

        public IAppointmentRepository _appointmentRepository { get; }

        public UnitOfWork(ApplicationDBContext context, IDoctorRepository doctorRepository, IAppointmentRepository appointmentRepository)
        {
            _context = context;
            _doctorRepository = doctorRepository;
            _appointmentRepository = appointmentRepository;
           

        }



        public IRepository<T> Repository<T>() where T : class
        {

            return new Repository<T>(_context);
        }
    }
}
