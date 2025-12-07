using Medical.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Application.Service.Interface
{
    //public class DoctorDTO
    //{
    //    public string Name { get; set; }
    //}
    public interface IDoctorService 
    {
        Task<IEnumerable<Doctor>> search();
        Task createDoctor(DoctorDTO dto );
    }
}
