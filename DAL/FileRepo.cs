using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Dynamic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
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
                (
                    jObject.Value<int>("id"),
                    jObject.Value<string>("country"),
                    jObject.Value<string>("alternate_name"),
                    jObject.Value<string>("fifa_code"),
                    jObject.Value<int>("group_id"),
                    jObject.Value<string>("group_letter")[0],
                    jObject.Value<int>("wins"),
                    jObject.Value<int>("draws"),
                    jObject.Value<int>("losses"),
                    jObject.Value<int>("games_played"),
                    jObject.Value<int>("points"),
                    jObject.Value<int>("goals_for"),
                    jObject.Value<int>("goals_against"),
                    jObject.Value<int>("goal_differential")
                );
                teams.Add(team);
            }
            return teams;
        }

        public List<Player> LoadPlayers()
        {
            string fifaCode = GetFifaCode();
            string country = GetCountry();

            string apiUrl;
            if (GetGender() == "Musko")
            {
                apiUrl = "https://worldcup-vua.nullbit.hr/men/matches/country?fifa_code=" + fifaCode;
            }
            else
            {
                apiUrl = "https://worldcup-vua.nullbit.hr/women/matches/country?fifa_code=" + fifaCode;
            }

            var client = new HttpClient();
            var response = client.GetAsync(apiUrl).Result;
            var content = response.Content.ReadAsStringAsync().Result;
            var jArray = JArray.Parse(content);

            var players = new List<Player>();

            JArray startingElevenArray_homeTeam = (JArray)jArray[0]["home_team_statistics"]["starting_eleven"];
            JArray substitutesArray_homeTeam = (JArray)jArray[0]["home_team_statistics"]["substitutes"];

            JArray startingElevenArray_awayTeam = (JArray)jArray[0]["away_team_statistics"]["starting_eleven"];
            JArray substitutesArray_awayTeam = (JArray)jArray[0]["away_team_statistics"]["substitutes"];

            JObject teamStatsObject = (JObject)jArray[0]["home_team_statistics"];
            string teamCountry = teamStatsObject.Value<string>("country");

            if (teamCountry == country)
            {
                foreach (JObject playerObject in startingElevenArray_homeTeam)
                {
                    Player player = new Player
                    (
                        playerObject.Value<string>("name"),
                        playerObject.Value<bool>("captain"),
                        playerObject.Value<int>("shirt_number"),
                        playerObject.Value<string>("position")
                    );
                    players.Add(player);
                }

                foreach (JObject playerObject in substitutesArray_homeTeam)
                {
                    Player player = new Player
                    (
                        playerObject.Value<string>("name"),
                        playerObject.Value<bool>("captain"),
                        playerObject.Value<int>("shirt_number"),
                        playerObject.Value<string>("position")
                    );
                    players.Add(player);
                } 
            }

            else
            {
                foreach (JObject playerObject in startingElevenArray_awayTeam)
                {
                    Player player = new Player
                     (
                         playerObject.Value<string>("name"),
                         playerObject.Value<bool>("captain"),
                         playerObject.Value<int>("shirt_number"),
                         playerObject.Value<string>("position")
                     );
                    players.Add(player);
                }

                foreach (JObject playerObject in substitutesArray_awayTeam)
                {
                    Player player = new Player
                     (
                         playerObject.Value<string>("name"),
                         playerObject.Value<bool>("captain"),
                         playerObject.Value<int>("shirt_number"),
                         playerObject.Value<string>("position")
                     );
                    players.Add(player);
                }
            }

            return players;
        }


        public List<Visitors> GetVisitorData()
        {
            string fifaCode = GetFifaCode();
            string country = GetCountry();

            string apiUrl;
            if (GetGender() == "Musko")
            {
                apiUrl = "https://worldcup-vua.nullbit.hr/men/matches/country?fifa_code=" + fifaCode;
            }
            else
            {
                apiUrl = "https://worldcup-vua.nullbit.hr/women/matches/country?fifa_code=" + fifaCode;
            }

            var client = new HttpClient();
            var response = client.GetAsync(apiUrl).Result;
            var content = response.Content.ReadAsStringAsync().Result;
            var jArray = JArray.Parse(content);

            var visitorList = new List<Visitors>();

            foreach (var jObject in jArray)
            {
                Visitors visitor = new Visitors(
                    jObject.Value<int>("attendance"),
                    jObject.Value<string>("location"),
                    jObject.Value<string>("home_team_country"),
                    jObject.Value<string>("away_team_country")
                );

                visitorList.Add(visitor);
            }

            return visitorList;
        }

        public List<Event> GetPlayerEventData()
        {
            string fifaCode = GetFifaCode();
            string country = GetCountry();

            string apiUrl;
            if (GetGender() == "Musko")
            {
                apiUrl = "https://worldcup-vua.nullbit.hr/men/matches/country?fifa_code=" + fifaCode;
            }
            else
            {
                apiUrl = "https://worldcup-vua.nullbit.hr/women/matches/country?fifa_code=" + fifaCode;
            }

            var client = new HttpClient();
            var response = client.GetAsync(apiUrl).Result;
            var content = response.Content.ReadAsStringAsync().Result;
            var jArray = JArray.Parse(content);

            var eventList = new List<Event>();

            foreach (JObject matchObject in jArray)
            {
                JArray homeTeamEvents = (JArray)matchObject["home_team_events"];
                JArray awayTeamEvents = (JArray)matchObject["away_team_events"];

                string homeTeamCountry = matchObject.Value<string>("home_team_country");

                if (homeTeamCountry == country)
                {
                    foreach (JObject eventObject in homeTeamEvents)
                    {
                        if (eventObject.Value<string>("type_of_event") == "yellow-card" || eventObject.Value<string>("type_of_event") == "goal")
                        {
                            Event playerEvent = new Event(
                                eventObject.Value<string>("type_of_event"),
                                eventObject.Value<string>("player")
                            );
                            eventList.Add(playerEvent); 
                        }
                    } 
                }

                else
                {
                    foreach (JObject eventObject in awayTeamEvents)
                    {
                        if (eventObject.Value<string>("type_of_event") == "yellow-card" || eventObject.Value<string>("type_of_event") == "goal")
                        {
                            Event playerEvent = new Event(
                                eventObject.Value<string>("type_of_event"),
                                eventObject.Value<string>("player")
                            );
                            eventList.Add(playerEvent); 
                        }
                    }   
                }
            }

            return eventList;
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
            string[] parts = favouriteTeam.Split(" (");
            string formattedTeam = $"{parts[0]}:{parts[1].TrimEnd(')')}";

            using (StreamWriter writer = new StreamWriter(settingsFilePath, true))
            {
                writer.Write($":{formattedTeam}");
            }
        }

        public void SaveFavouritePLayers(List<string> players, string favouritePlayersFilePath)
        {
            using (StreamWriter sw = new StreamWriter(favouritePlayersFilePath))
            {
                bool isFirst = true;

                foreach (string player in players)
                {
                    if (!isFirst) sw.Write(":");
                    else isFirst = false;
                    sw.Write(player);
                }
            }
        }

        public List<string> GetFavouritePlayers(string favouritePlayersFilePath)
        {
            List<string> favouritePlayers = new List<string>();
            if (File.Exists(favouritePlayersFilePath))
            {
                string[] lines = File.ReadAllLines(favouritePlayersFilePath);
                if (lines.Length > 0)
                {
                    foreach (var line in lines)
                    {
                        string[] parts = line.Split(':');
                        favouritePlayers.AddRange(parts); 
                    }
                    return favouritePlayers;
                }
            }
            throw new FileNotFoundException("Nemozemo pronaci datoteku s postavkama, molimo ponovno pokrenite aplikaciju.");
        }

        public string GetLanguage()
        {
            if (File.Exists(settingPath))
            {
                string[] lines = File.ReadAllLines(settingPath);
                if (lines.Length > 0)
                {
                    string[] parts = lines[0].Split(':');
                    if (parts.Length <= 4) return parts[0].Trim();
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
                    if (parts.Length <= 4) return parts[1].Trim();
                }
            }
            throw new FileNotFoundException("Nemozemo pronaci datoteku s postavkama, molimo ponovno pokrenite aplikaciju.");
        }

        internal string GetFifaCode()
        {
            if (File.Exists(settingPath))
            {
                string[] lines = File.ReadAllLines(settingPath);
                if (lines.Length > 0)
                {
                    string[] parts = lines[0].Split(':');
                    if (parts.Length <= 4) return parts[3].Trim();
                }
            }
            throw new FileNotFoundException("Nemozemo pronaci datoteku s postavkama, molimo ponovno pokrenite aplikaciju.");
        }

        internal string GetCountry()
        {
            if (File.Exists(settingPath))
            {
                string[] lines = File.ReadAllLines(settingPath);
                if (lines.Length > 0)
                {
                    string[] parts = lines[0].Split(':');
                    if (parts.Length <= 4) return parts[2].Trim();
                }
            }
            throw new FileNotFoundException("Nemozemo pronaci datoteku s postavkama, molimo ponovno pokrenite aplikaciju.");
        }

        public bool FavouriteTeamExists(string settingPath)
        {
            string[] lines = File.ReadAllLines(settingPath);
            if (lines.Length > 0)
            {
                string[] parts = lines[0].Split(':');
                if (parts.Length < 4) return true;
            }
            return false;  
        }
    }
}