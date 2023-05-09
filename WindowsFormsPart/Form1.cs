using DAL;

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
            var userSettingsForm = new UserSettings();

            if (!File.Exists(settingPath) || new FileInfo(settingPath).Length == 0)
            {
                MessageBox.Show("Nazalost nismo uspjeli pronaci spremljene postavke. Molimo unesite ponovo!", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userSettingsForm.ShowDialog();
            }

            IRepo repo = RepoFactory.GetRepo();
            List<Team> teamList = repo.LoadTeams();

            foreach (var team in teamList)
            {
                cbTeams.Items.Add(team.FillComboBox());
            }

            if (cbTeams.Items.Count > 0)
            {
                cbTeams.SelectedIndex = 0;
            }
        }

        private void btnAddFavouriteTeam_Click(object sender, EventArgs e)
        {
            IRepo repo = RepoFactory.GetRepo();
            repo.SaveFavouriteTeam(cbTeams.SelectedItem.ToString(), settingPath);
            
            lblFavouriteTeam.Visible= false;
            cbTeams.Visible= false; 
            btnAddFavouriteTeam.Visible = false;    
        }
    }
}