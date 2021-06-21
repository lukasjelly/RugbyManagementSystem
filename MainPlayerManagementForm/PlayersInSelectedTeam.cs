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

namespace MainPlayerManagementForm
{
    public partial class PlayersInSelectedTeam : Form
    {
        //Displays players in selected team in FormMain. Achieved by clicking on team name in listViewTeams
        public PlayersInSelectedTeam(List<Player> players)
        {
            try
            {
                InitializeComponent();
                listViewPlayersInTeam.Items.Clear();
                foreach (var player in players)
                {
                    var row = new string[] { player.Id, player.PlayerName, player.Dob, player.Height, player.Weight, player.BirthPlace, player.SignedTeam };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = player;
                    listViewPlayersInTeam.Items.Add(lvi);
                }
                listViewPlayersInTeam.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
        }
    }
}
