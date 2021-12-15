using MentalHealth.Core;
using System;
using System.Security.Cryptography;
using System.Text;

namespace MentalHealth.DAL
{
    public class Hasher : IHasher
    {
        public string HashPassword(Core.Models.User user, string password)
        {
            using var alg = SHA256.Create();
            var hashBytes = alg.ComputeHash(Encoding.UTF8.GetBytes(password + user.Email));

            return Convert.ToHexString(hashBytes);
        }
    }
}
