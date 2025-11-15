using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Domain.Entity;
public class Appointment
{
    public int Id { get; set; }
    public DateTime DateAt { get; set; }   
    public int Status { get; set; }
}
