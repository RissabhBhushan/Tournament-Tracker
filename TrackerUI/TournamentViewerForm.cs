using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();


        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();         

            tournament = tournamentModel;
            try
            {
                tournament.OnTournamentComplete += Tournament_OnTournamentComplete;

                WireUpLists();

                LoadFormData();

                LoadRounds();

                WireUpLists();
            }
            catch(Exception )
            {
                MessageBox.Show("Please select valid Tournament!");
            }
           
        }

        private void Tournament_OnTournamentComplete(object sender, DateTime e)
        {
            this.Close();
        }

        private void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;
        }

        private void LoadRounds()
        {
            rounds.Clear();
            rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }

            LoadMatchups(1);
        }

        private void WireUpLists()
        {
            roundDropDown.DataSource = rounds;
            matchupListBox.DataSource = selectedMatchups;
            matchupListBox.DisplayMember = "DisplayName";
        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropDown.SelectedItem);
        }

        private void LoadMatchups(int round)
        {
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups = new BindingList<MatchupModel>();
                    foreach (MatchupModel m in matchups)
                    {
                        if(m.Winner.Id == 0 || !unplayedOnlyCheckBox.Checked)
                        {
                            selectedMatchups.Add(m);
                        }                        
                    }
                }
            }
            WireUpLists();
            if(selectedMatchups.Count > 0)
            {
                LoadMatchup(selectedMatchups.First());
            }

            DisplayMathcupInfo();
        }

        private void DisplayMathcupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);

            teamOneName.Visible = isVisible;
            teamOneScoreLabel.Visible = isVisible;
            teamOneScoreText.Visible = isVisible;
            teamTwoName.Visible = isVisible;
            teamTwoScoreLabel.Visible = isVisible;
            teamTwoScoreText.Visible = isVisible;
            versusLabel.Visible = isVisible;
            scoreButton.Visible = isVisible;
        }

        private void LoadMatchup(MatchupModel m)
        {
            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        teamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                        teamOneScoreText.Text = m.Entries[0].Score.ToString();

                        teamTwoName.Text = "<bye>";
                        teamTwoScoreText.Text = "0";
                    }
                    else
                    {
                        teamOneName.Text = "Not yet Set";
                        teamOneScoreText.Text = "";
                    }
                }
                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        teamTwoName.Text = m.Entries[1].TeamCompeting.TeamName;
                        teamTwoScoreText.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        teamTwoName.Text = "Not yet Set";
                        teamTwoScoreText.Text = "";
                    }
                }
            }
        }

        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup((MatchupModel)matchupListBox.SelectedItem);
        }

        private void unplayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropDown.SelectedItem);
        }

        private string ValidateData()
        {
            string output = "";

            double teamOneScore = 0;
            double teamTwoScore = 0;

            bool scoreOneValid = double.TryParse(teamOneScoreText.Text, out teamOneScore);
            bool scoreTwoValid = double.TryParse(teamTwoScoreText.Text, out teamTwoScore);

            if(!scoreOneValid)
            {
                output = "The Score One value is not a valid number";
            }
            else if (!scoreTwoValid)
            {
                output = "The Score Two value is not a valid number";
            }
            else if (teamOneScore == 0 && teamTwoScore == 0)
            {
                output = "No Score is entered for either team";
            }
            else if(teamOneScore == teamTwoScore)
            {
                output = "Tie games are not allowed!";
            }

            return output;
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateData();
            if(errorMessage.Length > 0)
            {
                MessageBox.Show($"Input Error: { errorMessage }");
                return;
            }

            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;

            foreach (MatchupEntryModel me in m.Entries)
            {
                for (int i = 0; i < m.Entries.Count; i++)
                {
                    if (i == 0)
                    {
                        if (m.Entries[0].TeamCompeting != null)
                        {
                            bool scoreValid = double.TryParse(teamOneScoreText.Text, out teamOneScore);

                            if (scoreValid)
                            {
                                m.Entries[0].Score = teamOneScore;
                            }
                            else
                            {
                                MessageBox.Show("Please enter valid Score for Team 1!");
                                return  ;
                            }
                        }                      
                    }
                    if (i == 1)
                    {
                        bool scoreValid = double.TryParse(teamTwoScoreText.Text, out teamTwoScore);

                        if (scoreValid)
                        {
                            m.Entries[1].Score = teamTwoScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid Score for Team 2!");
                            return;
                        }
                    }
                }
            }
            try
            {
                TournamentLogic.UpdateTournamentResults(tournament);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"The application had the following Error: { ex.Message }");
                return;
            }
            

            LoadMatchups((int)roundDropDown.SelectedItem);

        }
    }
}