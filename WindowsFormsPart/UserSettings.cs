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
    public partial class UserSettings : Form
    {
        private readonly string settingsFilePath = "C:\\Users\\antep\\Desktop\\faks\\OOPNET\\OOP-Project-Task\\settings.txt";

        public UserSettings()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            if (cbChooseLanguage.SelectedIndex == -1 || cbChooseWorldCup.SelectedIndex == -1)
            {
                MessageBox.Show("Molimo unesite sve i ispravne parametre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string language = cbChooseLanguage.SelectedItem.ToString();
                string worldCupType = cbChooseWorldCup.SelectedItem.ToString();

                IRepo repo = RepoFactory.GetRepo();
                repo.SaveSettings(language, worldCupType, settingsFilePath);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pogreska pri spremanju podataka: {ex.Message}");
            }
        }
    }
}
