using Medical.Domain.Entity;
using Medical.Domain.Interface;
using Medical.Infrastructure.Presistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Infrastructure.Repository
{
    public class DoctorRepository : Repository<Doctor> , IDoctorRepository
    {
        public DoctorRepository(ApplicationDBContext context): base(context) { }

        public Task<IEnumerable<Doctor>> searchForDoctor(string doctor)
        {
            throw new NotImplementedException();
        }
    }
}
