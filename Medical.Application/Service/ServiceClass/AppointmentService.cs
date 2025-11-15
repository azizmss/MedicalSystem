using AutoMapper;
using Medical.Application.DTO;
using Medical.Application.Service.Interface;
using Medical.Domain.Entity;
using Medical.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Application.Service.ServiceClass;
public class AppointmentService : IAppointmentService
{
    private IMapper _mapper;
    private IAppointmentRepository _AppointmentRepo;
    public AppointmentService(IMapper mapper,IAppointmentRepository appointmentRepository)
    {
        _AppointmentRepo = appointmentRepository;
    }
    public async Task CreateAppointment(AppointmentDTO dto)
    {
        var mapAppointment = _mapper.Map<Appointment>(dto);
        await _AppointmentRepo.Create(mapAppointment);
    }
}
