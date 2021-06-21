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
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

//Summary
//Author: Lukas Jehle
//Massey Student ID: 20009320
//Software Purpose: to faciliate management of rugby teams and players


namespace MainPlayerManagementForm
{

    public partial class FormMain : Form
    {
        public List<Player> allPlayers = new List<Player>(); //A list that stores intances of Player class as elements
        public List<Team> allTeams = new List<Team>(); //A List that stores instances of Team class as elements

        public FormMain()
        {
            InitializeComponent();

            //Loads allPlayers list with data from default filename
            allPlayers = ReadPlayers("Players.txt");


            //Load players from allPlayers list into ListView that then displays players in FormMain
            LoadPlayersIntoListView(allPlayers);


            //Loads allTeams list woth data from default filename
            allTeams = ReadTeams("Teams.txt");


            //Load teams from allTeams list into ListView that then displays teams in FormMain
            LoadTeamsIntoListView(allTeams);


            //Load height and weight data in chart from allplayers class
            LoadHeightWeightIntoChart(allPlayers);


            //Load height and weight data from player class into chart
            LoadAgesIntoChart(allPlayers);
        }

        /**************************************************************************************/
        /**********************Functions to do with loading and saving data********************/
        /**************************************************************************************/

        //Loads allPlayers list with data from given filename
        public List<Player> ReadPlayers(string fileName)
        {
            List<Player> Players = new List<PlayerClass.Player>();
            try
            {
                using (FileStream fStream = File.OpenRead(fileName))
                {
                    StreamReader reader = new StreamReader(fStream);
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        List<string> words = new List<string>(line.Split(';'));
                        Players.Add(new Player(words[0].Trim(), words[1].Trim(), words[2].Trim(), words[3].Trim(), words[4].Trim(), words[5].Trim(), words[6].Trim()));

                    }
                }
                return Players;
            }
            catch
            {
                return Players;
            }
        }


        //Load players from allPlayers list into ListView that then displays players in FormMain
        public void LoadPlayersIntoListView(List<Player> players)
        {
            try
            {
                listViewPlayers.Items.Clear();
                foreach (var player in players)
                {
                    var row = new string[] { player.Id, player.PlayerName, player.Dob, player.Height, player.Weight, player.BirthPlace, player.SignedTeam };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = player;
                    listViewPlayers.Items.Add(lvi);
                }
                listViewPlayers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
        }


        //Loads allTeams list with data from given filename
        public List<TeamClass.Team> ReadTeams(string fileName)
        {
            List<TeamClass.Team> teams = new List<TeamClass.Team>();
            try
            {
                using (FileStream fStream = File.OpenRead(fileName))
                {
                    StreamReader reader = new StreamReader(fStream);
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        List<string> words = new List<string>(line.Split(';'));
                        List<string> teamPlayersId = new List<string>();
                        if (words.Count > 5)
                        {
                            for (int i = 5; i < words.Count - 1; i++)
                            {
                                teamPlayersId.Add(words[i]);
                            }
                            teams.Add(new Team(words[0].Trim(), words[1].Trim(), words[2].Trim(), words[3].Trim(), words[4].Trim(), teamPlayersId));

                        }
                        else
                        {
                            teams.Add(new Team(words[0].Trim(), words[1].Trim(), words[2].Trim(), words[3].Trim(), words[4].Trim()));
                        }
                    }
                }
                return teams;
            }
            catch
            {
                return teams;
            }
            
        }


