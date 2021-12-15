using MentalHealth.Core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentalHealth.Core
{
    public interface IHasher
    {
        string HashPassword(User user, string password);
    }
}
