namespace WindowsFormsPart
{
    public partial class Form1 : Form
    {
        private readonly string settingsFilePath = "C:\\Users\\antep\\Desktop\\faks\\OOPNET\\OOP-Project-Task\\settings.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var userSettingsForm = new UserSettings();

            if (!File.Exists(settingsFilePath) || new FileInfo(settingsFilePath).Length == 0)
            {
                MessageBox.Show("Nazalost nismo uspjeli pronaci spremljene postavke. Molimo unesite ponovo!", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userSettingsForm.ShowDialog();
            }
        }
    }
}