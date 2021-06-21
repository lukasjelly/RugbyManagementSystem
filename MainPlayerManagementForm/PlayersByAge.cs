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
    public partial class PlayersByAge : Form
    {
        //Displays players of age selected in FormMain "textBoxAge"
        public PlayersByAge(List<Player> playersByAge)
        {
            try
            {
                InitializeComponent();
                listViewPlayersByAge.Items.Clear();
                foreach (var player in playersByAge)
                {
                    var row = new string[] { player.Id, player.PlayerName, player.Dob, player.Height, player.Weight, player.BirthPlace, player.SignedTeam };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = player;
                    listViewPlayersByAge.Items.Add(lvi);
                }
                listViewPlayersByAge.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
        }
    }
}
