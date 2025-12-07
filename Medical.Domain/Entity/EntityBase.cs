using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Domain.Entity;
public class EntityBase
{
    public int IsActive { get; set; }
    public int IsDeleted { get; set; }
}
