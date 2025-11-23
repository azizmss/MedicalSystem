using Medical.Application.DTO.Auth;
using Medical.Application.Extentions;
using Medical.Application.Repository.Interfaces;
using Medical.Application.Service.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Application.Service.ServiceClass;
public class TokenService : ITokenService
{
    private readonly IPermissionRepository _permissionRepository;

    private readonly IConfiguration _configuration;
    private readonly SymmetricSecurityKey _secretKey;
    private readonly string? _validIssuer;
    private readonly string? _validAudience;
    private readonly double _expires;

    public TokenService(IConfiguration configuration,IPermissionRepository permissionRepository)
    {
        _permissionRepository = permissionRepository;

        var jwtSettings = configuration.GetSection("JwtSettings").Get<JwtSettings>(); // mapping

        if (jwtSettings == null || string.IsNullOrEmpty(jwtSettings.SecretKey))
        {
            throw new InvalidOperationException("JWT secret key is not configured.");
        }

        _secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey));
        _validIssuer = jwtSettings.Issuer;
        _validAudience = jwtSettings.Audience;
        _expires = jwtSettings.Expires;
    }

    public string CreateRefreshToken()
    {
        throw new NotImplementedException();
    }

    public async Task<string> GenerateToken(UserResponse user)
    {
        // steps to generate token

        var Header = new SigningCredentials(_secretKey, SecurityAlgorithms.HmacSha256);
        var Payload = await _permissionRepository.getUserClaims(user.Id.ToString());
        var signature = GenerateTokenOptions(Header, Payload);

        return new JwtSecurityTokenHandler().WriteToken(signature); // token string
    }



    private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, IList<Claim> claims)
    {
        return new JwtSecurityToken(
            issuer: _validIssuer,
            audience: _validAudience,
            claims: claims,
            expires: DateTime.Now.AddMinutes(_expires),
            signingCredentials: signingCredentials
        );
    }

}
