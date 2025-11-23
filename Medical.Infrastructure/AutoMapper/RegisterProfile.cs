using AutoMapper;
using Medical.Application.DTO.Auth;
using Medical.Infrastructure.Presistance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Infrastructure.AutoMapper;
public class RegisterProfile:Profile
{
    public RegisterProfile()
    {
        CreateMap<ApplicationUser, UserRegisterRequest>().ReverseMap();
        CreateMap<ApplicationUser, UserResponse>().ReverseMap();
    }

}
