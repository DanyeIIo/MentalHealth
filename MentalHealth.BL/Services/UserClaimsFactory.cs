using MentalHealth.Core.Models;
using MentalHealth.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealth.BL.Services
{
    public class UserClaimsFactory : IUserClaimsFactory
    {
        public Task<List<Claim>> GetClaimsAsync(User user)
        {
            var role = user.RoleName;
            var claims = new List<Claim>
            {
                new(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new(ClaimTypes.Name, user.Email),
                new(ClaimTypes.Role, role),
                new(ClaimTypes.Role, user.RoleId.ToString())
            };
            return Task.FromResult(claims);
        }
    }
}
