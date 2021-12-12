using MentalHealth.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealth.DAL.Repositories
{
    public class EmotionRepository
    {
        private readonly ApplicationDbContext db;

        public EmotionRepository(ApplicationDbContext userContext)
        {
            this.db = userContext;
        }

        public IEnumerable<Emotion> GetAll()
        {
            if (db.Emotions != null)
                return db.Emotions;
            else
                return new List<Emotion>();

        }

        public Emotion Get(int id)
        {
            return db.Emotions.Find(id);
        }

        public void Create(Emotion emotion)
        {
            db.Emotions.Add(emotion);
        }

        public void Update(Emotion emotion)
        {
            db.Entry(emotion).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Emotion emotion = db.Emotions.Find(id);
            if (emotion != null)
                db.Emotions.Remove(emotion);
        }
    }
}
