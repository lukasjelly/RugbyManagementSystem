
namespace MainPlayerManagementForm
{
    partial class PlayersByAge
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
            this.listViewPlayersByAge = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlaceOfBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeamSigned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewPlayersByAge
            // 
            this.listViewPlayersByAge.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.PlayerName,
            this.Dob,
            this.playerHeight,
            this.Weight,
            this.PlaceOfBirth,
            this.TeamSigned});
            this.listViewPlayersByAge.FullRowSelect = true;
            this.listViewPlayersByAge.GridLines = true;
            this.listViewPlayersByAge.HideSelection = false;
            this.listViewPlayersByAge.Location = new System.Drawing.Point(12, 12);
            this.listViewPlayersByAge.Name = "listViewPlayersByAge";
            this.listViewPlayersByAge.Size = new System.Drawing.Size(509, 159);
            this.listViewPlayersByAge.TabIndex = 2;
            this.listViewPlayersByAge.UseCompatibleStateImageBehavior = false;
            this.listViewPlayersByAge.View = System.Windows.Forms.View.Details;
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
            // playerHeight
            // 
            this.playerHeight.Text = "Height";
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
            // PlayersByAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 200);
            this.Controls.Add(this.listViewPlayersByAge);
            this.Name = "PlayersByAge";
            this.Text = "Players By Selected Age";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listViewPlayersByAge;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader PlayerName;
        private System.Windows.Forms.ColumnHeader Dob;
        private System.Windows.Forms.ColumnHeader playerHeight;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.ColumnHeader PlaceOfBirth;
        private System.Windows.Forms.ColumnHeader TeamSigned;
    }
}