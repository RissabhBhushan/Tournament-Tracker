using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;
using TrackerUI;

namespace TrackerLibrary
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();

            WireupLists();
        }

        private void WireupLists()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireupLists();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //Call the CreatePrizeForm
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            //Take teh PrizeModel and put it into our list of selected Prize
            selectedPrizes.Add(model);

            WireupLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);

            WireupLists();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this, null); 

            frm.Show();
        }

        private void removeSelectedTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;

            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireupLists();
            }
        }

        private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);

                WireupLists();
            }            
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            // Validate data
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(entryFeeValue.Text, out fee);

            if(!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid Entry Fee", "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create tournament model
            TournamentModel tm = new TournamentModel();
            tm.TournamentName = tournamentNameValue.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            TournamentLogic.CreateRounds(tm);

            // Create tournament entry
            // Create prizes entry
            // create all of the team entry
            GlobalConfig.Connection.CreateTournament(tm);

            tm.AlertToNewRound();
            
            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
            this.Close();
        }

        private void teamViewButton_Click(object sender, EventArgs e)
        {

            TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;
            if(t == null)
            {
                MessageBox.Show("Please select a Team!");
            }
            else
            {
                CreateTeamForm team = new CreateTeamForm(this, t);
                team.Show();
            }            
        }
    }
}
