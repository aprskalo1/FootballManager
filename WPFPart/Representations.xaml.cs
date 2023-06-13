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
    public partial class Representations : UserControl
    {
        private static string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).Parent.FullName;
        //string favouritePlayersFilePath = Path.Combine(path, "favPlayers.txt");
        string settingPath = Path.Combine(path, "settings.txt");
        string windowSettingPath = Path.Combine(path, "windowSettingPath.txt");

        private IRepo repo = RepoFactory.GetRepo();

        public Representations()
        {
            InitializeComponent();
            Loaded += Representations_Loaded;

        }

        private void Representations_Loaded(object sender, RoutedEventArgs e)
        {
            Init();
        }

        private void Init()
        {
            List<Team> teams = repo.LoadTeams();
            cbFavouriteTeam.Items.Clear();

            foreach (var team in teams)
            {
                cbFavouriteTeam.Items.Add(team.FillComboBox());
                cbOtherTeam.Items.Add(team.FillComboBox());
            }

            cbFavouriteTeam.SelectedIndex = 0;
            cbOtherTeam.SelectedIndex = 0;
            tbSelectedFavouriteTeam.Text = repo.GetCountry() + " (" + repo.GetFifaCode() + ")";
        }

        private void cbFavouriteTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbSelectedFavouriteTeam.Text = cbFavouriteTeam.SelectedItem.ToString();
        }

        private void cbOtherTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbOtherTeam.Text = cbOtherTeam.SelectedItem.ToString();
        }
    }
}
