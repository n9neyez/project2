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
        public string Attendance { get; set; }
        // Winners' properties =)
        public string QBWinner { get; set; }
        public string CoachWinner { get; set; }
        public string Winner { get; set; }
        public string WinningPoints { get; set; }
        // Losers' properties =(
        public string QBLoser { get; set; }
        public string CoachLoser { get; set; }
        public string Loser { get; set; }
        public string LosingPoints { get; set; }
        // Special Properties...not really though..kind of
        public string MVP { get; set; }
        public string Stadium { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        // class constructor....very long
        public SuperBowl(string date, string superbowlNum, string attendance, string qbWinner, string coachWinner,
                         string winner, string winningPts, string qbLoser, string coachLoser, string loser,
                         string losingPts, string mvp, string stadium, string city, string state)
        {
            Date = date;
            SuperBowlNum = superbowlNum;
            Attendance = attendance;
            QBWinner = qbWinner;
            CoachWinner = coachWinner;
            Winner = winner;
            WinningPoints = winningPts;
            QBLoser = qbLoser;
            CoachLoser = coachLoser;
            Loser = loser;
            LosingPoints = losingPts;
            MVP = mvp;
            Stadium = stadium;
            City = city;
            State = state;
        }
        /*
        public override string ToString()
        {
            return String.Format($"Account Number: {Date} \nFirst Name: {SuperBowlNum} \nLast Name: {Attendance} \nAccount Balance: {QBWinner} \nDate Account Created: {CoachWinner} \n\n");
        }
        */
    }
}
