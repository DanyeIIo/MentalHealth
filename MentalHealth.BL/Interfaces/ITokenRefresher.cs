using MentalHealth.BL.Infrastucture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealth.BL.Interfaces
{
    public interface ITokenRefresher
    {
        Task<AuthenticationResponse> Refresh(AuthenticationResponse authenticationResponse);
    }
}
