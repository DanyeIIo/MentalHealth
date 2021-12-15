using MentalHealth.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealth.Core.Services
{
    public interface IUserClaimsFactory
    {
        Task<List<Claim>> GetClaimsAsync(User user);
    }
}
