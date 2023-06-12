
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllOpenReqtxt = new System.Windows.Forms.Label();
            this.AllFinishedRedtxt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.StartDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.homePageToolStripMenuItem.Text = "Home Page";
            // 
            // AllOpenReqtxt
            // 
            this.AllOpenReqtxt.AutoSize = true;
            this.AllOpenReqtxt.Location = new System.Drawing.Point(54, 96);
            this.AllOpenReqtxt.Name = "AllOpenReqtxt";
            this.AllOpenReqtxt.Size = new System.Drawing.Size(98, 13);
            this.AllOpenReqtxt.TabIndex = 1;
            this.AllOpenReqtxt.Text = "All Open Requests:";
            // 
            // AllFinishedRedtxt
            // 
            this.AllFinishedRedtxt.AutoSize = true;
            this.AllFinishedRedtxt.Location = new System.Drawing.Point(427, 96);
            this.AllFinishedRedtxt.Name = "AllFinishedRedtxt";
            this.AllFinishedRedtxt.Size = new System.Drawing.Size(111, 13);
            this.AllFinishedRedtxt.TabIndex = 2;
            this.AllFinishedRedtxt.Text = "All Finished Requests:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartDT,
            this.BookName,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(57, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(330, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartDT1,
            this.BookName1,
            this.EndDT,
            this.Status1});
            this.dataGridView2.Location = new System.Drawing.Point(430, 149);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(318, 150);
            this.dataGridView2.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "The library is a brand, when you\'ve got a card in your hand";
            // 
            // StudentRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AllFinishedRedtxt);
            this.Controls.Add(this.AllOpenReqtxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentRequests";
            this.Text = "StudentRequests";
            this.Load += new System.EventHandler(this.StudentRequests_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.Label AllOpenReqtxt;
        private System.Windows.Forms.Label AllFinishedRedtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status1;
        private System.Windows.Forms.Label label1;
    }
}