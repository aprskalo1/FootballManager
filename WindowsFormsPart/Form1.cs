using DAL;
using System.Windows.Forms;

namespace WindowsFormsPart
{
    public partial class Form1 : Form
    {
        private static string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).Parent.FullName;
        string settingPath = Path.Combine(path, "settings.txt");

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
                (ClientSize.Width - tlpFavouriteTeam.Width) / 2,
                (ClientSize.Height - tlpFavouriteTeam.Height) / 2
            );


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

            if (!repo.FavouriteTeamExists())
            {
                tlpFavouriteTeam.Visible= false;
                List<Player> playerList = repo.LoadPlayers();
                foreach (var player in playerList)
                {
                    cbPlayers.Items.Add(player.FillComboBox());
                }
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
                cbPlayers.Items.Add(player.FillComboBox());
            }
        }
    }
}