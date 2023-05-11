using DAL;
using System.Windows.Forms;

namespace WindowsFormsPart
{
    public partial class Form1 : Form
    {
        private static string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).Parent.FullName;
        string settingPath = Path.Combine(path, "settings.txt");
        string favouritePlayersFilePath = Path.Combine(path, "favPlayers.txt");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tlpFavouriteTeam.Location = new Point(
                (ClientSize.Width - tlpFavouriteTeam.Width) / 2,
                (ClientSize.Height - tlpFavouriteTeam.Height) / 2
            );

            tlpFavouritePlayers.Location = new Point(
                (ClientSize.Width - tlpFavouritePlayers.Width) / 2,
                (ClientSize.Height - tlpFavouritePlayers.Height) / 2
            );
            tlpFavouritePlayers.Visible = false;

            var userSettingsForm = new UserSettings();
            IRepo repo = RepoFactory.GetRepo();

            if (!File.Exists(settingPath) || new FileInfo(settingPath).Length == 0)
            {
                MessageBox.Show("Nazalost nismo uspjeli pronaci spremljene postavke. Molimo unesite ponovo!", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userSettingsForm.ShowDialog();
            }

            List<Team> teamList = repo.LoadTeams();
            foreach (var team in teamList)
            {
                cbTeams.Items.Add(team.FillComboBox());
            }

            if (cbTeams.Items.Count > 0)
            {
                cbTeams.SelectedIndex = 0;
            }

            if (!repo.FavouriteTeamExists(settingPath))
            {
                tlpFavouriteTeam.Visible = false;
                List<Player> playerList = repo.LoadPlayers();
                foreach (var player in playerList)
                {
                    clbPlayers.Items.Add(player.FillComboBox());
                }
            }

            if ((!File.Exists(favouritePlayersFilePath) || new FileInfo(favouritePlayersFilePath).Length == 0) && !repo.FavouriteTeamExists(settingPath))
            {
                tlpFavouritePlayers.Visible = true;
            }
        }

        private void btnAddFavouriteTeam_Click(object sender, EventArgs e)
        {
            IRepo repo = RepoFactory.GetRepo();
            repo.SaveFavouriteTeam(cbTeams.SelectedItem.ToString(), settingPath);
            tlpFavouriteTeam.Visible = false;

            List<Player> playerList = repo.LoadPlayers();
            foreach (var player in playerList)
            {
                clbPlayers.Items.Add(player.FillComboBox());
            }

            tlpFavouritePlayers.Visible = true;
        }

        private void btnAddFavouritePlayers_Click(object sender, EventArgs e)
        {
            List<string> selectedPlayers = new List<string>();
            foreach (string player in clbPlayers.CheckedItems)
            {
                selectedPlayers.Add(player);
            }

            IRepo repo = RepoFactory.GetRepo();
            repo.SaveFavouritePLayers(selectedPlayers, favouritePlayersFilePath);

            tlpFavouritePlayers.Visible = false;
        }
    }
}