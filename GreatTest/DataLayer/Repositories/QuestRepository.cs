using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataLayer.Repositories
{
    public class QuestRepository : IDisposable
    {
        private GreatTestDbContext context;

        public QuestRepository(GreatTestDbContext context)
        {
            this.context = context;
        }

        public int countRows()
        {
            int rowCount = context.Quests.Count(); 

            return rowCount;
        }

        public int createRandomId(int numberOfQuests)
        {
            var random = new Random();
            var maxNumber = numberOfQuests + 1;
            var randomId = random.Next(1, maxNumber);
            return randomId;
        }
        public Question getQuest(int id)
        {
            return context.Quests.Find(id);
           
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}