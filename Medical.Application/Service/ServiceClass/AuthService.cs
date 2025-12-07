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

        var token = _tokenService.GenerateToken(user);

        user.AccessToken = await token;
        var accessToken = new UserAccessToken()
        {
            AccessToken = user.AccessToken,
            Email = request.Email
        };
        var result = await _authRepository.updateUserToken(accessToken);
        if (result)
        {
            return user;
        }
        else
        {
            return new UserResponse();
        }

    }
    public async Task<UserResponse> RegisterAsync(UserRegisterRequest request)
    {
        var user = await _authRepository.RegisterAsync(request);
        var token = _tokenService.GenerateToken(user);
        user.AccessToken = await token;

        var accessToken = new UserAccessToken()
        {
            AccessToken = user.AccessToken,
            Email = request.Email
        };
        await _authRepository.updateUserToken(accessToken);
        return user;
    }
    public async Task<UserResponse> RefreshTokenAsync(string token)
    {
        var userResponse = new UserResponse();

        var user = await _authRepository.checkToken(token);

        var newRefreshToken = _tokenService.GenerateRefreshToken();
        user.RefreshToken = newRefreshToken;
        user.RefreshTokenExpiryTime = DateTime.Now.AddMinutes(10);
        
        await _authRepository.updateUserRefreshToken(user);


        userResponse.AccessToken = user.AccessToken;
        userResponse.Email = user.Email;
        userResponse.FirstName = user.FirstName;
        userResponse.LastName = user.LastName;

        userResponse.RefreshToken = newRefreshToken;

        userResponse.RefreshTokenExpiryTime = DateTime.Now.AddMinutes(10);
        return userResponse;
    }


    public async Task<bool> Logout(string token)
    {
        try
        {
            var user = await _authRepository.checkToken(token);

            if (user == null)
                return false;

            user.AccessToken = string.Empty;// null;
            user.ExpireToken = DateTime.Now;

            user.RefreshToken = string.Empty;//null;
            user.RefreshTokenExpiryTime = DateTime.Now; ;// null;

            user.RevokeOn = DateTime.Now;  // logout

            await _authRepository.updateUserRefreshToken(user);

            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}
