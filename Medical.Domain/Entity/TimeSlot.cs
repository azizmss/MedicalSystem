using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Domain.Entity;
public class TimeSlot: EntityBase
{
    [Key]
    public int Id { get; set; }
    public int SchduleId { get; set; }
    public string Day { get; set; }
    public DateTime Time { get; set; }
    public string Duration  { get; set; }
}
