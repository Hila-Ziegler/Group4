
namespace Group4
{
    partial class StudentRequests
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
            this.AllOpenReqtxt = new System.Windows.Forms.Label();
            this.AllClosedReqtxt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllOpenReqtxt
            // 
            this.AllOpenReqtxt.AutoSize = true;
            this.AllOpenReqtxt.Location = new System.Drawing.Point(51, 83);
            this.AllOpenReqtxt.Name = "AllOpenReqtxt";
            this.AllOpenReqtxt.Size = new System.Drawing.Size(98, 13);
            this.AllOpenReqtxt.TabIndex = 0;
            this.AllOpenReqtxt.Text = "All Open Requests:";
            // 
            // AllClosedReqtxt
            // 
            this.AllClosedReqtxt.AutoSize = true;
            this.AllClosedReqtxt.Location = new System.Drawing.Point(459, 83);
            this.AllClosedReqtxt.Name = "AllClosedReqtxt";
            this.AllClosedReqtxt.Size = new System.Drawing.Size(111, 13);
            this.AllClosedReqtxt.TabIndex = 1;
            this.AllClosedReqtxt.Text = "All Finished Requests:";
            this.AllClosedReqtxt.Click += new System.EventHandler(this.AllClosedReqtxt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartDT,
            this.BookName,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(54, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 227);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartDT1,
            this.BookName1,
            this.EndDT,
            this.Status1});
            this.dataGridView2.Location = new System.Drawing.Point(462, 139);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(375, 227);
            this.dataGridView2.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.homePageToolStripMenuItem.Text = "Home Page";
            this.homePageToolStripMenuItem.Click += new System.EventHandler(this.homePageToolStripMenuItem_Click);
            // 
            // StartDT
            // 
            this.StartDT.HeaderText = "Start Date";
            this.StartDT.Name = "StartDT";
            // 
            // BookName
            // 
            this.BookName.HeaderText = "Book Name";
            this.BookName.Name = "BookName";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // StartDT1
            // 
            this.StartDT1.HeaderText = "Start Date";
            this.StartDT1.Name = "StartDT1";
            // 
            // BookName1
            // 
            this.BookName1.HeaderText = "Book Name";
            this.BookName1.Name = "BookName1";
            // 
            // EndDT
            // 
            this.EndDT.HeaderText = "End Date";
            this.EndDT.Name = "EndDT";
            // 
            // Status1
            // 
            this.Status1.HeaderText = "Status";
            this.Status1.Name = "Status1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "The library is a brand, when you\'ve got a card in your hand";
            // 
            // StudentRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AllClosedReqtxt);
            this.Controls.Add(this.AllOpenReqtxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentRequests";
            this.Text = "Student Requests";
            this.Load += new System.EventHandler(this.StudentRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AllOpenReqtxt;
        private System.Windows.Forms.Label AllClosedReqtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status1;
        private System.Windows.Forms.Label label2;
    }
}