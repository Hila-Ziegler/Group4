﻿
namespace Group4
{
    partial class RequestDeat
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
            this.StartDTtxt = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.Label();
            this.EndDTtxt = new System.Windows.Forms.Label();
            this.CopyNumtxt = new System.Windows.Forms.Label();
            this.BookSerialtxt = new System.Windows.Forms.Label();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.AcceptBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sdtxt = new System.Windows.Forms.Label();
            this.Sidtxt = new System.Windows.Forms.Label();
            this.Bsntxt = new System.Windows.Forms.Label();
            this.Cntxt = new System.Windows.Forms.Label();
            this.Entxt = new System.Windows.Forms.Label();
            this.Snlbl = new System.Windows.Forms.Label();
            this.Sntxt = new System.Windows.Forms.Label();
            this.UpdateStlbl = new System.Windows.Forms.Label();
            this.StatusCombo = new System.Windows.Forms.ComboBox();
            this.CreateReqbtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartDTtxt
            // 
            this.StartDTtxt.AutoSize = true;
            this.StartDTtxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.StartDTtxt.Location = new System.Drawing.Point(134, 73);
            this.StartDTtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartDTtxt.Name = "StartDTtxt";
            this.StartDTtxt.Size = new System.Drawing.Size(72, 17);
            this.StartDTtxt.TabIndex = 51;
            this.StartDTtxt.Text = "Start Date";
            this.StartDTtxt.Click += new System.EventHandler(this.Titlelbl_Click);
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Location = new System.Drawing.Point(134, 102);
            this.StudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(74, 17);
            this.StudentID.TabIndex = 41;
            this.StudentID.Text = "Student ID";
            this.StudentID.Click += new System.EventHandler(this.label7_Click);
            // 
            // EndDTtxt
            // 
            this.EndDTtxt.AutoSize = true;
            this.EndDTtxt.Location = new System.Drawing.Point(134, 228);
            this.EndDTtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndDTtxt.Name = "EndDTtxt";
            this.EndDTtxt.Size = new System.Drawing.Size(67, 17);
            this.EndDTtxt.TabIndex = 39;
            this.EndDTtxt.Text = "End Date";
            this.EndDTtxt.Click += new System.EventHandler(this.label5_Click);
            // 
            // CopyNumtxt
            // 
            this.CopyNumtxt.AutoSize = true;
            this.CopyNumtxt.Location = new System.Drawing.Point(134, 196);
            this.CopyNumtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CopyNumtxt.Name = "CopyNumtxt";
            this.CopyNumtxt.Size = new System.Drawing.Size(94, 17);
            this.CopyNumtxt.TabIndex = 38;
            this.CopyNumtxt.Text = "Copy Number";
            this.CopyNumtxt.Click += new System.EventHandler(this.label4_Click);
            // 
            // BookSerialtxt
            // 
            this.BookSerialtxt.AutoSize = true;
            this.BookSerialtxt.Location = new System.Drawing.Point(134, 166);
            this.BookSerialtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookSerialtxt.Name = "BookSerialtxt";
            this.BookSerialtxt.Size = new System.Drawing.Size(134, 17);
            this.BookSerialtxt.TabIndex = 37;
            this.BookSerialtxt.Text = "Book Serial Number";
            this.BookSerialtxt.Click += new System.EventHandler(this.label3_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(309, 349);
            this.CancelBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(125, 28);
            this.CancelBTN.TabIndex = 36;
            this.CancelBTN.Text = "Cancel Request";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.BookCrudDeleteBTN_Click);
            // 
            // AcceptBTN
            // 
            this.AcceptBTN.Location = new System.Drawing.Point(53, 349);
            this.AcceptBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AcceptBTN.Name = "AcceptBTN";
            this.AcceptBTN.Size = new System.Drawing.Size(100, 28);
            this.AcceptBTN.TabIndex = 35;
            this.AcceptBTN.Text = "Update";
            this.AcceptBTN.UseVisualStyleBackColor = true;
            this.AcceptBTN.Click += new System.EventHandler(this.BookCrudUpdateBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 408);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "The library is a brand, when you\'ve got a card in your hand";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(586, 28);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.homePageToolStripMenuItem.Text = "Home Page";
            this.homePageToolStripMenuItem.Click += new System.EventHandler(this.homePageToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // Sdtxt
            // 
            this.Sdtxt.AutoSize = true;
            this.Sdtxt.Location = new System.Drawing.Point(301, 73);
            this.Sdtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sdtxt.Name = "Sdtxt";
            this.Sdtxt.Size = new System.Drawing.Size(0, 17);
            this.Sdtxt.TabIndex = 63;
            // 
            // Sidtxt
            // 
            this.Sidtxt.AutoSize = true;
            this.Sidtxt.Location = new System.Drawing.Point(301, 102);
            this.Sidtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sidtxt.Name = "Sidtxt";
            this.Sidtxt.Size = new System.Drawing.Size(0, 17);
            this.Sidtxt.TabIndex = 64;
            // 
            // Bsntxt
            // 
            this.Bsntxt.AutoSize = true;
            this.Bsntxt.Location = new System.Drawing.Point(301, 166);
            this.Bsntxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bsntxt.Name = "Bsntxt";
            this.Bsntxt.Size = new System.Drawing.Size(0, 17);
            this.Bsntxt.TabIndex = 65;
            this.Bsntxt.Click += new System.EventHandler(this.Bsntxt_Click);
            // 
            // Cntxt
            // 
            this.Cntxt.AutoSize = true;
            this.Cntxt.Location = new System.Drawing.Point(301, 196);
            this.Cntxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cntxt.Name = "Cntxt";
            this.Cntxt.Size = new System.Drawing.Size(0, 17);
            this.Cntxt.TabIndex = 66;
            // 
            // Entxt
            // 
            this.Entxt.AutoSize = true;
            this.Entxt.Location = new System.Drawing.Point(301, 228);
            this.Entxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Entxt.Name = "Entxt";
            this.Entxt.Size = new System.Drawing.Size(0, 17);
            this.Entxt.TabIndex = 67;
            // 
            // Snlbl
            // 
            this.Snlbl.AutoSize = true;
            this.Snlbl.Location = new System.Drawing.Point(134, 134);
            this.Snlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Snlbl.Name = "Snlbl";
            this.Snlbl.Size = new System.Drawing.Size(98, 17);
            this.Snlbl.TabIndex = 68;
            this.Snlbl.Text = "Student Name";
            // 
            // Sntxt
            // 
            this.Sntxt.AutoSize = true;
            this.Sntxt.Location = new System.Drawing.Point(301, 134);
            this.Sntxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sntxt.Name = "Sntxt";
            this.Sntxt.Size = new System.Drawing.Size(0, 17);
            this.Sntxt.TabIndex = 69;
            // 
            // UpdateStlbl
            // 
            this.UpdateStlbl.AutoSize = true;
            this.UpdateStlbl.Location = new System.Drawing.Point(138, 274);
            this.UpdateStlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdateStlbl.Name = "UpdateStlbl";
            this.UpdateStlbl.Size = new System.Drawing.Size(102, 17);
            this.UpdateStlbl.TabIndex = 70;
            this.UpdateStlbl.Text = "Update Status:";
            // 
            // StatusCombo
            // 
            this.StatusCombo.FormattingEnabled = true;
            this.StatusCombo.Location = new System.Drawing.Point(140, 303);
            this.StatusCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatusCombo.Name = "StatusCombo";
            this.StatusCombo.Size = new System.Drawing.Size(160, 24);
            this.StatusCombo.TabIndex = 71;
            // 
            // CreateReqbtn
            // 
            this.CreateReqbtn.Location = new System.Drawing.Point(161, 349);
            this.CreateReqbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateReqbtn.Name = "CreateReqbtn";
            this.CreateReqbtn.Size = new System.Drawing.Size(133, 28);
            this.CreateReqbtn.TabIndex = 73;
            this.CreateReqbtn.Text = "Create Request";
            this.CreateReqbtn.UseVisualStyleBackColor = true;
            this.CreateReqbtn.Click += new System.EventHandler(this.CreateReqbtn_Click);
            // 
            // RequestDeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 451);
            this.Controls.Add(this.CreateReqbtn);
            this.Controls.Add(this.StatusCombo);
            this.Controls.Add(this.UpdateStlbl);
            this.Controls.Add(this.Sntxt);
            this.Controls.Add(this.Snlbl);
            this.Controls.Add(this.Entxt);
            this.Controls.Add(this.Cntxt);
            this.Controls.Add(this.Bsntxt);
            this.Controls.Add(this.Sidtxt);
            this.Controls.Add(this.Sdtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartDTtxt);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.EndDTtxt);
            this.Controls.Add(this.CopyNumtxt);
            this.Controls.Add(this.BookSerialtxt);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.AcceptBTN);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RequestDeat";
            this.Text = "Request Details";
            this.Load += new System.EventHandler(this.RequestDeat_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label StartDTtxt;
        private System.Windows.Forms.Label StudentID;
        private System.Windows.Forms.Label EndDTtxt;
        private System.Windows.Forms.Label CopyNumtxt;
        private System.Windows.Forms.Label BookSerialtxt;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button AcceptBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label Sdtxt;
        private System.Windows.Forms.Label Sidtxt;
        private System.Windows.Forms.Label Bsntxt;
        private System.Windows.Forms.Label Cntxt;
        private System.Windows.Forms.Label Entxt;
        private System.Windows.Forms.Label Snlbl;
        private System.Windows.Forms.Label Sntxt;
        private System.Windows.Forms.Label UpdateStlbl;
        private System.Windows.Forms.ComboBox StatusCombo;
        private System.Windows.Forms.Button CreateReqbtn;
    }
}