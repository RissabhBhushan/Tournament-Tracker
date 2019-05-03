namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreText = new System.Windows.Forms.TextBox();
            this.teamTwoScoreText = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.versusLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Black;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 26F);
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(10, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(203, 47);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.BackColor = System.Drawing.Color.Black;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 26F);
            this.tournamentName.ForeColor = System.Drawing.Color.White;
            this.tournamentName.Location = new System.Drawing.Point(198, 9);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(142, 47);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Round";
            // 
            // unplayedOnlyCheckBox
            // 
            this.unplayedOnlyCheckBox.AutoSize = true;
            this.unplayedOnlyCheckBox.BackColor = System.Drawing.Color.LightGreen;
            this.unplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.unplayedOnlyCheckBox.ForeColor = System.Drawing.Color.Black;
            this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(128, 162);
            this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(189, 36);
            this.unplayedOnlyCheckBox.TabIndex = 4;
            this.unplayedOnlyCheckBox.Text = "Unplayed Only";
            this.unplayedOnlyCheckBox.UseVisualStyleBackColor = false;
            this.unplayedOnlyCheckBox.CheckedChanged += new System.EventHandler(this.unplayedOnlyCheckBox_CheckedChanged);
            // 
            // roundDropDown
            // 
            this.roundDropDown.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(128, 110);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(257, 39);
            this.roundDropDown.TabIndex = 5;
            this.roundDropDown.SelectedIndexChanged += new System.EventHandler(this.roundDropDown_SelectedIndexChanged);
            // 
            // matchupListBox
            // 
            this.matchupListBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 25;
            this.matchupListBox.Location = new System.Drawing.Point(23, 232);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(362, 227);
            this.matchupListBox.TabIndex = 6;
            this.matchupListBox.SelectedIndexChanged += new System.EventHandler(this.matchupListBox_SelectedIndexChanged);
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.teamOneName.ForeColor = System.Drawing.Color.Black;
            this.teamOneName.Location = new System.Drawing.Point(454, 232);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(149, 32);
            this.teamOneName.TabIndex = 7;
            this.teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.teamOneScoreLabel.ForeColor = System.Drawing.Color.Black;
            this.teamOneScoreLabel.Location = new System.Drawing.Point(454, 278);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(74, 32);
            this.teamOneScoreLabel.TabIndex = 8;
            this.teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreText
            // 
            this.teamOneScoreText.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.teamOneScoreText.Location = new System.Drawing.Point(537, 278);
            this.teamOneScoreText.Name = "teamOneScoreText";
            this.teamOneScoreText.Size = new System.Drawing.Size(103, 34);
            this.teamOneScoreText.TabIndex = 9;
            // 
            // teamTwoScoreText
            // 
            this.teamTwoScoreText.Font = new System.Drawing.Font("Segoe UI", 15.8F);
            this.teamTwoScoreText.Location = new System.Drawing.Point(537, 446);
            this.teamTwoScoreText.Name = "teamTwoScoreText";
            this.teamTwoScoreText.Size = new System.Drawing.Size(103, 36);
            this.teamTwoScoreText.TabIndex = 12;
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.teamTwoScoreLabel.ForeColor = System.Drawing.Color.Black;
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(454, 448);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(74, 32);
            this.teamTwoScoreLabel.TabIndex = 11;
            this.teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.teamTwoName.ForeColor = System.Drawing.Color.Black;
            this.teamTwoName.Location = new System.Drawing.Point(454, 402);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(147, 32);
            this.teamTwoName.TabIndex = 10;
            this.teamTwoName.Text = "<team two>";
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.versusLabel.ForeColor = System.Drawing.Color.Black;
            this.versusLabel.Location = new System.Drawing.Point(551, 352);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(65, 36);
            this.versusLabel.TabIndex = 13;
            this.versusLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            this.scoreButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.scoreButton.ForeColor = System.Drawing.Color.Black;
            this.scoreButton.Location = new System.Drawing.Point(697, 342);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(124, 59);
            this.scoreButton.TabIndex = 14;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = false;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(895, 67);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox2.Location = new System.Drawing.Point(-3, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(895, 150);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pictureBox3.Location = new System.Drawing.Point(-3, 205);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(439, 363);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pictureBox4.Location = new System.Drawing.Point(435, 205);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(457, 363);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 566);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.teamTwoScoreText);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneScoreText);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.unplayedOnlyCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckBox;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label teamOneScoreLabel;
        private System.Windows.Forms.TextBox teamOneScoreText;
        private System.Windows.Forms.TextBox teamTwoScoreText;
        private System.Windows.Forms.Label teamTwoScoreLabel;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

