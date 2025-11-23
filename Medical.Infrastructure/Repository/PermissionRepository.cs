using AutoMapper;
using Medical.Application.Repository.Interfaces;
using Medical.Infrastructure.Presistance.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Infrastructure.Repository;
public class PermissionRepository : IPermissionRepository
{
    private readonly RoleManager<ApplicationRole> _roleManager;
    private readonly IMapper _mapper;
    private readonly UserManager<ApplicationUser> _userManager;

    public PermissionRepository(RoleManager<ApplicationRole> roleManager,
        IMapper mapper,
        UserManager<ApplicationUser> userManager)
    {
        _roleManager = roleManager;
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task<IList<Claim>> getUserClaims(string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        IList<Claim> claims = await _userManager.GetClaimsAsync(user);
        return claims;
    }

}
