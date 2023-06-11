
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
            this.AttachedPhotobox = new System.Windows.Forms.PictureBox();
            this.AttachedPhotolbl = new System.Windows.Forms.Label();
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
            this.Uploadbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AttachedPhotobox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartDTtxt
            // 
            this.StartDTtxt.AutoSize = true;
            this.StartDTtxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.StartDTtxt.Location = new System.Drawing.Point(280, 89);
            this.StartDTtxt.Name = "StartDTtxt";
            this.StartDTtxt.Size = new System.Drawing.Size(55, 13);
            this.StartDTtxt.TabIndex = 51;
            this.StartDTtxt.Text = "Start Date";
            this.StartDTtxt.Click += new System.EventHandler(this.Titlelbl_Click);
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Location = new System.Drawing.Point(280, 113);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(58, 13);
            this.StudentID.TabIndex = 41;
            this.StudentID.Text = "Student ID";
            this.StudentID.Click += new System.EventHandler(this.label7_Click);
            // 
            // EndDTtxt
            // 
            this.EndDTtxt.AutoSize = true;
            this.EndDTtxt.Location = new System.Drawing.Point(280, 215);
            this.EndDTtxt.Name = "EndDTtxt";
            this.EndDTtxt.Size = new System.Drawing.Size(52, 13);
            this.EndDTtxt.TabIndex = 39;
            this.EndDTtxt.Text = "End Date";
            this.EndDTtxt.Click += new System.EventHandler(this.label5_Click);
            // 
            // CopyNumtxt
            // 
            this.CopyNumtxt.AutoSize = true;
            this.CopyNumtxt.Location = new System.Drawing.Point(280, 189);
            this.CopyNumtxt.Name = "CopyNumtxt";
            this.CopyNumtxt.Size = new System.Drawing.Size(71, 13);
            this.CopyNumtxt.TabIndex = 38;
            this.CopyNumtxt.Text = "Copy Number";
            this.CopyNumtxt.Click += new System.EventHandler(this.label4_Click);
            // 
            // BookSerialtxt
            // 
            this.BookSerialtxt.AutoSize = true;
            this.BookSerialtxt.Location = new System.Drawing.Point(280, 165);
            this.BookSerialtxt.Name = "BookSerialtxt";
            this.BookSerialtxt.Size = new System.Drawing.Size(101, 13);
            this.BookSerialtxt.TabIndex = 37;
            this.BookSerialtxt.Text = "Book Serial Number";
            this.BookSerialtxt.Click += new System.EventHandler(this.label3_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(611, 313);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(94, 23);
            this.CancelBTN.TabIndex = 36;
            this.CancelBTN.Text = "Cancel Request";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.BookCrudDeleteBTN_Click);
            // 
            // AcceptBTN
            // 
            this.AcceptBTN.Location = new System.Drawing.Point(284, 313);
            this.AcceptBTN.Name = "AcceptBTN";
            this.AcceptBTN.Size = new System.Drawing.Size(75, 23);
            this.AcceptBTN.TabIndex = 35;
            this.AcceptBTN.Text = "Accept";
            this.AcceptBTN.UseVisualStyleBackColor = true;
            this.AcceptBTN.Click += new System.EventHandler(this.BookCrudUpdateBTN_Click);
            // 
            // AttachedPhotobox
            // 
            this.AttachedPhotobox.Location = new System.Drawing.Point(611, 113);
            this.AttachedPhotobox.Name = "AttachedPhotobox";
            this.AttachedPhotobox.Size = new System.Drawing.Size(141, 169);
            this.AttachedPhotobox.TabIndex = 58;
            this.AttachedPhotobox.TabStop = false;
            // 
            // AttachedPhotolbl
            // 
            this.AttachedPhotolbl.AutoSize = true;
            this.AttachedPhotolbl.Location = new System.Drawing.Point(608, 89);
            this.AttachedPhotolbl.Name = "AttachedPhotolbl";
            this.AttachedPhotolbl.Size = new System.Drawing.Size(84, 13);
            this.AttachedPhotolbl.TabIndex = 59;
            this.AttachedPhotolbl.Text = "Attached Photo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "The library is a brand, when you\'ve got a card in your hand";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.homePageToolStripMenuItem.Text = "Home Page";
            this.homePageToolStripMenuItem.Click += new System.EventHandler(this.homePageToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // Sdtxt
            // 
            this.Sdtxt.AutoSize = true;
            this.Sdtxt.Location = new System.Drawing.Point(405, 89);
            this.Sdtxt.Name = "Sdtxt";
            this.Sdtxt.Size = new System.Drawing.Size(0, 13);
            this.Sdtxt.TabIndex = 63;
            // 
            // Sidtxt
            // 
            this.Sidtxt.AutoSize = true;
            this.Sidtxt.Location = new System.Drawing.Point(405, 113);
            this.Sidtxt.Name = "Sidtxt";
            this.Sidtxt.Size = new System.Drawing.Size(0, 13);
            this.Sidtxt.TabIndex = 64;
            // 
            // Bsntxt
            // 
            this.Bsntxt.AutoSize = true;
            this.Bsntxt.Location = new System.Drawing.Point(405, 165);
            this.Bsntxt.Name = "Bsntxt";
            this.Bsntxt.Size = new System.Drawing.Size(0, 13);
            this.Bsntxt.TabIndex = 65;
            this.Bsntxt.Click += new System.EventHandler(this.Bsntxt_Click);
            // 
            // Cntxt
            // 
            this.Cntxt.AutoSize = true;
            this.Cntxt.Location = new System.Drawing.Point(405, 189);
            this.Cntxt.Name = "Cntxt";
            this.Cntxt.Size = new System.Drawing.Size(0, 13);
            this.Cntxt.TabIndex = 66;
            // 
            // Entxt
            // 
            this.Entxt.AutoSize = true;
            this.Entxt.Location = new System.Drawing.Point(405, 215);
            this.Entxt.Name = "Entxt";
            this.Entxt.Size = new System.Drawing.Size(0, 13);
            this.Entxt.TabIndex = 67;
            // 
            // Snlbl
            // 
            this.Snlbl.AutoSize = true;
            this.Snlbl.Location = new System.Drawing.Point(280, 139);
            this.Snlbl.Name = "Snlbl";
            this.Snlbl.Size = new System.Drawing.Size(75, 13);
            this.Snlbl.TabIndex = 68;
            this.Snlbl.Text = "Student Name";
            // 
            // Sntxt
            // 
            this.Sntxt.AutoSize = true;
            this.Sntxt.Location = new System.Drawing.Point(405, 139);
            this.Sntxt.Name = "Sntxt";
            this.Sntxt.Size = new System.Drawing.Size(0, 13);
            this.Sntxt.TabIndex = 69;
            // 
            // UpdateStlbl
            // 
            this.UpdateStlbl.AutoSize = true;
            this.UpdateStlbl.Location = new System.Drawing.Point(283, 253);
            this.UpdateStlbl.Name = "UpdateStlbl";
            this.UpdateStlbl.Size = new System.Drawing.Size(78, 13);
            this.UpdateStlbl.TabIndex = 70;
            this.UpdateStlbl.Text = "Update Status:";
            // 
            // StatusCombo
            // 
            this.StatusCombo.FormattingEnabled = true;
            this.StatusCombo.Location = new System.Drawing.Point(284, 276);
            this.StatusCombo.Name = "StatusCombo";
            this.StatusCombo.Size = new System.Drawing.Size(121, 21);
            this.StatusCombo.TabIndex = 71;
            // 
            // Uploadbtn
            // 
            this.Uploadbtn.Location = new System.Drawing.Point(779, 113);
            this.Uploadbtn.Name = "Uploadbtn";
            this.Uploadbtn.Size = new System.Drawing.Size(91, 23);
            this.Uploadbtn.TabIndex = 72;
            this.Uploadbtn.Text = "Upload Photo";
            this.Uploadbtn.UseVisualStyleBackColor = true;
            this.Uploadbtn.Click += new System.EventHandler(this.Uploadbtn_Click);
            // 
            // RequestDeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 459);
            this.Controls.Add(this.Uploadbtn);
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
            this.Controls.Add(this.AttachedPhotolbl);
            this.Controls.Add(this.AttachedPhotobox);
            this.Controls.Add(this.StartDTtxt);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.EndDTtxt);
            this.Controls.Add(this.CopyNumtxt);
            this.Controls.Add(this.BookSerialtxt);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.AcceptBTN);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RequestDeat";
            this.Text = "Request Details";
            this.Load += new System.EventHandler(this.RequestDeat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AttachedPhotobox)).EndInit();
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
        private System.Windows.Forms.PictureBox AttachedPhotobox;
        private System.Windows.Forms.Label AttachedPhotolbl;
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
        private System.Windows.Forms.Button Uploadbtn;
    }
}