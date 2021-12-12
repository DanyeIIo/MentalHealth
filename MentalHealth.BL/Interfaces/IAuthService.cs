using MentalHealth.BL.DTO;
using MentalHealth.BL.Infrastucture;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealth.BL.Interfaces
{
    public interface IAuthService
    {
        Task<IdentityResult> Register(UserDTO userDTO); 
        
        Task<AuthenticationResponse> Login(UserDTO userDTO);       
       
    }
}
