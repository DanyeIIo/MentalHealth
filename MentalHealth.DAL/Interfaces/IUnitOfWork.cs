using MentalHealth.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealth.DAL.Interfaces
{
    interface IUnitOfWork
    {
        IRepository<User> Users { get; }
        IRepository<Emotion> Emotions { get; }
        void Save();
    }
}
