using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreatTest.Models
{
    public class Play
    {
        public int QuestId { get; set; }
        public string Quest { get; set; }
        public string AnsA { get; set; }
        public string AnsB { get; set; }
        public string AnsC { get; set; }
        public string AnsD { get; set; }
        public string CorAns { get; set; }
    }
}