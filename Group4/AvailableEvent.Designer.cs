namespace Group4
{
    partial class AvailableEvent
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EventName = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Guest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCrudTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateNewEvent = new System.Windows.Forms.Button();
            this.ShowPastEvents = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.homePageToolStripMenuItem.Text = "Home Page";
            this.homePageToolStripMenuItem.Click += new System.EventHandler(this.homePageToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventName,
            this.Guest,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(158, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(428, 155);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Event Name";
            this.EventName.MinimumWidth = 6;
            this.EventName.Name = "EventName";
            this.EventName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EventName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EventName.Width = 125;
            // 
            // Guest
            // 
            this.Guest.HeaderText = "Guest";
            this.Guest.MinimumWidth = 6;
            this.Guest.Name = "Guest";
            this.Guest.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // BookCrudTitle
            // 
            this.BookCrudTitle.AutoSize = true;
            this.BookCrudTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCrudTitle.Location = new System.Drawing.Point(218, 58);
            this.BookCrudTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookCrudTitle.Name = "BookCrudTitle";
            this.BookCrudTitle.Size = new System.Drawing.Size(305, 42);
            this.BookCrudTitle.TabIndex = 2;
            this.BookCrudTitle.Text = "Available Events:";
            this.BookCrudTitle.Click += new System.EventHandler(this.BookCrudTitle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 419);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "The library is a brand, when you\'ve got a card in your hand";
            // 
            // CreateNewEvent
            // 
            this.CreateNewEvent.Location = new System.Drawing.Point(158, 350);
            this.CreateNewEvent.Margin = new System.Windows.Forms.Padding(4);
            this.CreateNewEvent.Name = "CreateNewEvent";
            this.CreateNewEvent.Size = new System.Drawing.Size(133, 28);
            this.CreateNewEvent.TabIndex = 7;
            this.CreateNewEvent.Text = "Create New Event";
            this.CreateNewEvent.UseVisualStyleBackColor = true;
            this.CreateNewEvent.Click += new System.EventHandler(this.CreateNewEvent_Click);
            // 
            // ShowPastEvents
            // 
            this.ShowPastEvents.Location = new System.Drawing.Point(455, 350);
            this.ShowPastEvents.Margin = new System.Windows.Forms.Padding(4);
            this.ShowPastEvents.Name = "ShowPastEvents";
            this.ShowPastEvents.Size = new System.Drawing.Size(131, 28);
            this.ShowPastEvents.TabIndex = 8;
            this.ShowPastEvents.Text = "Show Past Events";
            this.ShowPastEvents.UseVisualStyleBackColor = true;
            // 
            // AvailableEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.ShowPastEvents);
            this.Controls.Add(this.CreateNewEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookCrudTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AvailableEvent";
            this.Text = "StudentEvent";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label BookCrudTitle;
        private System.Windows.Forms.DataGridViewButtonColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateNewEvent;
        private System.Windows.Forms.Button ShowPastEvents;
    }
}