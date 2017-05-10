using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataLayer.Entities
{
    public class Question
    {
        public virtual int QuestId { get; set; }
        public virtual string Quest { get; set; }
        public virtual string AnsA { get; set; }
        public virtual string AnsB { get; set;}
        public virtual string AnsC { get; set; }
        public virtual string AnsD { get; set; }
        public virtual string CorAns { get; set; }
    }
}