        //Load teams from allTeams list into ListView that then displays teams in FormMain
        public void LoadTeamsIntoListView(List<TeamClass.Team> teams)
        {
            try
            {
                listViewTeams.Items.Clear();
                foreach (var team in teams)
                {
                    var row = new string[] { team.TeamName, team.Ground, team.Coach, team.YearFounded, team.Region };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = team;
                    listViewTeams.Items.Add(lvi);
                }
                listViewTeams.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
        }
       

        //Load height and weight data from player class into chart
        public void LoadHeightWeightIntoChart(List<Player> players)
        {
            try
            {
                chartHeightWeight.Series.Clear();
                chartHeightWeight.Series.Add("Height (cm)");
                chartHeightWeight.Series.Add("Weight (kg)");
                chartHeightWeight.Titles.Add("Height and Weight of Players");
                chartHeightWeight.ChartAreas[0].AxisX.Title = "Player ID";
                chartHeightWeight.ChartAreas[0].AxisY.Title = "KG / CM";

                foreach (var player in players)
                {
                    chartHeightWeight.Series["Height (cm)"].Points.AddXY(player.Id, player.Height);
                    chartHeightWeight.Series["Weight (kg)"].Points.AddXY(player.Id, player.Weight);
                }
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
        }


        //Return current age from date of birth
        public int currentAge(string DOB)
        {
            try
            {
                var today = DateTime.Today;
                DateTime birthdate = DateTime.Parse(DOB);
                int age = Convert.ToInt32((today.Subtract(birthdate).TotalDays) / 365);
                return age;
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
                return -1;
            }
        }

        //Load age data from player class into chart
        public void LoadAgesIntoChart(List<Player> players)
        {
            try
            {
                //Define chart titles
                chartAgeGroup.Series.Clear();
                chartAgeGroup.ChartAreas[0].AxisX.Title = "Age";
                chartAgeGroup.ChartAreas[0].AxisY.Title = "Frequency";
                chartAgeGroup.Titles.Add("Frequency of Ages of All Players");
                chartAgeGroup.ChartAreas[0].AxisX.Interval = 10;
                chartAgeGroup.ChartAreas[0].AxisY.Interval = 1; // can only be integer frequency
                var dataPointSeries = new Series
                {
                    Name = "Age Frequency",
                    ChartType = SeriesChartType.Column
                };

                //Determine max age
                int max = 0;
                foreach (var player in allPlayers)
                {
                    if (currentAge(player.Dob) > max) { max = currentAge(player.Dob); }
                }
                chartAgeGroup.ChartAreas[0].AxisX.Maximum = max+5; //set max age of x axis to remove unused graph area

                int[] ageCount = new int[100]; //to store count of ages
                foreach (var player in allPlayers)
                {
                    int playerAge = currentAge(player.Dob);
                    ageCount[playerAge]++;
                }

                //Plot on graph
                for (int i = 1; i < 100; i++)
                {
                    dataPointSeries.Points.AddXY(i, ageCount[i]);
                }
                chartAgeGroup.Series.Add(dataPointSeries);
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
        }


        //When user clicks File->Load->All Players, data from selected players file is loaded into allPlayers list
        public void LoadAllPlayers_Click(object sender, EventArgs e)
        {
            try
            {
                List<PlayerClass.Player> allPlayers = new List<PlayerClass.Player>();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fStream = File.OpenRead(openFileDialog1.FileName))
                    {
                        StreamReader reader = new StreamReader(fStream);
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            List<string> words = new List<string>(line.Split(';'));
                            allPlayers.Add(new Player(words[0], words[1], words[2], words[3], words[4], words[5], words[6]));
                        }
                    }
                    LoadPlayersIntoListView(allPlayers);
                }
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
            
        }


        //When user clicks File->Load->All Teams, data from selected teams file is loaded into allTeams list
        private void LoadAllTeams_Click(object sender, EventArgs e)
        {
            try
            {
                List<TeamClass.Team> allTeams = new List<TeamClass.Team>();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fStream = File.OpenRead(openFileDialog1.FileName))
                    {
                        StreamReader reader = new StreamReader(fStream);
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            List<string> words = new List<string>(line.Split(';'));
                            List<string> teamPlayersId = new List<string>();
                            if (words.Count > 5)
                            {
                                for (int i = 5; i < words.Count - 1; i++)
                                {
                                    teamPlayersId.Add(words[i]);
                                }
                                allTeams.Add(new Team(words[0], words[1], words[2], words[3], words[4], teamPlayersId));

                            }
                            else
                            {
                                allTeams.Add(new Team(words[0], words[1], words[2], words[3], words[4]));
                            }
                        }
                    }
                    LoadTeamsIntoListView(allTeams);
                }
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
        }


        //When user clicks File->Save->All Players, data from allPlayers class is saved to text file
        private void SaveAllPlayers_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = "Players.txt";
                saveFile.Filter = "Text File | *.txt";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter myWriter = new StreamWriter(saveFile.FileName);
                    foreach (var player in allPlayers)
                    {
                        string line = player.Id + ";" + player.PlayerName + ";" + player.Dob + ";" + player.Height + ";" + player.Weight + ";" + player.BirthPlace + ";" + player.SignedTeam;
                        myWriter.WriteLine(line);
                    }
                    myWriter.Close();
                }
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
        }


        //When user clicks File->Save->All Teams, data from allTeams class is saved to text file
        private void SaveAllTeams_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = "Teams.txt";
                saveFile.Filter = "Text File | *.txt";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter myWriter = new StreamWriter(saveFile.FileName);
                    foreach (var team in allTeams)
                    {
                        string teamPlayers = "";
                        if (team.TeamPlayers != null)
                        {
                            foreach (var player in team.TeamPlayers)
                            {
                                teamPlayers = teamPlayers + player + ";";
                            }
                        }
                        string line = team.TeamName + ";" + team.Ground + ";" + team.Coach + ";" + team.YearFounded + ";" + team.Region + ";" + teamPlayers;
                        myWriter.WriteLine(line);
                    }
                    myWriter.Close();
                }
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
        }


        //When user clicks File->Save->All data
        private void allDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Write team data to default text file
                StreamWriter writeToTeams = new StreamWriter("Teams.txt");
                foreach (var team in allTeams)
                {
                    string teamPlayers = "";
                    if (team.TeamPlayers != null)
                    {
                        foreach (var player in team.TeamPlayers)
                        {
                            teamPlayers = teamPlayers + player + ";";
                        }
                    }
                    string line = team.TeamName + ";" + team.Ground + ";" + team.Coach + ";" + team.YearFounded + ";" + team.Region + ";" + teamPlayers;
                    writeToTeams.WriteLine(line);
                }
                writeToTeams.Close();

                //Write player data to default text file
                StreamWriter writeToPlayers = new StreamWriter("Player.txt");
                foreach(var player in allPlayers)
                {
                    string line = player.Id + ";" + player.PlayerName + ";" + player.Dob + ";" + player.Height + ";" + player.Weight + ";" + player.BirthPlace + ";" + player.SignedTeam;
                    writeToPlayers.WriteLine(line);
                }
                writeToPlayers.Close();
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
        }




        /**************************************************************************************/
        /**********************Functions to do with user interaction***************************/
        /**************************************************************************************/

        //When user clicks on team name in listViewTeams, display signed players
        private void listViewTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Player> playersInSelectedTeam = new List<Player>();
                if (listViewTeams.SelectedItems.Count > 0 && listViewTeams.SelectedItems.Count < listViewTeams.Items.Count)
                {
                    string team = listViewTeams.SelectedItems[0].Text;//Get name of team from selected item in All Teams ListView

                    //search for players that are in selected team and load into playersInSelectedTeam list
                    foreach (var player in allPlayers)
                    {
                        if (player.SignedTeam.Contains(team))
                        {
                            playersInSelectedTeam.Add(player);
                        }
                    }

                    if (playersInSelectedTeam.Count > 0)
                    {
                        PlayersInSelectedTeam myPlayersInSelectedTeam = new PlayersInSelectedTeam(playersInSelectedTeam);
                        myPlayersInSelectedTeam.ShowDialog();
                    }
                    else
                    {
                        ErrorHandling.genericErrorMessage("No signed players in selected team!");
                    }
                }
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
            
            
        }


        //When user clicks on player name in listViewPlayers, display signed team
        private void listViewPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //ensures only data in active cells is selected
                if (listViewPlayers.SelectedItems.Count > 0 && listViewPlayers.SelectedItems.Count < listViewPlayers.Items.Count)
                {
                    //get signed team of selected player
                    string team = allPlayers[listViewPlayers.SelectedItems[0].Index].SignedTeam.Trim();
                    bool found = false;
                    foreach (var teamItem in allTeams) //search for team in allTeams
                    {
                        if (teamItem.TeamName.Contains(team) && team != "")
                        {
                            SignedTeam playersSignedTeam = new SignedTeam(teamItem);
                            playersSignedTeam.ShowDialog();
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        ErrorHandling.genericErrorMessage("Player not signed to any team!");
                    }

                }
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
        }


        //When user wants to sign player to a team by clicking buttonSignToTeam
        private void buttonSignToTeam_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ErrorHandling.inputDetected(textBoxPlayerId.Text)) { return; }
                if (!ErrorHandling.inputDetected(textBoxTeamName.Text)) { return; }
                if (!ErrorHandling.isTextNumeric(textBoxPlayerId.Text)) {
                    ErrorHandling.dataNotNumericMessage("ID");
                    return; 
                }
                bool foundID = false;
                bool foundTeam = false;
                foreach (var player in allPlayers)
                {
                    if (player.Id.Contains(textBoxPlayerId.Text.Trim()))
                    {
                        foundID = true;
                        foreach(var team in allTeams)
                        {
                            bool teamExists = string.Equals(team.TeamName, textBoxTeamName.Text.Trim());
                            if (teamExists)
                            {
                                player.SignedTeam = textBoxTeamName.Text;
                                LoadPlayersIntoListView(allPlayers);
                                foundTeam = true;
                            }
                        }
                        
                    }
                }
                if (!foundID)
                {
                    ErrorHandling.genericErrorMessage(string.Format("Player \"{0}\" cannot be found", textBoxPlayerId.Text.Trim()));
                }
                if (!foundTeam)
                {
                    ErrorHandling.genericErrorMessage(string.Format("Team \"{0}\" cannot be found.\nPlease add new team first", textBoxTeamName.Text.Trim()));
                }
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
            
        }


        //When user wants to add a new player to system by clicking buttonAddNewPlayer
        private void buttonAddNewPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewPlayer myAddNewPlayer = new AddNewPlayer(allPlayers);
                myAddNewPlayer.allTeams = allTeams;
                myAddNewPlayer.ShowDialog();
                allPlayers = myAddNewPlayer.returnNewPlayers();
                LoadPlayersIntoListView(allPlayers);
                LoadHeightWeightIntoChart(allPlayers);
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
        }


        //When user wants to add a new team to system by clicking buttonAddNewTeam
        private void buttonAddNewTeam_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewTeam myAddNewTeam = new AddNewTeam(allTeams);
                myAddNewTeam.ShowDialog();
                allTeams = myAddNewTeam.returnNewTeams();
                LoadTeamsIntoListView(allTeams);
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
        }


        //When user wants to display all players of selected age in new list view
        private void buttonSearchAge_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ErrorHandling.inputDetected(textBoxAge.Text)) { return; }
                if (!ErrorHandling.isTextNumeric(textBoxAge.Text))
                {
                    ErrorHandling.dataNotNumericMessage("age");
                    return;
                }
                List<Player> allPlayersByAge = new List<Player>();
                foreach (var player in allPlayers)
                {
                    int playerAge = currentAge(player.Dob);
                    if (playerAge == Convert.ToInt32(textBoxAge.Text))
                    {
                        allPlayersByAge.Add(player);
                    }
                }
                if (allPlayersByAge.Count > 0)
                {
                    PlayersByAge myPlayerByAge = new PlayersByAge(allPlayersByAge);
                    myPlayerByAge.ShowDialog();
                }
                else
                {
                    ErrorHandling.genericErrorMessage(string.Format("Players {0} years of age not found", textBoxAge.Text));
                }
                
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
        }


        //When user wants to display all players of selected birth place in new list view
        private void buttonSearchBirthPlace_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ErrorHandling.inputDetected(richTextBoxBirthPlace.Text)) {  return;  }
                if (ErrorHandling.isTextNumeric(richTextBoxBirthPlace.Text)){
                    ErrorHandling.dataNotAlphaMessage("birth place");
                    return;
                }
                List<Player> allPlayersByBirthPlace = new List<Player>();
                foreach (var player in allPlayers)
                {
                    if (player.BirthPlace.Contains(richTextBoxBirthPlace.Text))
                    {
                        allPlayersByBirthPlace.Add(player);
                    }
                }
                if (allPlayersByBirthPlace.Count > 0)
                {
                    PlayersByBirthPlace myPlayersByBirthPlace = new PlayersByBirthPlace(allPlayersByBirthPlace);
                    myPlayersByBirthPlace.ShowDialog();
                }
                else
                {
                    ErrorHandling.genericErrorMessage(string.Format("Players born in {0} not found", richTextBoxBirthPlace.Text));
                }
                
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
           
        }
    }
}
