
namespace MainPlayerManagementForm
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadAllPlayers = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadAllTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAllPlayers = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAllTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listViewPlayers = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlaceOfBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeamSigned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelAllPlayers = new System.Windows.Forms.Label();
            this.listViewTeams = new System.Windows.Forms.ListView();
            this.teamName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamGround = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamCoach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamYearFounded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTeams = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonSignToTeam = new System.Windows.Forms.Button();
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPlayerId = new System.Windows.Forms.TextBox();
            this.labelPlayerID = new System.Windows.Forms.Label();
            this.buttonAddNewPlayer = new System.Windows.Forms.Button();
            this.buttonAddNewTeam = new System.Windows.Forms.Button();
            this.chartHeightWeight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.buttonSearchAge = new System.Windows.Forms.Button();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelSearchAge = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxBirthPlace = new System.Windows.Forms.RichTextBox();
            this.buttonSearchBirthPlace = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chartAgeGroup = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.allDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHeightWeight)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAgeGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1153, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadAllPlayers,
            this.LoadAllTeams});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Load";
            // 
            // LoadAllPlayers
            // 
            this.LoadAllPlayers.Name = "LoadAllPlayers";
            this.LoadAllPlayers.Size = new System.Drawing.Size(180, 22);
            this.LoadAllPlayers.Text = "All Players";
            this.LoadAllPlayers.Click += new System.EventHandler(this.LoadAllPlayers_Click);
            // 
            // LoadAllTeams
            // 
            this.LoadAllTeams.Name = "LoadAllTeams";
            this.LoadAllTeams.Size = new System.Drawing.Size(180, 22);
            this.LoadAllTeams.Text = "All Teams";
            this.LoadAllTeams.Click += new System.EventHandler(this.LoadAllTeams_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveAllPlayers,
            this.SaveAllTeams,
            this.allDataToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // SaveAllPlayers
            // 
            this.SaveAllPlayers.Name = "SaveAllPlayers";
            this.SaveAllPlayers.Size = new System.Drawing.Size(180, 22);
            this.SaveAllPlayers.Text = "Players";
            this.SaveAllPlayers.Click += new System.EventHandler(this.SaveAllPlayers_Click);
            // 
            // SaveAllTeams
            // 
            this.SaveAllTeams.Name = "SaveAllTeams";
            this.SaveAllTeams.Size = new System.Drawing.Size(180, 22);
            this.SaveAllTeams.Text = "Teams";
            this.SaveAllTeams.Click += new System.EventHandler(this.SaveAllTeams_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listViewPlayers
            // 
            this.listViewPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.PlayerName,
            this.Dob,
            this.playerHeight,
            this.Weight,
            this.PlaceOfBirth,
            this.TeamSigned});
            this.listViewPlayers.FullRowSelect = true;
            this.listViewPlayers.GridLines = true;
            this.listViewPlayers.HideSelection = false;
            this.listViewPlayers.Location = new System.Drawing.Point(12, 49);
            this.listViewPlayers.Name = "listViewPlayers";
            this.listViewPlayers.Size = new System.Drawing.Size(509, 159);
            this.listViewPlayers.TabIndex = 1;
            this.listViewPlayers.UseCompatibleStateImageBehavior = false;
            this.listViewPlayers.View = System.Windows.Forms.View.Details;
            this.listViewPlayers.SelectedIndexChanged += new System.EventHandler(this.listViewPlayers_SelectedIndexChanged);
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
            // labelAllPlayers
            // 
            this.labelAllPlayers.AutoSize = true;
            this.labelAllPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllPlayers.Location = new System.Drawing.Point(167, 26);
            this.labelAllPlayers.Name = "labelAllPlayers";
            this.labelAllPlayers.Size = new System.Drawing.Size(92, 20);
            this.labelAllPlayers.TabIndex = 2;
            this.labelAllPlayers.Text = "All Players";
            // 
            // listViewTeams
            // 
            this.listViewTeams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.teamName,
            this.teamGround,
            this.teamCoach,
            this.teamYearFounded,
            this.teamRegion});
            this.listViewTeams.GridLines = true;
            this.listViewTeams.HideSelection = false;
            this.listViewTeams.Location = new System.Drawing.Point(545, 49);
            this.listViewTeams.Name = "listViewTeams";
            this.listViewTeams.Size = new System.Drawing.Size(466, 159);
            this.listViewTeams.TabIndex = 3;
            this.listViewTeams.UseCompatibleStateImageBehavior = false;
            this.listViewTeams.View = System.Windows.Forms.View.Details;
            this.listViewTeams.SelectedIndexChanged += new System.EventHandler(this.listViewTeams_SelectedIndexChanged);
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
            // labelTeams
            // 
            this.labelTeams.AutoSize = true;
            this.labelTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeams.Location = new System.Drawing.Point(739, 26);
            this.labelTeams.Name = "labelTeams";
            this.labelTeams.Size = new System.Drawing.Size(87, 20);
            this.labelTeams.TabIndex = 4;
            this.labelTeams.Text = "All Teams";
            // 
            // buttonSignToTeam
            // 
            this.buttonSignToTeam.Location = new System.Drawing.Point(9, 77);
            this.buttonSignToTeam.Name = "buttonSignToTeam";
            this.buttonSignToTeam.Size = new System.Drawing.Size(162, 23);
            this.buttonSignToTeam.TabIndex = 5;
            this.buttonSignToTeam.Text = "Sign Selected Player To Team";
            this.buttonSignToTeam.UseVisualStyleBackColor = true;
            this.buttonSignToTeam.Click += new System.EventHandler(this.buttonSignToTeam_Click);
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Location = new System.Drawing.Point(77, 51);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(94, 20);
            this.textBoxTeamName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Team Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPlayerId);
            this.groupBox1.Controls.Add(this.labelPlayerID);
            this.groupBox1.Controls.Add(this.textBoxTeamName);
            this.groupBox1.Controls.Add(this.buttonSignToTeam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 115);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign Player To Team";
            // 
            // textBoxPlayerId
            // 
            this.textBoxPlayerId.Location = new System.Drawing.Point(77, 25);
            this.textBoxPlayerId.Name = "textBoxPlayerId";
            this.textBoxPlayerId.Size = new System.Drawing.Size(41, 20);
            this.textBoxPlayerId.TabIndex = 10;
            // 
            // labelPlayerID
            // 
            this.labelPlayerID.AutoSize = true;
            this.labelPlayerID.Location = new System.Drawing.Point(8, 23);
            this.labelPlayerID.Name = "labelPlayerID";
            this.labelPlayerID.Size = new System.Drawing.Size(50, 13);
            this.labelPlayerID.TabIndex = 8;
            this.labelPlayerID.Text = "Player ID";
            // 
            // buttonAddNewPlayer
            // 
            this.buttonAddNewPlayer.Location = new System.Drawing.Point(237, 224);
            this.buttonAddNewPlayer.Name = "buttonAddNewPlayer";
            this.buttonAddNewPlayer.Size = new System.Drawing.Size(103, 23);
            this.buttonAddNewPlayer.TabIndex = 9;
            this.buttonAddNewPlayer.Text = "Add New Player";
            this.buttonAddNewPlayer.UseVisualStyleBackColor = true;
            this.buttonAddNewPlayer.Click += new System.EventHandler(this.buttonAddNewPlayer_Click);
            // 
            // buttonAddNewTeam
            // 
            this.buttonAddNewTeam.Location = new System.Drawing.Point(236, 254);
            this.buttonAddNewTeam.Name = "buttonAddNewTeam";
            this.buttonAddNewTeam.Size = new System.Drawing.Size(104, 23);
            this.buttonAddNewTeam.TabIndex = 10;
            this.buttonAddNewTeam.Text = "Add New Team";
            this.buttonAddNewTeam.UseVisualStyleBackColor = true;
            this.buttonAddNewTeam.Click += new System.EventHandler(this.buttonAddNewTeam_Click);
            // 
            // chartHeightWeight
            // 
            chartArea3.Name = "ChartArea1";
            this.chartHeightWeight.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartHeightWeight.Legends.Add(legend3);
            this.chartHeightWeight.Location = new System.Drawing.Point(369, 238);
            this.chartHeightWeight.Name = "chartHeightWeight";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartHeightWeight.Series.Add(series3);
            this.chartHeightWeight.Size = new System.Drawing.Size(357, 312);
            this.chartHeightWeight.TabIndex = 11;
            this.chartHeightWeight.Text = "chart1";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.buttonSearchAge);
            this.groupBoxSearch.Controls.Add(this.textBoxAge);
            this.groupBoxSearch.Controls.Add(this.labelSearchAge);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 365);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(133, 95);
            this.groupBoxSearch.TabIndex = 12;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search By Age";
            // 
            // buttonSearchAge
            // 
            this.buttonSearchAge.Location = new System.Drawing.Point(11, 72);
            this.buttonSearchAge.Name = "buttonSearchAge";
            this.buttonSearchAge.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchAge.TabIndex = 4;
            this.buttonSearchAge.Text = "Search Age";
            this.buttonSearchAge.UseVisualStyleBackColor = true;
            this.buttonSearchAge.Click += new System.EventHandler(this.buttonSearchAge_Click);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(11, 41);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(32, 20);
            this.textBoxAge.TabIndex = 1;
            // 
            // labelSearchAge
            // 
            this.labelSearchAge.AutoSize = true;
            this.labelSearchAge.Location = new System.Drawing.Point(8, 26);
            this.labelSearchAge.Name = "labelSearchAge";
            this.labelSearchAge.Size = new System.Drawing.Size(57, 13);
            this.labelSearchAge.TabIndex = 0;
            this.labelSearchAge.Text = "Enter Age:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxBirthPlace);
            this.groupBox2.Controls.Add(this.buttonSearchBirthPlace);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(171, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 116);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search By Birth Place";
            // 
            // richTextBoxBirthPlace
            // 
            this.richTextBoxBirthPlace.Location = new System.Drawing.Point(9, 42);
            this.richTextBoxBirthPlace.Name = "richTextBoxBirthPlace";
            this.richTextBoxBirthPlace.Size = new System.Drawing.Size(148, 33);
            this.richTextBoxBirthPlace.TabIndex = 9;
            this.richTextBoxBirthPlace.Text = "";
            // 
            // buttonSearchBirthPlace
            // 
            this.buttonSearchBirthPlace.Location = new System.Drawing.Point(9, 81);
            this.buttonSearchBirthPlace.Name = "buttonSearchBirthPlace";
            this.buttonSearchBirthPlace.Size = new System.Drawing.Size(116, 23);
            this.buttonSearchBirthPlace.TabIndex = 8;
            this.buttonSearchBirthPlace.Text = "Search Birth Place";
            this.buttonSearchBirthPlace.UseVisualStyleBackColor = true;
            this.buttonSearchBirthPlace.Click += new System.EventHandler(this.buttonSearchBirthPlace_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Birth Place:";
            // 
            // chartAgeGroup
            // 
            chartArea4.Name = "ChartArea1";
            this.chartAgeGroup.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartAgeGroup.Legends.Add(legend4);
            this.chartAgeGroup.Location = new System.Drawing.Point(767, 238);
            this.chartAgeGroup.Name = "chartAgeGroup";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartAgeGroup.Series.Add(series4);
            this.chartAgeGroup.Size = new System.Drawing.Size(356, 312);
            this.chartAgeGroup.TabIndex = 14;
            this.chartAgeGroup.Text = "chart1";
            // 
            // allDataToolStripMenuItem
            // 
            this.allDataToolStripMenuItem.Name = "allDataToolStripMenuItem";
            this.allDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allDataToolStripMenuItem.Text = "All Data";
            this.allDataToolStripMenuItem.Click += new System.EventHandler(this.allDataToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 651);
            this.Controls.Add(this.chartAgeGroup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.chartHeightWeight);
            this.Controls.Add(this.buttonAddNewTeam);
            this.Controls.Add(this.buttonAddNewPlayer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTeams);
            this.Controls.Add(this.listViewTeams);
            this.Controls.Add(this.labelAllPlayers);
            this.Controls.Add(this.listViewPlayers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Player Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHeightWeight)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAgeGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem LoadAllPlayers;
        private System.Windows.Forms.ToolStripMenuItem LoadAllTeams;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAllPlayers;
        private System.Windows.Forms.ToolStripMenuItem SaveAllTeams;
        private System.Windows.Forms.ColumnHeader Id;
        private new System.Windows.Forms.ColumnHeader PlayerName;
        private System.Windows.Forms.ColumnHeader Dob;
        private new System.Windows.Forms.ColumnHeader playerHeight;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.ColumnHeader PlaceOfBirth;
        private System.Windows.Forms.ColumnHeader TeamSigned;
        private System.Windows.Forms.Label labelAllPlayers;
        private System.Windows.Forms.ColumnHeader teamName;
        private System.Windows.Forms.ColumnHeader teamGround;
        private System.Windows.Forms.ColumnHeader teamCoach;
        private System.Windows.Forms.ColumnHeader teamYearFounded;
        private System.Windows.Forms.ColumnHeader teamRegion;
        private System.Windows.Forms.Label labelTeams;
        public System.Windows.Forms.ListView listViewPlayers;
        public System.Windows.Forms.ListView listViewTeams;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonSignToTeam;
        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPlayerID;
        private System.Windows.Forms.Button buttonAddNewPlayer;
        private System.Windows.Forms.Button buttonAddNewTeam;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHeightWeight;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label labelSearchAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button buttonSearchAge;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxBirthPlace;
        private System.Windows.Forms.Button buttonSearchBirthPlace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlayerId;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAgeGroup;
        private System.Windows.Forms.ToolStripMenuItem allDataToolStripMenuItem;
    }
}

