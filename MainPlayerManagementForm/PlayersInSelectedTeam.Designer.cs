
namespace MainPlayerManagementForm
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
            this.listViewPlayersInTeam = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Height = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlaceOfBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeamSigned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewPlayersInTeam
            // 
            this.listViewPlayersInTeam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.PlayerName,
            this.Dob,
            this.Height,
            this.Weight,
            this.PlaceOfBirth,
            this.TeamSigned});
            this.listViewPlayersInTeam.FullRowSelect = true;
            this.listViewPlayersInTeam.GridLines = true;
            this.listViewPlayersInTeam.HideSelection = false;
            this.listViewPlayersInTeam.Location = new System.Drawing.Point(12, 41);
            this.listViewPlayersInTeam.Name = "listViewPlayersInTeam";
            this.listViewPlayersInTeam.Size = new System.Drawing.Size(457, 397);
            this.listViewPlayersInTeam.TabIndex = 2;
            this.listViewPlayersInTeam.UseCompatibleStateImageBehavior = false;
            this.listViewPlayersInTeam.View = System.Windows.Forms.View.Details;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Players In Selected Team";
            // 
            // PlayersInSelectedTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewPlayersInTeam);
            this.Name = "PlayersInSelectedTeam";
            this.Text = "Players In Selected Team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader PlayerName;
        private System.Windows.Forms.ColumnHeader Dob;
        private System.Windows.Forms.ColumnHeader Height;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.ColumnHeader PlaceOfBirth;
        private System.Windows.Forms.ColumnHeader TeamSigned;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView listViewPlayersInTeam;
    }
}