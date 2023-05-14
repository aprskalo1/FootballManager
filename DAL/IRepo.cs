using System.Dynamic;

namespace DAL
{
    public interface IRepo
    {
        void SaveSettings(string language, string wroldCupType, string settingsPath);
        void SaveFavouriteTeam(string favouriteTeam, string settingsFilePath);
        void SaveFavouritePLayers(List<string> players, string favouritePlayersFilePath);
        List<Team> LoadTeams();
        List<Player> LoadPlayers();
        List<string> GetFavouritePlayers(string favouritePlayersFilePath);
        bool FavouriteTeamExists(string settingPath);
    }
}