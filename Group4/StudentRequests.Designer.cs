
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
            this.StartDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1129, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.homePageToolStripMenuItem.Text = "Home Page";
            this.homePageToolStripMenuItem.Click += new System.EventHandler(this.homePageToolStripMenuItem_Click_1);
            // 
            // AllOpenReqtxt
            // 
            this.AllOpenReqtxt.AutoSize = true;
            this.AllOpenReqtxt.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllOpenReqtxt.Location = new System.Drawing.Point(72, 118);
            this.AllOpenReqtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllOpenReqtxt.Name = "AllOpenReqtxt";
            this.AllOpenReqtxt.Size = new System.Drawing.Size(180, 26);
            this.AllOpenReqtxt.TabIndex = 1;
            this.AllOpenReqtxt.Text = "All Open Requests:";
            // 
            // AllFinishedRedtxt
            // 
            this.AllFinishedRedtxt.AutoSize = true;
            this.AllFinishedRedtxt.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllFinishedRedtxt.Location = new System.Drawing.Point(569, 118);
            this.AllFinishedRedtxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllFinishedRedtxt.Name = "AllFinishedRedtxt";
            this.AllFinishedRedtxt.Size = new System.Drawing.Size(209, 26);
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
            this.dataGridView1.Location = new System.Drawing.Point(76, 183);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(440, 185);
            this.dataGridView1.TabIndex = 3;
            // 
            // StartDT
            // 
            this.StartDT.HeaderText = "Start Date";
            this.StartDT.MinimumWidth = 6;
            this.StartDT.Name = "StartDT";
            this.StartDT.Width = 125;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "Book Name";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartDT1,
            this.BookName1,
            this.EndDT,
            this.Status1});
            this.dataGridView2.Location = new System.Drawing.Point(573, 183);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(424, 185);
            this.dataGridView2.TabIndex = 4;
            // 
            // StartDT1
            // 
            this.StartDT1.HeaderText = "Start Date";
            this.StartDT1.MinimumWidth = 6;
            this.StartDT1.Name = "StartDT1";
            this.StartDT1.Width = 125;
            // 
            // BookName1
            // 
            this.BookName1.HeaderText = "Book Name";
            this.BookName1.MinimumWidth = 6;
            this.BookName1.Name = "BookName1";
            this.BookName1.Width = 125;
            // 
            // EndDT
            // 
            this.EndDT.HeaderText = "End Date";
            this.EndDT.MinimumWidth = 6;
            this.EndDT.Name = "EndDT";
            this.EndDT.Width = 125;
            // 
            // Status1
            // 
            this.Status1.HeaderText = "Status";
            this.Status1.MinimumWidth = 6;
            this.Status1.Name = "Status1";
            this.Status1.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 486);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "The library is a brand, when you\'ve got a card in your hand";
            // 
            // StudentRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1129, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AllFinishedRedtxt);
            this.Controls.Add(this.AllOpenReqtxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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