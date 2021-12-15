using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealth.DAL.Entities
{
    public class Question // For the future
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public List<Answer> Answers { get; set; } = new();
        
        public class Answer
        {
            public Guid Id { get; set; } = Guid.NewGuid();
            public string Content { get; set; }
            //public Guid QuestionId { get; set; }
            //public Question Question { get; set; }
        }
    }
}
