using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Application.DTO.Auth;
public class UserResponse
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Gender { get; set; }
    public DateTime? BOD { get; set; }
    public int UserType { get; set; } 
    public string? AccessToken { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? CreateAt { get; set; }
    public DateTime? UpdateeAt { get; set; }
}
