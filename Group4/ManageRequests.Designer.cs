
namespace Group4
{
    partial class ManageRequests
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookSerialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopyNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.StartDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Copy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttachedPhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TimeReqtxt = new System.Windows.Forms.Label();
            this.AltBooktxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Requests";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartDate,
            this.StudentID,
            this.BookSerialNum,
            this.CopyNum,
            this.Actions});
            this.dataGridView1.Location = new System.Drawing.Point(36, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 224);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.Name = "StudentID";
            // 
            // BookSerialNum
            // 
            this.BookSerialNum.HeaderText = "Book Serial Number";
            this.BookSerialNum.Name = "BookSerialNum";
            // 
            // CopyNum
            // 
            this.CopyNum.HeaderText = "Copy Number";
            this.CopyNum.Name = "CopyNum";
            // 
            // Actions
            // 
            this.Actions.HeaderText = "Actions";
            this.Actions.Name = "Actions";
            this.Actions.Text = "View";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartDT,
            this.StudentID1,
            this.BookSerial,
            this.Copy,
            this.AttachedPhoto,
            this.Actions1});
            this.dataGridView2.Location = new System.Drawing.Point(624, 257);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(643, 224);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // StartDT
            // 
            this.StartDT.HeaderText = "Start Date";
            this.StartDT.Name = "StartDT";
            // 
            // StudentID1
            // 
            this.StudentID1.HeaderText = "Student ID";
            this.StudentID1.Name = "StudentID1";
            // 
            // BookSerial
            // 
            this.BookSerial.HeaderText = "Book Serial Number";
            this.BookSerial.Name = "BookSerial";
            // 
            // Copy
            // 
            this.Copy.HeaderText = "Copy Number";
            this.Copy.Name = "Copy";
            // 
            // AttachedPhoto
            // 
            this.AttachedPhoto.HeaderText = "Attached Photo";
            this.AttachedPhoto.Name = "AttachedPhoto";
            this.AttachedPhoto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AttachedPhoto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Actions1
            // 
            this.Actions1.HeaderText = "Actions";
            this.Actions1.Name = "Actions1";
            this.Actions1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Actions1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Actions1.Text = "View";
            // 
            // TimeReqtxt
            // 
            this.TimeReqtxt.AutoSize = true;
            this.TimeReqtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeReqtxt.Location = new System.Drawing.Point(32, 207);
            this.TimeReqtxt.Name = "TimeReqtxt";
            this.TimeReqtxt.Size = new System.Drawing.Size(191, 20);
            this.TimeReqtxt.TabIndex = 10;
            this.TimeReqtxt.Text = "Time Extention Requests:";
            // 
            // AltBooktxt
            // 
            this.AltBooktxt.AutoSize = true;
            this.AltBooktxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltBooktxt.Location = new System.Drawing.Point(620, 207);
            this.AltBooktxt.Name = "AltBooktxt";
            this.AltBooktxt.Size = new System.Drawing.Size(202, 20);
            this.AltBooktxt.TabIndex = 11;
            this.AltBooktxt.Text = "Alternative Book Requests:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 570);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "The library is a brand, when you\'ve got a card in your hand";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1319, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.homePageToolStripMenuItem.Text = "Home Page";
            // 
            // ManageRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 599);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AltBooktxt);
            this.Controls.Add(this.TimeReqtxt);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManageRequests";
            this.Text = "Manage Requests";
            this.Load += new System.EventHandler(this.ManageRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label TimeReqtxt;
        private System.Windows.Forms.Label AltBooktxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookSerialNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CopyNum;
        private System.Windows.Forms.DataGridViewButtonColumn Actions;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Copy;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttachedPhoto;
        private System.Windows.Forms.DataGridViewButtonColumn Actions1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
    }
}