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
}
