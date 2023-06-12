namespace Group4
{
    partial class socialPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.labSchoolName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labGoal = new System.Windows.Forms.Label();
            this.labClub = new System.Windows.Forms.Label();
            this.labAge = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarAllTheTome = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarThisYear = new System.Windows.Forms.ProgressBar();
            this.progressBarClub = new System.Windows.Forms.ProgressBar();
            this.lablabThisYearIRead1 = new System.Windows.Forms.Label();
            this.labThisYearIRead = new System.Windows.Forms.Label();
            this.labPercentageAll = new System.Windows.Forms.Label();
            this.labPercentageClub = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.Id,
            this.Age,
            this.Club});
            this.dataGridView1.Location = new System.Drawing.Point(431, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(567, 481);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 125;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.Width = 125;
            // 
            // Club
            // 
            this.Club.HeaderText = "Club";
            this.Club.MinimumWidth = 6;
            this.Club.Name = "Club";
            this.Club.Width = 125;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(425, 49);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(86, 36);
            this.labName.TabIndex = 18;
            this.labName.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 26);
            this.label10.TabIndex = 17;
            this.label10.Text = "Age";
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDate.Location = new System.Drawing.Point(824, 55);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(56, 26);
            this.labDate.TabIndex = 20;
            this.labDate.Text = "Date";
            // 
            // labSchoolName
            // 
            this.labSchoolName.AutoSize = true;
            this.labSchoolName.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSchoolName.Location = new System.Drawing.Point(51, 59);
            this.labSchoolName.Name = "labSchoolName";
            this.labSchoolName.Size = new System.Drawing.Size(122, 23);
            this.labSchoolName.TabIndex = 21;
            this.labSchoolName.Text = "School\'s Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(128, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 26);
            this.label11.TabIndex = 22;
            this.label11.Text = "Your Club:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "You\'ve Read So Far";
            // 
            // labGoal
            // 
            this.labGoal.AutoSize = true;
            this.labGoal.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGoal.Location = new System.Drawing.Point(38, 400);
            this.labGoal.Name = "labGoal";
            this.labGoal.Size = new System.Drawing.Size(121, 26);
            this.labGoal.TabIndex = 28;
            this.labGoal.Text = "You\'ve read ";
            this.labGoal.Click += new System.EventHandler(this.labGoal_Click);
            // 
            // labClub
            // 
            this.labClub.AutoSize = true;
            this.labClub.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labClub.Location = new System.Drawing.Point(130, 156);
            this.labClub.Name = "labClub";
            this.labClub.Size = new System.Drawing.Size(104, 26);
            this.labClub.TabIndex = 27;
            this.labClub.Text = "Your Club:";
            // 
            // labAge
            // 
            this.labAge.AutoSize = true;
            this.labAge.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAge.Location = new System.Drawing.Point(40, 156);
            this.labAge.Name = "labAge";
            this.labAge.Size = new System.Drawing.Size(45, 26);
            this.labAge.TabIndex = 24;
            this.labAge.Text = "Age";
            this.labAge.Click += new System.EventHandler(this.label6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1119, 31);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(108, 27);
            this.homePageToolStripMenuItem.Text = "Home page";
            this.homePageToolStripMenuItem.Click += new System.EventHandler(this.homePageToolStripMenuItem_Click);
            // 
            // progressBarAllTheTome
            // 
            this.progressBarAllTheTome.Location = new System.Drawing.Point(41, 438);
            this.progressBarAllTheTome.Name = "progressBarAllTheTome";
            this.progressBarAllTheTome.Size = new System.Drawing.Size(367, 26);
            this.progressBarAllTheTome.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarAllTheTome.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "Your Club\'s Progress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "This year I read";
            // 
            // progressBarThisYear
            // 
            this.progressBarThisYear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.progressBarThisYear.Location = new System.Drawing.Point(41, 321);
            this.progressBarThisYear.Name = "progressBarThisYear";
            this.progressBarThisYear.Size = new System.Drawing.Size(367, 25);
            this.progressBarThisYear.TabIndex = 35;
            // 
            // progressBarClub
            // 
            this.progressBarClub.Location = new System.Drawing.Point(41, 540);
            this.progressBarClub.Name = "progressBarClub";
            this.progressBarClub.Size = new System.Drawing.Size(367, 23);
            this.progressBarClub.TabIndex = 32;
            this.progressBarClub.Click += new System.EventHandler(this.progressBarClub_Click);
            // 
            // lablabThisYearIRead1
            // 
            this.lablabThisYearIRead1.AutoSize = true;
            this.lablabThisYearIRead1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablabThisYearIRead1.Location = new System.Drawing.Point(315, 293);
            this.lablabThisYearIRead1.Name = "lablabThisYearIRead1";
            this.lablabThisYearIRead1.Size = new System.Drawing.Size(95, 26);
            this.lablabThisYearIRead1.TabIndex = 36;
            this.lablabThisYearIRead1.Text = "This year";
            // 
            // labThisYearIRead
            // 
            this.labThisYearIRead.AutoSize = true;
            this.labThisYearIRead.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labThisYearIRead.Location = new System.Drawing.Point(38, 273);
            this.labThisYearIRead.Name = "labThisYearIRead";
            this.labThisYearIRead.Size = new System.Drawing.Size(100, 26);
            this.labThisYearIRead.TabIndex = 34;
            this.labThisYearIRead.Text = "This year";
            // 
            // labPercentageAll
            // 
            this.labPercentageAll.AutoSize = true;
            this.labPercentageAll.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPercentageAll.Location = new System.Drawing.Point(315, 410);
            this.labPercentageAll.Name = "labPercentageAll";
            this.labPercentageAll.Size = new System.Drawing.Size(95, 26);
            this.labPercentageAll.TabIndex = 37;
            this.labPercentageAll.Text = "This year";
            this.labPercentageAll.Click += new System.EventHandler(this.label4_Click);
            // 
            // labPercentageClub
            // 
            this.labPercentageClub.AutoSize = true;
            this.labPercentageClub.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPercentageClub.Location = new System.Drawing.Point(315, 512);
            this.labPercentageClub.Name = "labPercentageClub";
            this.labPercentageClub.Size = new System.Drawing.Size(95, 26);
            this.labPercentageClub.TabIndex = 38;
            this.labPercentageClub.Text = "This year";
            // 
            // socialPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1119, 673);
            this.Controls.Add(this.labPercentageClub);
            this.Controls.Add(this.labPercentageAll);
            this.Controls.Add(this.lablabThisYearIRead1);
            this.Controls.Add(this.progressBarThisYear);
            this.Controls.Add(this.labThisYearIRead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarClub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarAllTheTome);
            this.Controls.Add(this.labGoal);
            this.Controls.Add(this.labClub);
            this.Controls.Add(this.labAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labSchoolName);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "socialPage";
            this.Text = "socialPage";
            this.Load += new System.EventHandler(this.socialPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label labSchoolName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labGoal;
        private System.Windows.Forms.Label labClub;
        private System.Windows.Forms.Label labAge;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBarAllTheTome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBarThisYear;
        private System.Windows.Forms.ProgressBar progressBarClub;
        private System.Windows.Forms.Label lablabThisYearIRead1;
        private System.Windows.Forms.Label labThisYearIRead;
        private System.Windows.Forms.Label labPercentageAll;
        private System.Windows.Forms.Label labPercentageClub;
        private System.Windows.Forms.DataGridViewButtonColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Club;
    }
}