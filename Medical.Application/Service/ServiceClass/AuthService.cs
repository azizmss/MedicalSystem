using Medical.Application.DTO.Auth;
using Medical.Application.Repository.Interfaces;
using Medical.Application.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Application.Service.ServiceClass;
public class AuthService : IAuthService
{
    private readonly IAuthRepository _authRepository;
    private readonly ITokenService _tokenService;
    public AuthService(IAuthRepository authRepository, ITokenService tokenService)
    {
        _authRepository = authRepository;
        _tokenService = tokenService;
    }
    public async Task<UserResponse> LoginAsync(UserLoginRequest request)
    {
        var user = await _authRepository.LoginAsync(request);
        if (user == null)
        {
            return new UserResponse();
        }
        var token =  _tokenService.GenerateToken(user);
        user.AccessToken =await token;
        
        return user;
    }

    public async Task<UserResponse> RegisterAsync(UserRegisterRequest request)
    {
        var user = await _authRepository.RegisterAsync(request);
        if (user == null)
        {
            return new UserResponse();
        }
        var token =  _tokenService.GenerateToken(user);

        user.AccessToken = await token;
        
        return user;
    }
}
