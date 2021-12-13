using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealth.Core.Models.Responses.Account
{
    public class AuthenticationResponse
    {
        public bool IsSuccess { get; set; } = true;

        public Guid UserId { get; set; }

        public string AccessToken { get; set; }
    }
}
