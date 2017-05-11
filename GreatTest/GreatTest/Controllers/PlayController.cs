using System.Web.Mvc;
using GreatTest.Models;
using DataLayer;
using DataLayer.Repositories;



namespace GreatTest.Controllers
{
    public class PlayController : Controller
    {
        private GreatTestDbContext context = new GreatTestDbContext();
        // GET: Play
        public ActionResult Play()
        {
            PlayModel model = new PlayModel();
            var questRep = new QuestRepository(context);
            var numbersOfQuests = questRep.countRows();
            var selectedQuestID = questRep.createRandomId(numbersOfQuests);
            var selectedQuest = questRep.getQuest(selectedQuestID);

            model.ID = selectedQuest.ID;
            model.Quest = selectedQuest.Quest;
            model.AnsA = selectedQuest.AnsA;
            model.AnsB = selectedQuest.AnsB;
            model.AnsC = selectedQuest.AnsC;
            model.AnsD = selectedQuest.AnsD;
            model.CorAns = selectedQuest.CorAns;

            return View(model);
        }
    }
}