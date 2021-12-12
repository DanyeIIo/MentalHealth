using MentalHealth.DAL.Entities;
using MentalHealth.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealth.DAL.Repositories
{
    class UserRepository : IRepository<User>
    {
        private readonly ApplicationDbContext db;

        public UserRepository(ApplicationDbContext userContext)
        {
            this.db = userContext;
        }

        public IEnumerable<User> GetAll()
        {
            if (db.Users != null)
                return db.Users;
            else
                return new List<User>();

        }

        public User Get(int id)
        {
            return db.Users.Find();
        }

        public void Create(User user)
        {
            db.Users.Add(user);
        }

        public void Update(User user)
        {
            db.Entry(user).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
                db.Users.Remove(user);
        }

    }
}
