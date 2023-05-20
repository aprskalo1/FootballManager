using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Team
    {
        public Team(int id, string country, string alternateName, string fifaCode, int groupId, char groupLetter, int wins, int draws, int losses, int gamesPlayed, int points, int goalsFor, int goalsAgainst, int goalDifferential)
        {
            Id = id;
            Country = country;
            AlternateName = alternateName;
            FifaCode = fifaCode;
            GroupId = groupId;
            GroupLetter = groupLetter;
            Wins = wins;
            Draws = draws;
            Losses = losses;
            GamesPlayed = gamesPlayed;
            Points = points;
            GoalsFor = goalsFor;
            GoalsAgainst = goalsAgainst;
            GoalDifferential = goalDifferential;
        }

        public int Id { get; set; }
        public string Country { get; set; }
        public string AlternateName { get; set; }
        public string FifaCode { get; set; }
        public int GroupId { get; set; }
        public char GroupLetter { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
        public int GamesPlayed { get; set; }
        public int Points { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalDifferential { get; set; }

        public string FillComboBox()
           => $"{Country} ({FifaCode})";
    }
}
