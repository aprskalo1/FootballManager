using System.Dynamic;

namespace DAL
{
    public interface IRepo
    {
        void SaveSettings(string language, string wroldCupType, string settingsPath);
        void SaveWindowSettings(string windowType, string settingsPath);
        void SaveFavouriteTeam(string favouriteTeam, string settingsFilePath);
        void SaveFavouritePLayers(List<string> players, string favouritePlayersFilePath);
        public string GetCountry();
        public string GetFifaCode();
        List<Team> LoadTeams();
        List<Player> LoadPlayers();
        List<Match> LoadMatches(string fifaCode);
        List<Event> GetPlayerEventData();
        List<Visitors> GetVisitorData();
        public string GetLanguage();
        List<string> GetFavouritePlayers(string favouritePlayersFilePath);
        bool FavouriteTeamExists(string settingPath);
    }
}