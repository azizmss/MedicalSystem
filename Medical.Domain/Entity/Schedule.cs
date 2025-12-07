using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Domain.Entity;
public class Schedule : EntityBase
{
    [Key]
    public int Id { get; set; }
    public int DoctorId { get; set; }
    public string Title { get; set; }
    public int LocationId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
