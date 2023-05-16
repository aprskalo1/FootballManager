using DAL;
using System.Windows.Forms;

namespace WindowsFormsPart
{
    public partial class FootbalManagerForm : Form
    {
        private static string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).Parent.FullName;
        string favouritePlayersFilePath = Path.Combine(path, "favPlayers.txt");
        string settingPath = Path.Combine(path, "settings.txt");

        IRepo repo = RepoFactory.GetRepo();


        public FootbalManagerForm()
        {
            InitializeComponent();

            lbAllPlayers.AllowDrop = true;
            lbAllPlayers.DragDrop += lbAllPlayers_DragDrop;
            lbAllPlayers.DragEnter += lbAllPlayers_DragEnter;


            lbFavouritePlayers.AllowDrop = true;
            lbFavouritePlayers.DragDrop += lbFavouritePlayers_DragDrop;
            lbFavouritePlayers.DragEnter += lbFavouritePlayers_DragEnter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetInitalSettings();
        }

        private void btnAddFavouriteTeam_Click(object sender, EventArgs e)
        {
            IRepo repo = RepoFactory.GetRepo();
            repo.SaveFavouriteTeam(cbTeams.SelectedItem.ToString(), settingPath);
            tlpFavouriteTeam.Visible = false;

            List<Player> playerList = repo.LoadPlayers();
            foreach (var player in playerList)
            {
                clbPlayers.Items.Add(player.GetName());
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
            SetPlayers();
        }

        private void SetPlayers()
        {
            msMainMenu.Visible = true;
            tlpPlayersPanels.Visible = true;
            lblFavPlayers.Visible = true;
            lblOtherPlayers.Visible = true;
            btnPlayerDetails.Visible = true;

            List<Player> playerList = repo.LoadPlayers();
            List<string> favouritePlayers = repo.GetFavouritePlayers(favouritePlayersFilePath);

            lbAllPlayers.Items.Clear();
            lbFavouritePlayers.Items.Clear();

            foreach (var player in playerList)
            {
                if (!favouritePlayers.Contains(player.Name))
                {
                    lbAllPlayers.Items.Add(player.GetName());
                }
            }

            foreach (var player in favouritePlayers)
            {
                lbFavouritePlayers.Items.Add(player);
            }
        }


        private void SetInitalSettings()
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
            msMainMenu.Visible = false;
            tlpPlayersPanels.Visible = false;
            lblFavPlayers.Visible = false;
            lblOtherPlayers.Visible = false;
            btnPlayerDetails.Visible = false;

            var userSettingsForm = new UserSettings();

            if (!File.Exists(settingPath) || new FileInfo(settingPath).Length == 0)
            {
                MessageBox.Show("Nazalost nismo uspjeli pronaci spremljene postavke. Molimo unesite ponovo!", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userSettingsForm.ShowDialog();
                File.Delete(favouritePlayersFilePath);
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
                    clbPlayers.Items.Add(player.GetName());
                }
            }

            if (File.Exists(favouritePlayersFilePath) && new FileInfo(favouritePlayersFilePath).Length > 0)
            {
                SetPlayers();
            }
            else if (!repo.FavouriteTeamExists(settingPath))
            {
                tlpFavouritePlayers.Visible = true;
            }
        }

        //Drag and drop
        private void lbAllPlayers_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbAllPlayers.Items.Count > 0 && lbAllPlayers.SelectedItem != null)
            {
                lbAllPlayers.DoDragDrop(lbAllPlayers.SelectedItem, DragDropEffects.Move);
            }
        }

        private void lbFavouritePlayers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lbFavouritePlayers_DragDrop(object sender, DragEventArgs e)
        {
            List<string> favouritePlayers = repo.GetFavouritePlayers(favouritePlayersFilePath);
            favouritePlayers.Add(lbAllPlayers.SelectedItem.ToString());
            repo.SaveFavouritePLayers(favouritePlayers, favouritePlayersFilePath);

            lbFavouritePlayers.Items.Add(lbAllPlayers.SelectedItem);
            lbAllPlayers.Items.Remove(lbAllPlayers.SelectedItem);
        }

        private void lbFavouritePlayers_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbFavouritePlayers.Items.Count > 0 && lbFavouritePlayers.SelectedItem != null)
            {
                lbFavouritePlayers.DoDragDrop(lbFavouritePlayers.SelectedItem, DragDropEffects.Move);
            }
        }

        private void lbAllPlayers_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lbAllPlayers_DragDrop(object sender, DragEventArgs e)
        {
            List<string> favouritePlayers = repo.GetFavouritePlayers(favouritePlayersFilePath);
            favouritePlayers.Remove(lbFavouritePlayers.SelectedItem.ToString());
            repo.SaveFavouritePLayers(favouritePlayers, favouritePlayersFilePath);

            lbAllPlayers.Items.Add(lbFavouritePlayers.SelectedItem);
            lbFavouritePlayers.Items.Remove(lbFavouritePlayers.SelectedItem);
        }

        //Show player details
        private void btnPlayerDetails_Click(object sender, EventArgs e)
        {
            List<Player> playerList = repo.LoadPlayers();
            Player selectedPlayer = null;

            if (lbAllPlayers.SelectedItem != null)
            {
                foreach (var player in playerList)
                {
                    if (player.Name == lbAllPlayers.SelectedItem.ToString())
                    {
                        selectedPlayer = player;
                        break;
                    }
                }

                PlayerForm playerDetails = new PlayerForm();
                playerDetails.CurrentPlayer = selectedPlayer;
                playerDetails.ShowDialog();
            }

            if (lbFavouritePlayers.SelectedItem != null)
            {
                foreach (var player in playerList)
                {
                    if (player.Name == lbFavouritePlayers.SelectedItem.ToString())
                    {
                        selectedPlayer = player;
                        break;
                    }
                }

                PlayerForm playerDetails = new PlayerForm();
                playerDetails.CurrentPlayer = selectedPlayer;
                playerDetails.ShowDialog();
            }
        }
    }
}