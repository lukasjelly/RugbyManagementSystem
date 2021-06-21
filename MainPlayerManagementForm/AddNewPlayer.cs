using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayerClass;
using TeamClass;

namespace MainPlayerManagementForm
{
    public partial class AddNewPlayer : Form
    {
        public List<Team> allTeams { get; set; }
        List<Player> allPlayersAddNewPlayer = new List<Player>();
        public AddNewPlayer(List<Player> allPlayers)
        {
            InitializeComponent();
            allPlayersAddNewPlayer = allPlayers;
            toolTipDate.SetToolTip(maskedTextBoxDOB, "DD-MM-YYYY");
        }


        //When user has pressed submit button to add new player
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //Ensure all textboxes have input
                if (!ErrorHandling.inputDetected(textBoxID.Text)) { return; }
                if (!ErrorHandling.inputDetected(textBoxName.Text)) { return; }
                if (!ErrorHandling.inputDetected(maskedTextBoxDOB.Text)) { return; }
                if (!ErrorHandling.inputDetected(textBoxHeight.Text)) { return; }
                if (!ErrorHandling.inputDetected(textBoxWeight.Text)) { return; }
                if (!ErrorHandling.inputDetected(textBoxPlaceOfBirth.Text)) { return; }
                if (!ErrorHandling.inputDetected(textBoxSignedTeam.Text)) { return; }

                //check id is numeric
                if (!ErrorHandling.isTextNumeric(textBoxID.Text))
                {
                    ErrorHandling.dataNotNumericMessage("ID");
                    return;
                }

                //Check for unique ID
                foreach (var player in allPlayersAddNewPlayer)
                {
                    if (string.Equals(player.Id, textBoxID.Text))
                    {
                        ErrorHandling.genericErrorMessage(string.Format("ID \"{0}\" already in system.\nEnter unique ID", textBoxID.Text));
                        return;
                    }
                }

                //Check DOB is correct format
                if (maskedTextBoxDOB.Text.Count()<10){
                    ErrorHandling.genericErrorMessage(string.Format("Date \"{0}\" has incorrect format.\nPlease add leading zeros and ensure full date is entered", maskedTextBoxDOB.Text));
                    return;
                }

                //Check height is numeric
                if (!ErrorHandling.isTextNumeric(textBoxHeight.Text))
                {
                    ErrorHandling.dataNotNumericMessage("\"height\"");
                    return;
                }

                //Check weight is numeric
                if (!ErrorHandling.isTextNumeric(textBoxWeight.Text))
                {
                    ErrorHandling.dataNotNumericMessage("weight");
                    return;
                }

                //Check place of birth is non numeric
                if (ErrorHandling.isTextNumeric(textBoxPlaceOfBirth.Text))
                {
                    ErrorHandling.dataNotAlphaMessage("place of birth");
                    return;
                }

                //Check team exists
                bool foundTeam = false;
                foreach(var team in allTeams)
                {
                    if(string.Equals(team.TeamName, textBoxSignedTeam.Text.Trim())){
                        foundTeam = true;
                    }
                }
                if (!foundTeam)
                {
                    ErrorHandling.genericErrorMessage(string.Format("Team \"{0}\" not found.\nAdd new team first", textBoxSignedTeam.Text.Trim()));
                    return;
                }

                allPlayersAddNewPlayer.Add(new Player(textBoxID.Text.Trim(), textBoxName.Text.Trim(), maskedTextBoxDOB.Text.Trim(), textBoxHeight.Text.Trim(), textBoxWeight.Text.Trim(), textBoxPlaceOfBirth.Text.Trim(), textBoxSignedTeam.Text.Trim()));
                this.Close();
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
        }


        //Return player list with newly added player
        public List<Player> returnNewPlayers()
        {
            return allPlayersAddNewPlayer;
        }
    }
}
