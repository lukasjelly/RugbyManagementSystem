
namespace PlayersInTeam
{
    partial class PlayersInSelectedTeam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewPlayers = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Height = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlaceOfBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeamSigned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelPlayersInSelectedTeam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewPlayers
            // 
            this.listViewPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.PlayerName,
            this.Dob,
            this.Height,
            this.Weight,
            this.PlaceOfBirth,
            this.TeamSigned});
            this.listViewPlayers.FullRowSelect = true;
            this.listViewPlayers.GridLines = true;
            this.listViewPlayers.HideSelection = false;
            this.listViewPlayers.Location = new System.Drawing.Point(12, 41);
            this.listViewPlayers.Name = "listViewPlayers";
            this.listViewPlayers.Size = new System.Drawing.Size(457, 397);
            this.listViewPlayers.TabIndex = 2;
            this.listViewPlayers.UseCompatibleStateImageBehavior = false;
            this.listViewPlayers.View = System.Windows.Forms.View.Details;
            this.listViewPlayers.Visible = false;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 43;
            // 
            // PlayerName
            // 
            this.PlayerName.Text = "Name";
            // 
            // Dob
            // 
            this.Dob.Text = "Date of Birth";
            this.Dob.Width = 72;
            // 
            // Height
            // 
            this.Height.Text = "Height";
            // 
            // Weight
            // 
            this.Weight.Text = "Weight";
            // 
            // PlaceOfBirth
            // 
            this.PlaceOfBirth.Text = "Place of Birth";
            this.PlaceOfBirth.Width = 80;
            // 
            // TeamSigned
            // 
            this.TeamSigned.Text = "Team Signed";
            this.TeamSigned.Width = 77;
            // 
            // labelPlayersInSelectedTeam
            // 
            this.labelPlayersInSelectedTeam.AutoSize = true;
            this.labelPlayersInSelectedTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayersInSelectedTeam.Location = new System.Drawing.Point(122, 18);
            this.labelPlayersInSelectedTeam.Name = "labelPlayersInSelectedTeam";
            this.labelPlayersInSelectedTeam.Size = new System.Drawing.Size(213, 20);
            this.labelPlayersInSelectedTeam.TabIndex = 3;
            this.labelPlayersInSelectedTeam.Text = "Players In Selected Team";
            // 
            // PlayersInSelectedTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.labelPlayersInSelectedTeam);
            this.Controls.Add(this.listViewPlayers);
            this.Name = "PlayersInSelectedTeam";
            this.Text = "Players In Selected Team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPlayers;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader PlayerName;
        private System.Windows.Forms.ColumnHeader Dob;
        private System.Windows.Forms.ColumnHeader Height;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.ColumnHeader PlaceOfBirth;
        private System.Windows.Forms.ColumnHeader TeamSigned;
        private System.Windows.Forms.Label labelPlayersInSelectedTeam;
    }
}

