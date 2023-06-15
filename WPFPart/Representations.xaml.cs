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
        TeamDetails teamDetails = new TeamDetails();


        public Representations()
        {
            InitializeComponent();
            Loaded += Representations_Loaded;

        }

        private void Representations_Loaded(object sender, RoutedEventArgs e)
        {
            Init();
            FillOtherTeamsCombobox();
        }

        private void FillOtherTeamsCombobox()
        {
            List<Match> matches = repo.LoadMatches(ExtractCountryCode(tbSelectedFavouriteTeam.Text));
            cbOtherTeam.Items.Clear();
            foreach (Match match in matches)
            {
                if (match.GetHomeCountryNameAndCode() == tbSelectedFavouriteTeam.Text)
                {
                    cbOtherTeam.Items.Add(match.GetAwayCountryNameAndCode());
                }
                else
                {
                    cbOtherTeam.Items.Add(match.GetHomeCountryNameAndCode());
                }
            }
            cbOtherTeam.SelectedIndex = 0;
        }

        private void Init()
        {
            List<Team> teams = repo.LoadTeams();
            cbFavouriteTeam.Items.Clear();

            foreach (var team in teams)
            {
                cbFavouriteTeam.Items.Add(team.FillComboBox());
            }

            cbFavouriteTeam.SelectedIndex = 0;
            cbOtherTeam.SelectedIndex = 0;
            tbSelectedFavouriteTeam.Text = repo.GetCountry() + " (" + repo.GetFifaCode() + ")";
        }

        private void cbFavouriteTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbSelectedFavouriteTeam.Text = cbFavouriteTeam.SelectedItem.ToString();
            FillOtherTeamsCombobox();
        }

        private void cbOtherTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbOtherTeam.SelectedItem != null)
            {
                tbOtherTeam.Text = cbOtherTeam.SelectedItem.ToString();
                SetMatchResult();
            }
        }

        private void SetMatchResult()
        {
            tbMatchResult.Text = string.Empty;

            string homeTeam = tbSelectedFavouriteTeam.Text;
            string awayTeam = tbOtherTeam.Text;

            List<Match> matches = repo.LoadMatches(ExtractCountryCode(homeTeam));

            foreach (Match match in matches)
            {
                if ((match.GetHomeCountryNameAndCode() == homeTeam && match.GetAwayCountryNameAndCode() == awayTeam) ||
                    (match.GetHomeCountryNameAndCode() == awayTeam && match.GetAwayCountryNameAndCode() == homeTeam))
                {
                    tbMatchResult.Text = match.ToString();
                    break;
                }
            }
        }

        public string ExtractCountryCode(string input)
        {
            int startIndex = input.IndexOf("(") + 1;
            int endIndex = input.IndexOf(")");

            if (startIndex >= 0 && endIndex >= 0 && endIndex > startIndex)
            {
                return input.Substring(startIndex, endIndex - startIndex);
            }

            return string.Empty;
        }

        private void btnTeamDetails_Click(object sender, RoutedEventArgs e)
        {
            mainGrid.Children.Add(teamDetails);

            List<Team> teams = repo.LoadTeams();
            foreach (Team team in teams)
            {
                if (team.FillComboBox() == cbFavouriteTeam.SelectedItem.ToString())
                {
                    teamDetails.DisplayTeam(team);
                    break;
                }
            }
        }

        private void btnOtherTeamDetails_Click(object sender, RoutedEventArgs e)
        {
            mainGrid.Children.Add(teamDetails);

            List<Team> teams = repo.LoadTeams();
            foreach (Team team in teams)
            {
                if (team.FillComboBox() == cbOtherTeam.SelectedItem.ToString())
                {
                    teamDetails.DisplayTeam(team);
                    break;
                }
            }
        }
    }
}
