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

        public List<Question> getQuest()
        {
            return context.Quests.OrderBy(x => Guid.NewGuid()).Take(1).ToList();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}