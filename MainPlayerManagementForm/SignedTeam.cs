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
    public partial class SignedTeam : Form
    {
        //Display players' signed team when user clicks on "All Players" row
        public SignedTeam(Team team)
        {
            try
            {
                InitializeComponent();
                var row = new string[] { team.TeamName, team.Ground, team.Coach, team.YearFounded, team.Region };
                var lvi = new ListViewItem(row);
                lvi.Tag = team;
                listViewSignedTeam.Items.Add(lvi);
                listViewSignedTeam.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                ErrorHandling.somethingWentWrongMessage();
            }
        }
    }
}
