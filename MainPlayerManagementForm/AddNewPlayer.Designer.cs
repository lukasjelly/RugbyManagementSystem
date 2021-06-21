
namespace MainPlayerManagementForm
{
    partial class AddNewPlayer
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxAddNewPlayer = new System.Windows.Forms.GroupBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxSignedTeam = new System.Windows.Forms.TextBox();
            this.labelSignedTeam = new System.Windows.Forms.Label();
            this.textBoxPlaceOfBirth = new System.Windows.Forms.TextBox();
            this.labelPlaceOfBirth = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.maskedTextBoxDOB = new System.Windows.Forms.MaskedTextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.toolTipDate = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxAddNewPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddNewPlayer
            // 
            this.groupBoxAddNewPlayer.Controls.Add(this.buttonSubmit);
            this.groupBoxAddNewPlayer.Controls.Add(this.textBoxSignedTeam);
            this.groupBoxAddNewPlayer.Controls.Add(this.labelSignedTeam);
            this.groupBoxAddNewPlayer.Controls.Add(this.textBoxPlaceOfBirth);
            this.groupBoxAddNewPlayer.Controls.Add(this.labelPlaceOfBirth);
            this.groupBoxAddNewPlayer.Controls.Add(this.textBoxWeight);
            this.groupBoxAddNewPlayer.Controls.Add(this.labelWeight);
            this.groupBoxAddNewPlayer.Controls.Add(this.labelDOB);
            this.groupBoxAddNewPlayer.Controls.Add(this.maskedTextBoxDOB);
            this.groupBoxAddNewPlayer.Controls.Add(this.textBoxHeight);
            this.groupBoxAddNewPlayer.Controls.Add(this.labelHeight);
            this.groupBoxAddNewPlayer.Controls.Add(this.textBoxName);
            this.groupBoxAddNewPlayer.Controls.Add(this.labelName);
            this.groupBoxAddNewPlayer.Controls.Add(this.labelID);
            this.groupBoxAddNewPlayer.Controls.Add(this.textBoxID);
            this.groupBoxAddNewPlayer.Location = new System.Drawing.Point(13, 13);
            this.groupBoxAddNewPlayer.Name = "groupBoxAddNewPlayer";
            this.groupBoxAddNewPlayer.Size = new System.Drawing.Size(193, 249);
            this.groupBoxAddNewPlayer.TabIndex = 0;
            this.groupBoxAddNewPlayer.TabStop = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(43, 211);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxSignedTeam
            // 
            this.textBoxSignedTeam.Location = new System.Drawing.Point(87, 172);
            this.textBoxSignedTeam.Name = "textBoxSignedTeam";
            this.textBoxSignedTeam.Size = new System.Drawing.Size(100, 20);
            this.textBoxSignedTeam.TabIndex = 6;
            // 
            // labelSignedTeam
            // 
            this.labelSignedTeam.AutoSize = true;
            this.labelSignedTeam.Location = new System.Drawing.Point(6, 172);
            this.labelSignedTeam.Name = "labelSignedTeam";
            this.labelSignedTeam.Size = new System.Drawing.Size(70, 13);
            this.labelSignedTeam.TabIndex = 12;
            this.labelSignedTeam.Text = "Signed Team";
            // 
            // textBoxPlaceOfBirth
            // 
            this.textBoxPlaceOfBirth.Location = new System.Drawing.Point(87, 146);
            this.textBoxPlaceOfBirth.Name = "textBoxPlaceOfBirth";
            this.textBoxPlaceOfBirth.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlaceOfBirth.TabIndex = 5;
            // 
            // labelPlaceOfBirth
            // 
            this.labelPlaceOfBirth.AutoSize = true;
            this.labelPlaceOfBirth.Location = new System.Drawing.Point(6, 146);
            this.labelPlaceOfBirth.Name = "labelPlaceOfBirth";
            this.labelPlaceOfBirth.Size = new System.Drawing.Size(70, 13);
            this.labelPlaceOfBirth.TabIndex = 10;
            this.labelPlaceOfBirth.Text = "Place of Birth";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(87, 120);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeight.TabIndex = 4;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(6, 120);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(41, 13);
            this.labelWeight.TabIndex = 8;
            this.labelWeight.Text = "Weight";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(6, 68);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(66, 13);
            this.labelDOB.TabIndex = 7;
            this.labelDOB.Text = "Date of Birth";
            // 
            // maskedTextBoxDOB
            // 
            this.maskedTextBoxDOB.Location = new System.Drawing.Point(87, 68);
            this.maskedTextBoxDOB.Mask = "00-00-0000";
            this.maskedTextBoxDOB.Name = "maskedTextBoxDOB";
            this.maskedTextBoxDOB.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDOB.TabIndex = 2;
            this.maskedTextBoxDOB.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(87, 94);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 3;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(6, 94);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(38, 13);
            this.labelHeight.TabIndex = 4;
            this.labelHeight.Text = "Height";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(87, 42);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 42);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(6, 16);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(59, 13);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID (unique)";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(87, 16);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 0;
            // 
            // AddNewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 289);
            this.Controls.Add(this.groupBoxAddNewPlayer);
            this.Name = "AddNewPlayer";
            this.Text = "Add New Player";
            this.groupBoxAddNewPlayer.ResumeLayout(false);
            this.groupBoxAddNewPlayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddNewPlayer;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDOB;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox textBoxPlaceOfBirth;
        private System.Windows.Forms.Label labelPlaceOfBirth;
        private System.Windows.Forms.TextBox textBoxSignedTeam;
        private System.Windows.Forms.Label labelSignedTeam;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ToolTip toolTipDate;
    }
}