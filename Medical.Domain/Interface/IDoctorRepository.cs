using Medical.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Domain.Interface
{
    public interface IDoctorRepository : IRepository<Doctor>
    {
        // 5 CRUD
        // additional function 
        // search for active doctor
        Task<IEnumerable<Doctor>> searchForDoctor(string doctor);
    }
}
