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
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMember = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMember = new List<PersonModel>();
        private ITeamRequester callingForm;

        public CreateTeamForm(ITeamRequester caller, TeamModel tm)
        {
            InitializeComponent();

            callingForm = caller;

            WireupLists(tm);
        }

        private void WireupLists(TeamModel tm)
        {
            if(tm == null)
            {
                selectTeamMemberDropDown.DataSource = null;
                selectTeamMemberDropDown.DataSource = availableTeamMember;
                selectTeamMemberDropDown.DisplayMember = "FullName";

                teamMembersListBox.DataSource = null;
                teamMembersListBox.DataSource = selectedTeamMember;
                teamMembersListBox.DisplayMember = "FullName";
            } 
            else
            {
                selectTeamMemberDropDown.Enabled = false;
                addMemberButton.Enabled = false;
                addNewMemberGroupBox.Enabled = false;
                removeSelectedMemberButton.Enabled = false;
                createTeamButton.Enabled = false;

                teamNameValue.Text = tm.TeamName;
                teamMembersListBox.DataSource = null;
                teamMembersListBox.DataSource = tm.TeamMembers;
                teamMembersListBox.DisplayMember = "FullName";
            }
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firsNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellPhoneNumber = cellphoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMember.Add(p);

                WireupLists(null);

                firsNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all the fields.");
            }
        }

        private bool ValidateForm()
        {
            if (firsNameValue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (emailValue.Text.Length == 0)
            {
                return false;
            }
            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMember.Remove(p);
                selectedTeamMember.Add(p);

                WireupLists(null);
            }
        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMember.Remove(p);
                availableTeamMember.Add(p);

                WireupLists(null);
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMember;

            GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);

            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            selectTeamMemberDropDown.Enabled = true;
            addMemberButton.Enabled = true;
            addNewMemberGroupBox.Enabled = true;
            removeSelectedMemberButton.Enabled = true;
            createTeamButton.Enabled = true;

            selectTeamMemberDropDown.DataSource = null;
            selectTeamMemberDropDown.DataSource = availableTeamMember;
            selectTeamMemberDropDown.DisplayMember = "FullName";
        }
    }
}
