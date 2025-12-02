using Medical.Application.DTO.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Application.Service.Interface;
public interface IAuthService
{
    Task<UserResponse> RegisterAsync(UserRegisterRequest request);
    Task<UserResponse> LoginAsync(UserLoginRequest request);
    Task<bool> Logout(string token);
    Task<UserResponse> RefreshTokenAsync(string token);
}
