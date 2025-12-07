using AutoMapper;
using Medical.Application.Service.Interface;
using Medical.Domain.Entity;
using Medical.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Application.Service.ServiceClass
{
    public class DocterService : IDoctorService
    {
        //public IDoctorRepository _doctorRepo;
        public IUnitOfWork _unitofwork;
        public IMapper _mapper;

        public DocterService(
            //IDoctorRepository doctorRepo, 
            IMapper mapper,
            IUnitOfWork unitofwork
            )
        {
            //_doctorRepo = doctorRepo;
            _mapper = mapper;
            _unitofwork = unitofwork;
        }
        public async Task createDoctor(DoctorDTO dto)
        {
            var mappedDoctor = _mapper.Map<Doctor>(dto);
            //await _doctorRepo.AddAsync(mappedDoctor); // real entity
            await _unitofwork.Repository<Doctor>().AddAsync(mappedDoctor);
            await _unitofwork.Repository<Doctor>().GetAllAsync();
            await _unitofwork._doctorRepository.searchForDoctor("");
        }

        public async Task<IEnumerable<Doctor>> search()
        {
            return await _unitofwork._doctorRepository.searchForDoctor("");
            //return await _doctorRepo.searchForDoctor("Ahmed");
        }
    }
}
