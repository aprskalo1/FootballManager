using System.Dynamic;

namespace DAL
{
    public interface IRepo
    {
        void SaveSettings(string language, string wroldCupType, string settingsPath);
        void SaveFavouriteTeam(string favouriteTeam, string settingsFilePath);
        List<Team> LoadTeams();
    }
}