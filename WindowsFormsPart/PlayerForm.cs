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
        private string imgPath = "C:\\Users\\antep\\Desktop\\faks\\OOPNET\\OOP-Project-Task\\WindowsFormsPart\\Images\\no-image.png";

        public PlayerForm()
        {
            InitializeComponent();

            MaximizeBox = false;
            MinimizeBox = false;

            Load += PlayerForm_Load;

        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            if (CurrentPlayer != null)
            {
                tbPlayerName.Text = CurrentPlayer.Name;
                tbShirtNmber.Text = CurrentPlayer.ShirtNumber.ToString();
                tbPosition.Text = CurrentPlayer.Position;
                cbIsCaptain.Checked = CurrentPlayer.Captain;
            }

            pbPlayerPicture.Image = Image.FromFile(imgPath);
            pbPlayerPicture.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
