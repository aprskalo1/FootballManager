using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Match
    {
        public Match(string homeTeam, string homeTeamFifaCode, string awayTeamFifaCode, string awayTeam, int awayTeamGoals, int homeTeamGoals)
        {
            HomeTeam = homeTeam;
            HomeTeamFifaCode = homeTeamFifaCode;
            AwayTeam = awayTeam;
            AwayTeamFifaCode = awayTeamFifaCode;
            AwayTeamGoals = awayTeamGoals;
            HomeTeamGoals = homeTeamGoals;
        }

        public string HomeTeam { get; set; }
        public string HomeTeamFifaCode { get; set; }
        public string AwayTeam { get; set; }
        public string AwayTeamFifaCode { get; set; }
        public int AwayTeamGoals { get; set; }
        public int HomeTeamGoals { get; set; }

        public override string ToString()
            => $"{HomeTeam} - {AwayTeam} {HomeTeamGoals} : {AwayTeamGoals}";

        public string GetHomeCountryNameAndCode()
            => $"{HomeTeam} ({HomeTeamFifaCode})";
        
        public string GetAwayCountryNameAndCode()
            => $"{AwayTeam} ({AwayTeamFifaCode})";
    }
}
