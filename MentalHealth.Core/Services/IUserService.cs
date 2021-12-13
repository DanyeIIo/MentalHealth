using MentalHealth.Core.Models;
using MentalHealth.Core.Models.Requests.Account;
using MentalHealth.Core.Models.Responses.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MentalHealth.Core.Services
{
    public interface IUserService
    {
        Task<AuthenticationResponse> RegisterAsync(RegisterRequest model, Guid roleId, CancellationToken cancellationToken = default);

        Task<AuthenticationResponse> LoginAsync(LoginRequest model, CancellationToken cancellationToken = default);

        Task<User> GetMeAsync(ClaimsPrincipal claimsPrincipal, CancellationToken cancellationToken = default);
    }
}
