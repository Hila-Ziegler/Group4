
namespace Group4
{
    partial class StudentCrud
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
            this.BringBackFromArchieve = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Namelbl = new System.Windows.Forms.Label();
            this.Createbtn = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.lb_ID_value = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.NameTitle = new System.Windows.Forms.Label();
            this.StudentCrudClublb = new System.Windows.Forms.Label();
            this.StudentCrudAgelb = new System.Windows.Forms.Label();
            this.YearlyGoalTextBox = new System.Windows.Forms.TextBox();
            this.YearlyGoallbl = new System.Windows.Forms.Label();
            this.AgeComboBox = new System.Windows.Forms.ComboBox();
            this.ClubComboBox = new System.Windows.Forms.ComboBox();
            this.ClubNamelbl = new System.Windows.Forms.Label();
            this.YearlyGoalValuelbl = new System.Windows.Forms.Label();
            this.AgeValuelbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BringBackFromArchieve
            // 
            this.BringBackFromArchieve.Location = new System.Drawing.Point(578, 100);
            this.BringBackFromArchieve.Name = "BringBackFromArchieve";
            this.BringBackFromArchieve.Size = new System.Drawing.Size(128, 52);
            this.BringBackFromArchieve.TabIndex = 69;
            this.BringBackFromArchieve.Text = "Return From Archieve";
            this.BringBackFromArchieve.UseVisualStyleBackColor = true;
            this.BringBackFromArchieve.Click += new System.EventHandler(this.BringBackFromArchieve_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(294, 337);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 54);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "Update ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(325, 100);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(128, 22);
            this.NameTextBox.TabIndex = 67;
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(94, 103);
            this.Namelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(45, 17);
            this.Namelbl.TabIndex = 66;
            this.Namelbl.Text = "Name";
            // 
            // Createbtn
            // 
            this.Createbtn.Location = new System.Drawing.Point(265, 366);
            this.Createbtn.Name = "Createbtn";
            this.Createbtn.Size = new System.Drawing.Size(145, 49);
            this.Createbtn.TabIndex = 65;
            this.Createbtn.Text = "Create";
            this.Createbtn.UseVisualStyleBackColor = true;
            this.Createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(325, 262);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(128, 22);
            this.PasswordTextBox.TabIndex = 64;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(325, 133);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(128, 22);
            this.IDTextBox.TabIndex = 63;
            // 
            // lb_ID_value
            // 
            this.lb_ID_value.AutoSize = true;
            this.lb_ID_value.Location = new System.Drawing.Point(322, 135);
            this.lb_ID_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ID_value.Name = "lb_ID_value";
            this.lb_ID_value.Size = new System.Drawing.Size(0, 17);
            this.lb_ID_value.TabIndex = 62;
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Location = new System.Drawing.Point(94, 133);
            this.IDlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(21, 17);
            this.IDlbl.TabIndex = 61;
            this.IDlbl.Text = "ID";
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Location = new System.Drawing.Point(94, 265);
            this.Passwordlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(69, 17);
            this.Passwordlbl.TabIndex = 60;
            this.Passwordlbl.Text = "Password";
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(417, 363);
            this.DeleteBTN.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(100, 28);
            this.DeleteBTN.TabIndex = 59;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.Location = new System.Drawing.Point(161, 363);
            this.UpdateBTN.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(100, 28);
            this.UpdateBTN.TabIndex = 58;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // NameTitle
            // 
            this.NameTitle.AutoSize = true;
            this.NameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTitle.Location = new System.Drawing.Point(318, 36);
            this.NameTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameTitle.Name = "NameTitle";
            this.NameTitle.Size = new System.Drawing.Size(117, 42);
            this.NameTitle.TabIndex = 57;
            this.NameTitle.Text = "Name";
            // 
            // StudentCrudClublb
            // 
            this.StudentCrudClublb.AutoSize = true;
            this.StudentCrudClublb.Location = new System.Drawing.Point(94, 198);
            this.StudentCrudClublb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentCrudClublb.Name = "StudentCrudClublb";
            this.StudentCrudClublb.Size = new System.Drawing.Size(36, 17);
            this.StudentCrudClublb.TabIndex = 70;
            this.StudentCrudClublb.Text = "Club";
            // 
            // StudentCrudAgelb
            // 
            this.StudentCrudAgelb.AutoSize = true;
            this.StudentCrudAgelb.Location = new System.Drawing.Point(94, 164);
            this.StudentCrudAgelb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentCrudAgelb.Name = "StudentCrudAgelb";
            this.StudentCrudAgelb.Size = new System.Drawing.Size(33, 17);
            this.StudentCrudAgelb.TabIndex = 72;
            this.StudentCrudAgelb.Text = "Age";
            // 
            // YearlyGoalTextBox
            // 
            this.YearlyGoalTextBox.Location = new System.Drawing.Point(325, 223);
            this.YearlyGoalTextBox.Name = "YearlyGoalTextBox";
            this.YearlyGoalTextBox.Size = new System.Drawing.Size(128, 22);
            this.YearlyGoalTextBox.TabIndex = 75;
            // 
            // YearlyGoallbl
            // 
            this.YearlyGoallbl.AutoSize = true;
            this.YearlyGoallbl.Location = new System.Drawing.Point(94, 226);
            this.YearlyGoallbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YearlyGoallbl.Name = "YearlyGoallbl";
            this.YearlyGoallbl.Size = new System.Drawing.Size(82, 17);
            this.YearlyGoallbl.TabIndex = 74;
            this.YearlyGoallbl.Text = "Yearly Goal";
            // 
            // AgeComboBox
            // 
            this.AgeComboBox.FormattingEnabled = true;
            this.AgeComboBox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.AgeComboBox.Location = new System.Drawing.Point(325, 161);
            this.AgeComboBox.Name = "AgeComboBox";
            this.AgeComboBox.Size = new System.Drawing.Size(128, 24);
            this.AgeComboBox.TabIndex = 76;
            // 
            // ClubComboBox
            // 
            this.ClubComboBox.FormattingEnabled = true;
            this.ClubComboBox.Location = new System.Drawing.Point(325, 192);
            this.ClubComboBox.Name = "ClubComboBox";
            this.ClubComboBox.Size = new System.Drawing.Size(128, 24);
            this.ClubComboBox.TabIndex = 77;
            this.ClubComboBox.SelectedIndexChanged += new System.EventHandler(this.ClubComboBox_SelectedIndexChanged);
            // 
            // ClubNamelbl
            // 
            this.ClubNamelbl.AutoSize = true;
            this.ClubNamelbl.Location = new System.Drawing.Point(322, 199);
            this.ClubNamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClubNamelbl.Name = "ClubNamelbl";
            this.ClubNamelbl.Size = new System.Drawing.Size(0, 17);
            this.ClubNamelbl.TabIndex = 78;
            // 
            // YearlyGoalValuelbl
            // 
            this.YearlyGoalValuelbl.AutoSize = true;
            this.YearlyGoalValuelbl.Location = new System.Drawing.Point(322, 226);
            this.YearlyGoalValuelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YearlyGoalValuelbl.Name = "YearlyGoalValuelbl";
            this.YearlyGoalValuelbl.Size = new System.Drawing.Size(0, 17);
            this.YearlyGoalValuelbl.TabIndex = 79;
            // 
            // AgeValuelbl
            // 
            this.AgeValuelbl.AutoSize = true;
            this.AgeValuelbl.Location = new System.Drawing.Point(322, 164);
            this.AgeValuelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AgeValuelbl.Name = "AgeValuelbl";
            this.AgeValuelbl.Size = new System.Drawing.Size(0, 17);
            this.AgeValuelbl.TabIndex = 80;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homepageToolStripMenuItem,
            this.manageStudentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 81;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homepageToolStripMenuItem
            // 
            this.homepageToolStripMenuItem.Name = "homepageToolStripMenuItem";
            this.homepageToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.homepageToolStripMenuItem.Text = "Homepage";
            this.homepageToolStripMenuItem.Click += new System.EventHandler(this.homepageToolStripMenuItem_Click);
            // 
            // manageStudentsToolStripMenuItem
            // 
            this.manageStudentsToolStripMenuItem.Name = "manageStudentsToolStripMenuItem";
            this.manageStudentsToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.manageStudentsToolStripMenuItem.Text = "Manage Students";
            this.manageStudentsToolStripMenuItem.Click += new System.EventHandler(this.manageStudentsToolStripMenuItem_Click);
            // 
            // StudentCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AgeValuelbl);
            this.Controls.Add(this.YearlyGoalValuelbl);
            this.Controls.Add(this.ClubNamelbl);
            this.Controls.Add(this.ClubComboBox);
            this.Controls.Add(this.AgeComboBox);
            this.Controls.Add(this.YearlyGoalTextBox);
            this.Controls.Add(this.YearlyGoallbl);
            this.Controls.Add(this.StudentCrudAgelb);
            this.Controls.Add(this.StudentCrudClublb);
            this.Controls.Add(this.BringBackFromArchieve);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.Createbtn);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.lb_ID_value);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.UpdateBTN);
            this.Controls.Add(this.NameTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentCrud";
            this.Text = "StudentsCrud";
            this.Load += new System.EventHandler(this.StudentCrud_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BringBackFromArchieve;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Button Createbtn;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label lb_ID_value;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.Label NameTitle;
        private System.Windows.Forms.Label StudentCrudClublb;
        private System.Windows.Forms.Label StudentCrudAgelb;
        private System.Windows.Forms.TextBox YearlyGoalTextBox;
        private System.Windows.Forms.Label YearlyGoallbl;
        private System.Windows.Forms.ComboBox AgeComboBox;
        private System.Windows.Forms.ComboBox ClubComboBox;
        private System.Windows.Forms.Label ClubNamelbl;
        private System.Windows.Forms.Label YearlyGoalValuelbl;
        private System.Windows.Forms.Label AgeValuelbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStudentsToolStripMenuItem;
    }
}