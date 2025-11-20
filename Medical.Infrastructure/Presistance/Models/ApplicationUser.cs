using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Infrastructure.Presistance.Models;
public class ApplicationUser : IdentityUser
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Gender { get; set; }
    public DateTime? BOD { get; set; }
    public string? Address { get; set; }
    public int UserType { get; set; } = 0;
    public int IsActive { get; set; } = 1;
    public string? RefreshToken { get; set; } 
    public DateTime? RefreshTokenExpiryTime { get; set; }
    public DateTime? CreateAt { get; set; }
    public DateTime? UpdateeAt { get; set; }


}
