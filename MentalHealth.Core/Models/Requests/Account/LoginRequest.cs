using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealth.Core.Models.Requests.Account
{
    public class LoginRequest
    {
        [Required]
        //[RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",
        //    ErrorMessage = "Invalid mail adress")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
