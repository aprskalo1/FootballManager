using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    internal class FileRepo : IRepo
    {
        private static string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).Parent.FullName;
        string settingPath = Path.Combine(path, "settings.txt");

        public List<Team> LoadTeams()
        {
            string apiUrl;
            if (GetGender() == "Musko")
            {
                apiUrl = "https://worldcup-vua.nullbit.hr/men/teams/results";
            }
            else 
            {
                apiUrl = "https://worldcup-vua.nullbit.hr/women/teams/results";
            }

            var client = new HttpClient();
            var response = client.GetAsync(apiUrl).Result;
            var content = response.Content.ReadAsStringAsync().Result;
            var jArray = JArray.Parse(content);

            var teams = new List<Team>();
            foreach (var jObject in jArray)
            {
                var team = new Team
                {
                    Id = jObject.Value<int>("id"),
                    Country = jObject.Value<string>("country"),
                    AlternateName = jObject.Value<string>("alternate_name"),
                    FifaCode = jObject.Value<string>("fifa_code"),
                    GroupId = jObject.Value<int>("group_id"),
                    GroupLetter = jObject.Value<string>("group_letter")[0],
                    Wins = jObject.Value<int>("wins"),
                    Draws = jObject.Value<int>("draws"),
                    Losses = jObject.Value<int>("losses"),
                    GamesPlayed = jObject.Value<int>("games_played"),
                    Points = jObject.Value<int>("points"),
                    GoalsFor = jObject.Value<int>("goals_for"),
                    GoalsAgainst = jObject.Value<int>("goals_against"),
                    GoalDifferential = jObject.Value<int>("goal_differential")
                };
                teams.Add(team);
            }
            return teams;
        }

        public void SaveSettings(string language, string worldCupType, string settingsFilePath)
        {
            using (StreamWriter writer = new StreamWriter(settingsFilePath))
            {
                writer.Write($"{language}:{worldCupType}");
            }
        }

        public void SaveFavouriteTeam(string favouriteTeam, string settingsFilePath)
        {
            using (StreamWriter writer = new StreamWriter(settingsFilePath, true))
            {
                writer.Write($":{favouriteTeam}");
            }
        }

        internal string GetLanguage()
        {
            if (File.Exists(settingPath))
            {
                string[] lines = File.ReadAllLines(settingPath);
                if (lines.Length > 0)
                {
                    string[] parts = lines[0].Split(':');
                    if (parts.Length <= 3)
                    {
                        return parts[0].Trim();
                    }
                }
            }
            throw new FileNotFoundException("Nemozemo pronaci datoteku s postavkama, molimo ponovno pokrenite aplikaciju.");
        }

        internal string GetGender()
        {
            if (File.Exists(settingPath))
            {
                string[] lines = File.ReadAllLines(settingPath);
                if (lines.Length > 0)
                {
                    string[] parts = lines[0].Split(':');
                    if (parts.Length <= 3)
                    {
                        return parts[1].Trim();
                    }
                }
            }
            throw new FileNotFoundException("Nemozemo pronaci datoteku s postavkama, molimo ponovno pokrenite aplikaciju.");
        }

        public bool FavouriteTeamExists()
        {
            string[] lines = File.ReadAllLines(settingPath);
            if (lines.Length > 0)
            {
                string[] parts = lines[0].Split(':');
                if (parts.Length < 3)
                {
                    return true;
                }
            }
            return false;  
        }
    }
}

