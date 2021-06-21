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
    public partial class PlayersByBirthPlace : Form
    {
        //Displays players of birthplace entered in FormMain richTextBoxBirthPlace
        public PlayersByBirthPlace(List<Player> allPlayersByBirthPlace)
        {
            try
            {
                InitializeComponent();
                foreach (var player in allPlayersByBirthPlace)
                {
                    var row = new string[] { player.Id, player.PlayerName, player.Dob, player.Height, player.Weight, player.BirthPlace, player.SignedTeam };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = player;
                    listViewPlayersByBirthPlace.Items.Add(lvi);
                }
                listViewPlayersByBirthPlace.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
        }
    }
}
