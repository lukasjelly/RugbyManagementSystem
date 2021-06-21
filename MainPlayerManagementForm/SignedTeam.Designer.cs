
namespace MainPlayerManagementForm
{
    partial class SignedTeam
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
            this.listViewSignedTeam = new System.Windows.Forms.ListView();
            this.teamName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamGround = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamCoach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamYearFounded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewSignedTeam
            // 
            this.listViewSignedTeam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.teamName,
            this.teamGround,
            this.teamCoach,
            this.teamYearFounded,
            this.teamRegion});
            this.listViewSignedTeam.GridLines = true;
            this.listViewSignedTeam.HideSelection = false;
            this.listViewSignedTeam.Location = new System.Drawing.Point(12, 12);
            this.listViewSignedTeam.Name = "listViewSignedTeam";
            this.listViewSignedTeam.Size = new System.Drawing.Size(423, 67);
            this.listViewSignedTeam.TabIndex = 4;
            this.listViewSignedTeam.UseCompatibleStateImageBehavior = false;
            this.listViewSignedTeam.View = System.Windows.Forms.View.Details;
            // 
            // teamName
            // 
            this.teamName.Text = "Name";
            // 
            // teamGround
            // 
            this.teamGround.Text = "Ground";
            // 
            // teamCoach
            // 
            this.teamCoach.Text = "Coach";
            // 
            // teamYearFounded
            // 
            this.teamYearFounded.Text = "Year Founded";
            this.teamYearFounded.Width = 85;
            // 
            // teamRegion
            // 
            this.teamRegion.Text = "Region";
            // 
            // SignedTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 87);
            this.Controls.Add(this.listViewSignedTeam);
            this.Name = "SignedTeam";
            this.Text = "Signed Team";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listViewSignedTeam;
        private System.Windows.Forms.ColumnHeader teamName;
        private System.Windows.Forms.ColumnHeader teamGround;
        private System.Windows.Forms.ColumnHeader teamCoach;
        private System.Windows.Forms.ColumnHeader teamYearFounded;
        private System.Windows.Forms.ColumnHeader teamRegion;
    }
}