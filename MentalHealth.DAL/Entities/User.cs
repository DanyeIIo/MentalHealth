using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealth.DAL.Entities
{
    public class User : IdentityUser
    {        
        public DateTime DateOfBirth { get; set; }
        public List<Emotion> Emotions { get; set; }

        
    }
}
