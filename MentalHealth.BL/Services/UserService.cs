using MentalHealth.Core.Models;
using MentalHealth.Core.Models.Requests.Account;
using MentalHealth.Core.Models.Responses.Account;
using MentalHealth.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MentalHealth.BL.Services
{
    public class UserService : IUserService
    {
        public Task<User> GetMeAsync(ClaimsPrincipal claimsPrincipal, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<AuthenticationResponse> LoginAsync(LoginRequest model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<AuthenticationResponse> RegisterAsync(RegisterRequest model, Guid roleId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
