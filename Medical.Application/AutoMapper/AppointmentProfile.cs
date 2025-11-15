using AutoMapper;
using Medical.Application.DTO;
using Medical.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Application.AutoMapper;
public class AppointmentProfile: Profile
{
    public AppointmentProfile()
    {
            CreateMap<Appointment, AppointmentDTO>().ReverseMap();
    }
}
