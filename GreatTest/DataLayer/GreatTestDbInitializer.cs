using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataLayer.Entities;

namespace DataLayer
{
    public class GreatTestDbInitializer : System.Data.Entity.DropCreateDatabaseAlways<GreatTestDbContext>
    {
        protected override void Seed(GreatTestDbContext context)
        {
            context.Quests.Add(new Question
            {
                Quest = "Vem är rektor vid Örebro Universitet?",
                AnsA = "Johan Aderud",
                AnsB = "Johan Schnüder",
                AnsC = "Johan Pettersson",
                AnsD = "Andreas Ask",
                CorAns = "AnsB"
            });

            context.Quests.Add(new Question
            {
                Quest = "Vilka busslinjer stannar vid Örebro Universitet?",
                AnsA = "2, 3, 9, 10",
                AnsB = "3, 7, 9, 10",
                AnsC = "2, 3, 7 ,10",
                AnsD = "2, 5, 9, 10",
                CorAns = "AnsA"
            });

            context.Quests.Add(new Question
            {
                Quest = "Vilket är INTE ett smeknamn för Örebro?",
                AnsA = "Öret",
                AnsB = "Örebronx",
                AnsC = "Pennytown",
                AnsD = "Pennybridge",
                CorAns = "AnsC"
            });

            context.Quests.Add(new Question
            {
                Quest = "Hur många personer bor i Örebro kommun?",
                AnsA = "146 391",
                AnsB = "146 631",
                AnsC = "146 104",
                AnsD = "146 945",
                CorAns = "AnsB"
            });

            context.Quests.Add(new Question
            {
                Quest = "Hur många institutioner finns det vid Örebro Universitet?",
                AnsA = "6",
                AnsB = "9",
                AnsC = "7",
                AnsD = "8",
                CorAns = "AnsD"
            });

            context.Quests.Add(new Question
            {
                Quest = "Hur många studenter finns det vid Örebro Universitet?",
                AnsA = "ca 14 000",
                AnsB = "ca 13 000",
                AnsC = "ca 16 000",
                AnsD = "ca 15 000",
                CorAns = "AnsC"
            });

            context.Quests.Add(new Question
            {
                Quest = "Hur många professorer finns det vid Örebro Universitet?",
                AnsA = "110",
                AnsB = "100",
                AnsC = "115",
                AnsD = "105",
                CorAns = "AnsA"
            });

            context.Quests.Add(new Question
            {
                Quest = "Hur många doktorander finns det vid Örebro Universitet?",
                AnsA = "500",
                AnsB = "300",
                AnsC = "600",
                AnsD = "400",
                CorAns = "AnsD"
            });

            context.Quests.Add(new Question
            {
                Quest = "Hur många kurser erbjuder Örebro Universitet?",
                AnsA = "550",
                AnsB = "600",
                AnsC = "450",
                AnsD = "500",
                CorAns = "AnsB"
            });

            context.Quests.Add(new Question
            {
                Quest = "Hur många program finns det på Örebro Universitet?",
                AnsA = "90",
                AnsB = "70",
                AnsC = "80",
                AnsD = "60",
                CorAns = "AnsC"
            });

            context.Quests.Add(new Question
            {
                Quest = "Vilken studentsektion tillhör handelshögskolan?",
                AnsA = "Sesam",
                AnsB = "Serum",
                AnsC = "Corax",
                AnsD = "TekNat",
                CorAns = "AnsA"
            });

            base.Seed(context);
        }
    }
}