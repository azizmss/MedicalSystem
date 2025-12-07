using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Application.DTO;
public class AppointmentDTO
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public int TimeSlotId { get; set; }
    public int LocationId { get; set; }
    public DateTime CreatedAt { get; set; }
    public int Status { get; set; }
}
