using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Visitors
    {
        public Visitors(int visitorNumber, string location, string homeTeam, string awayTeam)
        {
            VisitorNumber = visitorNumber;
            Location = location;
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
        }

        public int VisitorNumber { get; set; }
        public string Location { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }

        public string GetVisitorInfo()
            => $"Visitors: {VisitorNumber} -> {Location}, Home: {HomeTeam}, Away: {AwayTeam}";   
    }
}
