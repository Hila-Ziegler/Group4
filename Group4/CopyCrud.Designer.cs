﻿
namespace Group4
{
    partial class CopyCrud
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
            this.CopyCrudTitle = new System.Windows.Forms.Label();
            this.CopyCrudCopyNum = new System.Windows.Forms.Label();
            this.StartBorrow = new System.Windows.Forms.Button();
            this.endBorrow1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.StID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.copyCrudMenu = new System.Windows.Forms.MenuStrip();
            this.MenuHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuManageBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.copyCrudMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CopyCrudTitle
            // 
            this.CopyCrudTitle.AutoSize = true;
            this.CopyCrudTitle.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyCrudTitle.Location = new System.Drawing.Point(53, 44);
            this.CopyCrudTitle.Name = "CopyCrudTitle";
            this.CopyCrudTitle.Size = new System.Drawing.Size(79, 38);
            this.CopyCrudTitle.TabIndex = 1;
            this.CopyCrudTitle.Text = "Title";
            // 
            // CopyCrudCopyNum
            // 
            this.CopyCrudCopyNum.AutoSize = true;
            this.CopyCrudCopyNum.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyCrudCopyNum.Location = new System.Drawing.Point(61, 81);
            this.CopyCrudCopyNum.Name = "CopyCrudCopyNum";
            this.CopyCrudCopyNum.Size = new System.Drawing.Size(197, 38);
            this.CopyCrudCopyNum.TabIndex = 2;
            this.CopyCrudCopyNum.Text = "Copy Number";
            // 
            // StartBorrow
            // 
            this.StartBorrow.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBorrow.Location = new System.Drawing.Point(117, 497);
            this.StartBorrow.Name = "StartBorrow";
            this.StartBorrow.Size = new System.Drawing.Size(109, 40);
            this.StartBorrow.TabIndex = 3;
            this.StartBorrow.Text = "Start Borrow";
            this.StartBorrow.UseVisualStyleBackColor = true;
            this.StartBorrow.Click += new System.EventHandler(this.StartBorrow_Click);
            // 
            // endBorrow1
            // 
            this.endBorrow1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endBorrow1.Location = new System.Drawing.Point(374, 400);
            this.endBorrow1.Name = "endBorrow1";
            this.endBorrow1.Size = new System.Drawing.Size(109, 40);
            this.endBorrow1.TabIndex = 4;
            this.endBorrow1.Text = "End Borrow";
            this.endBorrow1.UseVisualStyleBackColor = true;
            this.endBorrow1.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartDate,
            this.EndDate,
            this.StudentName,
            this.StudentID,
            this.Rating});
            this.dataGridView1.Location = new System.Drawing.Point(69, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(639, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.MinimumWidth = 6;
            this.StartDate.Name = "StartDate";
            this.StartDate.Width = 125;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "End Date";
            this.EndDate.MinimumWidth = 6;
            this.EndDate.Name = "EndDate";
            this.EndDate.Width = 125;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 125;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 125;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            this.Rating.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Rating.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Borrow History ";
            // 
            // StID
            // 
            this.StID.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StID.Location = new System.Drawing.Point(117, 454);
            this.StID.Name = "StID";
            this.StID.Size = new System.Drawing.Size(100, 23);
            this.StID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Student ID:";
            // 
            // copyCrudMenu
            // 
            this.copyCrudMenu.BackColor = System.Drawing.Color.Lavender;
            this.copyCrudMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.copyCrudMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHomePage,
            this.MenuManageBooks});
            this.copyCrudMenu.Location = new System.Drawing.Point(0, 0);
            this.copyCrudMenu.Name = "copyCrudMenu";
            this.copyCrudMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.copyCrudMenu.Size = new System.Drawing.Size(870, 26);
            this.copyCrudMenu.TabIndex = 13;
            this.copyCrudMenu.Text = "menuStrip1";
            // 
            // MenuHomePage
            // 
            this.MenuHomePage.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuHomePage.Name = "MenuHomePage";
            this.MenuHomePage.Size = new System.Drawing.Size(89, 22);
            this.MenuHomePage.Text = "Home Page";
            this.MenuHomePage.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // MenuManageBooks
            // 
            this.MenuManageBooks.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuManageBooks.Name = "MenuManageBooks";
            this.MenuManageBooks.Size = new System.Drawing.Size(109, 22);
            this.MenuManageBooks.Text = "Manage Books";
            this.MenuManageBooks.Click += new System.EventHandler(this.MenuManageBooks_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 569);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "The library is a brand, when you\'ve got a card in your hand";
            // 
            // CopyCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(870, 613);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.endBorrow1);
            this.Controls.Add(this.StartBorrow);
            this.Controls.Add(this.CopyCrudCopyNum);
            this.Controls.Add(this.CopyCrudTitle);
            this.Controls.Add(this.copyCrudMenu);
            this.MainMenuStrip = this.copyCrudMenu;
            this.Name = "CopyCrud";
            this.Text = "CopyCrud";
            this.Load += new System.EventHandler(this.CopyCrud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.copyCrudMenu.ResumeLayout(false);
            this.copyCrudMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CopyCrudTitle;
        private System.Windows.Forms.Label CopyCrudCopyNum;
        private System.Windows.Forms.Button StartBorrow;
        private System.Windows.Forms.Button endBorrow1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip copyCrudMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuHomePage;
        private System.Windows.Forms.ToolStripMenuItem MenuManageBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.Label label2;
    }
}