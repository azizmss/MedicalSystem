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
    public IMapper _mapper;
    public IAppointmentRepository _appoinmnetRepo;
    public IRepository<Appointment> _appointmentRepo;
    public IUnitOfWork _unitofwork;
    public AppointmentService(
        IMapper mapper,
        IAppointmentRepository appoinmnetRepo,
        IRepository<Appointment> appointmentRepo,
        IUnitOfWork unitofwork)
    {
        _mapper = mapper;
        _appoinmnetRepo = appoinmnetRepo;
        _appointmentRepo = appointmentRepo;
        _unitofwork = unitofwork;
    }
    public async Task createAppointment(AppointmentDTO dto)
    {       
        var mapAppointment = _mapper.Map<Appointment>(dto);

        await _unitofwork.Repository<Appointment>().AddAsync(mapAppointment);

        await _unitofwork._appointmentRepository.CustomFuncton();

        //await _appointmentRepo.AddAsync(mapAppointment);
        //await _appoinmnetRepo.create(mapAppointment);
    }
}

