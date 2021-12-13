using MentalHealth.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MentalHealth.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task CreateUserAsync(Core.Models.User user, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Core.Models.User> GetUserByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Core.Models.User> GetUserByNameAsync(string username, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
