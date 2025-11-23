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

    public async Task<IActionResult> login(UserLoginRequest userDto)
    {
        var user = await _authService.LoginAsync(userDto);
        return Ok(user);
    }
}
