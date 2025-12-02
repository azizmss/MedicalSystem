using Medical.Application.DTO.Auth;
using Medical.Application.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medical.PL.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;
    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(UserRegisterRequest userDto)
    {
        var user = await _authService.RegisterAsync(userDto);
        return Ok(user);
    }

    [HttpPost("login")]

    public async Task<IActionResult> login([FromForm] UserLoginRequest userDto)
    {
        var user = await _authService.LoginAsync(userDto);
        return Ok(user);
    }
    [HttpPost("refresh/token")]
    public async Task<IActionResult> refreshToken([FromBody] string token)
    {
        return Ok(await _authService.RefreshTokenAsync(token));

    }

    [HttpPost("logout")]
    public async Task<IActionResult> logout([FromBody] string token)
    {

        var isLogout = await _authService.Logout(token);
        if (isLogout)
        {
            return Ok("You logout successfuly");
        }
        else
        {
            return BadRequest("error in logout");
        }
    }
}
