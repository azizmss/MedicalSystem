using Medical.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Domain.Interface;
public interface IAppointmentRepository:IRepository<Appointment>
{
    //Task Create(Appointment entity);

    Task CustomFuncton();
}

