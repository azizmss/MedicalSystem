using Medical.Application.DTO.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Application.Service.Interface;
public interface ITokenService
{
    Task<string> GenerateToken(UserResponse user);
    string CreateRefreshToken();
}
