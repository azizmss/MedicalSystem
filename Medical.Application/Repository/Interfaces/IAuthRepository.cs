using Medical.Application.DTO.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Application.Repository.Interfaces;
public interface IAuthRepository
{
    Task<UserResponse> RegisterAsync(UserRegisterRequest requestDto);
    Task<UserResponse> LoginAsync(UserLoginRequest requestDto);
    Task<bool> updateUserRefreshToken(UserResponse user);
    Task<UserResponse> checkToken(string token);
    
}
