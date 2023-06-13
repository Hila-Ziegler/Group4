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
            this.GuestName = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentlyRegistered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxGuests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCrudTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateNewEvent = new System.Windows.Forms.Button();
            this.ShowPastEvents = new System.Windows.Forms.Button();
            this.btnFutureEvents = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(912, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.homePageToolStripMenuItem.Text = "Home Page";
            this.homePageToolStripMenuItem.Click += new System.EventHandler(this.homePageToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GuestName,
            this.Date,
            this.CurrentlyRegistered,
            this.MaxGuests,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(60, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 140);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GuestName
            // 
            this.GuestName.HeaderText = "Guest Name";
            this.GuestName.MinimumWidth = 6;
            this.GuestName.Name = "GuestName";
            this.GuestName.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // CurrentlyRegistered
            // 
            this.CurrentlyRegistered.HeaderText = "Currently Registered";
            this.CurrentlyRegistered.MinimumWidth = 6;
            this.CurrentlyRegistered.Name = "CurrentlyRegistered";
            this.CurrentlyRegistered.Width = 125;
            // 
            // MaxGuests
            // 
            this.MaxGuests.HeaderText = "Max Guests";
            this.MaxGuests.MinimumWidth = 6;
            this.MaxGuests.Name = "MaxGuests";
            this.MaxGuests.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // BookCrudTitle
            // 
            this.BookCrudTitle.AutoSize = true;
            this.BookCrudTitle.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCrudTitle.Location = new System.Drawing.Point(155, 54);
            this.BookCrudTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookCrudTitle.Name = "BookCrudTitle";
            this.BookCrudTitle.Size = new System.Drawing.Size(303, 46);
            this.BookCrudTitle.TabIndex = 2;
            this.BookCrudTitle.Text = "Available Events:";
            this.BookCrudTitle.Click += new System.EventHandler(this.BookCrudTitle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 420);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(548, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "The library is a brand, when you\'ve got a card in your hand";
            // 
            // CreateNewEvent
            // 
            this.CreateNewEvent.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewEvent.Location = new System.Drawing.Point(95, 346);
            this.CreateNewEvent.Margin = new System.Windows.Forms.Padding(4);
            this.CreateNewEvent.Name = "CreateNewEvent";
            this.CreateNewEvent.Size = new System.Drawing.Size(208, 49);
            this.CreateNewEvent.TabIndex = 7;
            this.CreateNewEvent.Text = "Create New Event";
            this.CreateNewEvent.UseVisualStyleBackColor = true;
            this.CreateNewEvent.Click += new System.EventHandler(this.CreateNewEvent_Click);
            // 
            // ShowPastEvents
            // 
            this.ShowPastEvents.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPastEvents.Location = new System.Drawing.Point(335, 346);
            this.ShowPastEvents.Margin = new System.Windows.Forms.Padding(4);
            this.ShowPastEvents.Name = "ShowPastEvents";
            this.ShowPastEvents.Size = new System.Drawing.Size(207, 49);
            this.ShowPastEvents.TabIndex = 8;
            this.ShowPastEvents.Text = "Show Past Events";
            this.ShowPastEvents.UseVisualStyleBackColor = true;
            this.ShowPastEvents.Click += new System.EventHandler(this.ShowPastEvents_Click);
            // 
            // btnFutureEvents
            // 
            this.btnFutureEvents.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFutureEvents.Location = new System.Drawing.Point(572, 346);
            this.btnFutureEvents.Margin = new System.Windows.Forms.Padding(4);
            this.btnFutureEvents.Name = "btnFutureEvents";
            this.btnFutureEvents.Size = new System.Drawing.Size(193, 49);
            this.btnFutureEvents.TabIndex = 9;
            this.btnFutureEvents.Text = "Show Future Events";
            this.btnFutureEvents.UseVisualStyleBackColor = true;
            this.btnFutureEvents.Click += new System.EventHandler(this.btnFutureEvents_Click);
            // 
            // AvailableEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(912, 492);
            this.Controls.Add(this.btnFutureEvents);
            this.Controls.Add(this.ShowPastEvents);
            this.Controls.Add(this.CreateNewEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookCrudTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AvailableEvent";
            this.Text = "Available Events";
            this.Load += new System.EventHandler(this.AvailableEvent_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateNewEvent;
        private System.Windows.Forms.DataGridViewButtonColumn GuestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentlyRegistered;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxGuests;
        private System.Windows.Forms.Button btnFutureEvents;
        private System.Windows.Forms.Button ShowPastEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}