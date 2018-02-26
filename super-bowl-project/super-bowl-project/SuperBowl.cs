using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace super_bowl_project
{
    class SuperBowl
    {
        // Basic properties
        public string Date { get; set; }
        public string SuperBowlNum { get; set; }
        public int Attendance { get; set; }
        // Winners' properties =)
        public string QBWinner { get; set; }
        public string CoachWinner { get; set; }
        public string Winner { get; set; }
        public int WinningPoints { get; set; }
        // Losers' properties =(
        public string QBLoser { get; set; }
        public string CoachLoser { get; set; }
        public string Loser { get; set; }
        public int LosingPoints { get; set; }
        // Special Properties...not really though..kind of
        public string MVP { get; set; }
        public string Stadium { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
