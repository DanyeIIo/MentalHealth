using MentalHealth.Core.Models;
using MentalHealth.Core.Models.Responses.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MentalHealth.Core.Services
{
    public interface ITokenService
    {
        Task<AuthenticationResponse> CreateAuthenticationResponseAsync(User user, CancellationToken cancellationToken = default);
    }
}
