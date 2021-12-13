using MentalHealth.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MentalHealth.Core.Repositories
{
    public interface IUserRepository
    {

        Task CreateUserAsync(User user, CancellationToken cancellationToken = default);

        Task<User> GetUserByIdAsync(Guid id, CancellationToken cancellationToken = default);

        Task<User> GetUserByNameAsync(string username, CancellationToken cancellationToken = default);

    }
}
