using DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace WPFPart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).Parent.FullName;
        string settingPath = Path.Combine(path, "settings.txt");
        string windowSettingPath = Path.Combine(path, "windowSettingPath.txt");

        Representations representations = new Representations();

        IRepo repo = RepoFactory.GetRepo();

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(settingPath) || new FileInfo(settingPath).Length == 0)
            {
                FillTheComboboxes();
                Init();
            }
            else
            {
                ShowRepresentationsPage();
            }
        }

        private void ShowRepresentationsPage()
        {
            mainGrid.Children.Add(representations);
        }

        private void Init()
        {
            cbScreenType.SelectedIndex = 0;
        }

        private void FillTheComboboxes()
        {
            cbLanguage.Items.Add("Hrvatski");
            cbLanguage.Items.Add("English");
            cbLanguage.SelectedIndex = 0;

            cbWorldCupType.Items.Add("Musko");
            cbWorldCupType.Items.Add("Zensko");
            cbWorldCupType.SelectedIndex = 0;
        }

        private void btnSubmitSettings_Click(object sender, RoutedEventArgs e)
        {
            spInitialSettings.Visibility = Visibility.Collapsed;
            spFavouriteTeam.Visibility = Visibility.Visible;

            try
            {
                string language = cbLanguage.SelectedItem.ToString();
                string worldCupType = cbWorldCupType.SelectedItem.ToString();

                if (rbFullScreen.IsChecked == true)
                {
                    repo.SaveWindowSettings("fullscreen", windowSettingPath);
                }
                else
                {
                    string screenType = (cbScreenType.SelectedItem as ComboBoxItem)?.Content.ToString();
                    repo.SaveWindowSettings(screenType, windowSettingPath);
                }

                repo.SaveSettings(language, worldCupType, settingPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pogreska pri spremanju podataka: {ex.Message}");
            }

            List<Team> teams = repo.LoadTeams();
            foreach (Team team in teams)
            {
                cbFavouriteTeam.Items.Add(team.FillComboBox());
            }
            cbFavouriteTeam.SelectedIndex = 0;
        }

        private void btnSaveFavouriteTeam_Click(object sender, RoutedEventArgs e)
        {
            spFavouriteTeam.Visibility = Visibility.Collapsed;

            try
            {
                string favouriteTeam = cbFavouriteTeam.SelectedItem.ToString();

                repo.SaveFavouriteTeam(favouriteTeam, settingPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pogreska pri spremanju podataka: {ex.Message}");
            }

            spInitialSettings.Visibility = Visibility.Visible;
            cbFavouriteTeam.Items.Clear();
            ShowRepresentationsPage();
        }
    }
}
