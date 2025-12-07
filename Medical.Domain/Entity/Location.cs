using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Domain.Entity;
public class Location : EntityBase
{
    [Key]
    public int Id { get; set; }
    public int DoctorId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string URL { get; set; }
    public int CityId { get; set; }
    public string ApartmentNo { get; set; }
    public string BuildingNo { get; set; }
    public string Street { get; set; }
    public string Phone { get; set; }

}
