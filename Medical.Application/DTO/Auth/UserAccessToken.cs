using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Application.DTO.Auth;
public class UserAccessToken
{
    public string AccessToken { get; set; }
    public string Email { get; set; }
}
