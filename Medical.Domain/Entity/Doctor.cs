using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Domain.Entity
{
    public class Doctor 
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public decimal ConsultationFee { get; set; }
        public int SpecialtyId { get; set; }

    }
}
