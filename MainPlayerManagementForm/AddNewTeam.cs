using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamClass;

namespace MainPlayerManagementForm
{
    public partial class AddNewTeam : Form
    {
        List<Team> allTeamsAddNewTeam = new List<Team>();
        public AddNewTeam(List<Team> allTeams)
        {
            InitializeComponent();
            allTeamsAddNewTeam = allTeams;
        }

        //Adds new team when user clicks submit
        private void buttonSubmitNewTeam_Click(object sender, EventArgs e)
        {
            try
            {
                //Check all fields have input
                if (!ErrorHandling.inputDetected(textBoxName.Text)) { return; }
                if (!ErrorHandling.inputDetected(textBoxGround.Text)) { return; }
                if (!ErrorHandling.inputDetected(textBoxCoach.Text)) { return; }
                if (!ErrorHandling.inputDetected(maskedTextBoxYearFounded.Text)) { return; }
                if (!ErrorHandling.inputDetected(textBoxRegion.Text)) { return; }

                //Check team is unique
                foreach (var team in allTeamsAddNewTeam)
                {
                    if (string.Equals(team.TeamName.ToLower(), textBoxName.Text.ToLower()))
                    {
                        ErrorHandling.genericErrorMessage(string.Format("Team \"{0}\" already in system.\nEnter unique team Name", textBoxName.Text));
                        return;
                    }
                }

                //Check year is correct format
                if (maskedTextBoxYearFounded.Text.Count() < 4)
                {
                    ErrorHandling.genericErrorMessage(string.Format("Year \"{0}\" has incorrect format", maskedTextBoxYearFounded.Text));
                    return;
                }

                allTeamsAddNewTeam.Add(new Team(textBoxName.Text.Trim(), textBoxGround.Text.Trim(), textBoxCoach.Text.Trim(), maskedTextBoxYearFounded.Text.Trim(), textBoxRegion.Text.Trim()));
                this.Close();
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
        }


        //Returns team list with newly added team
        public List<Team> returnNewTeams()
        {
            return allTeamsAddNewTeam;
        }
    }
}
