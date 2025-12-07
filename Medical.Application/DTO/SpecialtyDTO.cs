using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Domain.Entity;
public class SpecialtyDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int IsActive { get; set; }

}
