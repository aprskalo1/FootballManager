using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPart
{
    public partial class PlayerForm : Form
    {
        public Player CurrentPlayer { get; set; }
        private static string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).Parent.FullName;
        string favouritePlayersFilePath = Path.Combine(path, "favPlayers.txt");
        string noImgPath = Path.Combine(path, "no-image.png");

        IRepo repo = RepoFactory.GetRepo();

        public PlayerForm()
        {
            InitializeComponent();

            MaximizeBox = false;
            MinimizeBox = false;

            Load += PlayerForm_Load;

        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            List<string> favouritePlayers = repo.GetFavouritePlayers(favouritePlayersFilePath);

            if (CurrentPlayer != null)
            {
                tbPlayerName.Text = CurrentPlayer.Name;
                tbShirtNmber.Text = CurrentPlayer.ShirtNumber.ToString();
                tbPosition.Text = CurrentPlayer.Position;
                tbIsCaptain.Text = CurrentPlayer.Captain ? "DA" : "NE";

                if (!favouritePlayers.Contains(CurrentPlayer.Name)) pbFavouritePlayerIcon.Visible = false;
            }

            pbPlayerPicture.Image = Image.FromFile(noImgPath);
            pbPlayerPicture.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
