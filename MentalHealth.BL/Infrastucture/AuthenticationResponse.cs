using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealth.BL.Infrastucture
{
    public class AuthenticationResponse
    {
        public string JwtToken { get; set; }

        public string RefreshToken { get; set; }
    }
}
