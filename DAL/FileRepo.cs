using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class FileRepo : IRepo
    {
        public List<string> LoadTeams(string apiUrl)
        {
            var client = new HttpClient();
            var response = client.GetAsync(apiUrl).Result;
            var content = response.Content.ReadAsStringAsync().Result;
            var jArray = JArray.Parse(content);

            var list = new List<string>();
            foreach (var jObject in jArray)
            {
                string country = jObject["country"].ToString();
                string fifaCode = jObject["fifa_code"].ToString();
                string displayText = $"{country} ({fifaCode})";
                list.Add(displayText);
            }
            return list;
        }

        public void SaveSettings(string language, string worldCupType, string settingsFilePath)
        {
            using (StreamWriter writer = new StreamWriter(settingsFilePath))
            {
                writer.WriteLine($"{language}:{worldCupType}");
            }
        }
    }
}
