using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealth.BL.DTO
{
    public class UserDTO
    {
        public string Id { get; set; }
       
        public string Email { get; set; }

        public string Username { get; set; }

        public string Role { get; set; }

        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<EmotionDTO> Emotions { get; set; }
    }
}
