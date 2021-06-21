
namespace MainPlayerManagementForm
{
    partial class AddNewTeam
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
            this.groupBoxAddNewPlayer = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxYearFounded = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCoach = new System.Windows.Forms.TextBox();
            this.buttonSubmitNewTeam = new System.Windows.Forms.Button();
            this.textBoxRegion = new System.Windows.Forms.TextBox();
            this.labelRegion = new System.Windows.Forms.Label();
            this.labelCoach = new System.Windows.Forms.Label();
            this.labelYearFounded = new System.Windows.Forms.Label();
            this.textBoxGround = new System.Windows.Forms.TextBox();
            this.labelGround = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxAddNewPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddNewPlayer
            // 
            this.groupBoxAddNewPlayer.Controls.Add(this.maskedTextBoxYearFounded);
            this.groupBoxAddNewPlayer.Controls.Add(this.textBoxCoach);
            this.groupBoxAddNewPlayer.Controls.Add(this.buttonSubmitNewTeam);
            this.groupBoxAddNewPlayer.Controls.Add(this.textBoxRegion);
            this.groupBoxAddNewPlayer.Controls.Add(this.labelRegion);
            this.groupBoxAddNewPlayer.Controls.Add(this.labelCoach);
            this.groupBoxAddNewPlayer.Controls.Add(this.labelYearFounded);
            this.groupBoxAddNewPlayer.Controls.Add(this.textBoxGround);
            this.groupBoxAddNewPlayer.Controls.Add(this.labelGround);
            this.groupBoxAddNewPlayer.Controls.Add(this.labelID);
            this.groupBoxAddNewPlayer.Controls.Add(this.textBoxName);
            this.groupBoxAddNewPlayer.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddNewPlayer.Name = "groupBoxAddNewPlayer";
            this.groupBoxAddNewPlayer.Size = new System.Drawing.Size(193, 194);
            this.groupBoxAddNewPlayer.TabIndex = 2;
            this.groupBoxAddNewPlayer.TabStop = false;
            // 
            // maskedTextBoxYearFounded
            // 
            this.maskedTextBoxYearFounded.Location = new System.Drawing.Point(87, 94);
            this.maskedTextBoxYearFounded.Mask = "0000";
            this.maskedTextBoxYearFounded.Name = "maskedTextBoxYearFounded";
            this.maskedTextBoxYearFounded.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxYearFounded.TabIndex = 3;
            this.maskedTextBoxYearFounded.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxCoach
            // 
            this.textBoxCoach.Location = new System.Drawing.Point(87, 68);
            this.textBoxCoach.Name = "textBoxCoach";
            this.textBoxCoach.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoach.TabIndex = 2;
            // 
            // buttonSubmitNewTeam
            // 
            this.buttonSubmitNewTeam.Location = new System.Drawing.Point(43, 161);
            this.buttonSubmitNewTeam.Name = "buttonSubmitNewTeam";
            this.buttonSubmitNewTeam.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmitNewTeam.TabIndex = 14;
            this.buttonSubmitNewTeam.Text = "Submit";
            this.buttonSubmitNewTeam.UseVisualStyleBackColor = true;
            this.buttonSubmitNewTeam.Click += new System.EventHandler(this.buttonSubmitNewTeam_Click);
            // 
            // textBoxRegion
            // 
            this.textBoxRegion.Location = new System.Drawing.Point(87, 120);
            this.textBoxRegion.Name = "textBoxRegion";
            this.textBoxRegion.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegion.TabIndex = 4;
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Location = new System.Drawing.Point(6, 120);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(41, 13);
            this.labelRegion.TabIndex = 8;
            this.labelRegion.Text = "Region";
            // 
            // labelCoach
            // 
            this.labelCoach.AutoSize = true;
            this.labelCoach.Location = new System.Drawing.Point(6, 68);
            this.labelCoach.Name = "labelCoach";
            this.labelCoach.Size = new System.Drawing.Size(38, 13);
            this.labelCoach.TabIndex = 7;
            this.labelCoach.Text = "Coach";
            // 
            // labelYearFounded
            // 
            this.labelYearFounded.AutoSize = true;
            this.labelYearFounded.Location = new System.Drawing.Point(6, 94);
            this.labelYearFounded.Name = "labelYearFounded";
            this.labelYearFounded.Size = new System.Drawing.Size(74, 13);
            this.labelYearFounded.TabIndex = 4;
            this.labelYearFounded.Text = "Year Founded";
            // 
            // textBoxGround
            // 
            this.textBoxGround.Location = new System.Drawing.Point(87, 42);
            this.textBoxGround.Name = "textBoxGround";
            this.textBoxGround.Size = new System.Drawing.Size(100, 20);
            this.textBoxGround.TabIndex = 1;
            // 
            // labelGround
            // 
            this.labelGround.AutoSize = true;
            this.labelGround.Location = new System.Drawing.Point(6, 42);
            this.labelGround.Name = "labelGround";
            this.labelGround.Size = new System.Drawing.Size(42, 13);
            this.labelGround.TabIndex = 2;
            this.labelGround.Text = "Ground";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(6, 16);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(76, 13);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "Name (unique)";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(87, 16);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // AddNewTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 216);
            this.Controls.Add(this.groupBoxAddNewPlayer);
            this.Name = "AddNewTeam";
            this.Text = "Add New Team";
            this.groupBoxAddNewPlayer.ResumeLayout(false);
            this.groupBoxAddNewPlayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddNewPlayer;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxYearFounded;
        private System.Windows.Forms.TextBox textBoxCoach;
        private System.Windows.Forms.Button buttonSubmitNewTeam;
        private System.Windows.Forms.TextBox textBoxRegion;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.Label labelCoach;
        private System.Windows.Forms.Label labelYearFounded;
        private System.Windows.Forms.TextBox textBoxGround;
        private System.Windows.Forms.Label labelGround;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxName;
    }
}