using System.Dynamic;

namespace DAL
{
    public interface IRepo
    {
        void SaveSettings(string language, string wroldCupType, string settingsPath);
        List<string> LoadTeams(string apiUrl);
    }
}