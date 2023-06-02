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
        string favouritePlayersFilePath = Path.Combine(path, "favPlayers.txt");
        string settingPath = Path.Combine(path, "settings.txt");

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
                File.Delete(favouritePlayersFilePath);
            }
            else
            {
                spInitialSettings.Visibility = Visibility.Collapsed;
            }
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
            spFavouritePlayers.Visibility = Visibility.Visible;
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

            List<Player> players = repo.LoadPlayers();
            foreach (Player player in players)
            {
                cbFavouritePLayers.Items.Add(player.GetName());
            }
            cbFavouritePLayers.SelectedIndex = 0;
        }

        private void btnSaveFavouritePlayer_Click(object sender, RoutedEventArgs e)
        {
            spFavouritePlayers.Visibility = Visibility.Collapsed;

            List<string> SelectedFavouritePlayers = new List<string>();
            try
            {
                SelectedFavouritePlayers.Add(cbFavouritePLayers.SelectedItem.ToString());

                repo.SaveFavouritePLayers(SelectedFavouritePlayers, favouritePlayersFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pogreska pri spremanju podataka: {ex.Message}");
            }
        }
    }
}
