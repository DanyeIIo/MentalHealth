using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealth.Core.Models.Requests.Account
{
    public class TokenIssuerOptions
    {
        public const string Section = "TokenIssuerOptions";

        public string Secret { get; set; }
    }
}
