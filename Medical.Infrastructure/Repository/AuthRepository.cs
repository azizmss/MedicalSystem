using AutoMapper;
using Medical.Application.DTO.Auth;
using Medical.Application.Repository.Interfaces;
using Medical.Infrastructure.Presistance.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Infrastructure.Repository;
public class AuthRepository : IAuthRepository
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IMapper _mapper;

    public AuthRepository(IMapper mapper, UserManager<ApplicationUser> userManager)
    {
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task<UserResponse> LoginAsync(UserLoginRequest requestDto)
    {
        var user = await _userManager.FindByEmailAsync(requestDto.Email);
        if (user == null)
            return new UserResponse();

        var check = await _userManager.CheckPasswordAsync(user, requestDto.Password);
        if (check == false) return new UserResponse();

        var response = _mapper.Map<UserResponse>(user);
        return response;
    }

    public async Task<UserResponse> RegisterAsync(UserRegisterRequest requestDto)
    {
        var userMapped = _mapper.Map<ApplicationUser>(requestDto);

        var result = await _userManager.CreateAsync(userMapped, requestDto.PasswordHash);
        var result2= await _userManager.AddToRoleAsync(userMapped, requestDto.Role);

        var response = _mapper.Map<UserResponse>(userMapped);


        return response;

    }
}
