namespace Group4
{
    partial class EventCrud
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
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BookCrudTitle = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.MaxAttendance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentAtten = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.lb_AuthorValue = new System.Windows.Forms.Label();
            this.lb_PublishYearValue = new System.Windows.Forms.Label();
            this.lb_LangueageValue = new System.Windows.Forms.Label();
            this.lb_ISBN_value = new System.Windows.Forms.Label();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.PublishYearTextBox = new System.Windows.Forms.TextBox();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.GuestName = new System.Windows.Forms.Label();
            this.UpdateEvent = new System.Windows.Forms.Button();
            this.CreateNewEvent = new System.Windows.Forms.Button();
            this.DeleteEvent = new System.Windows.Forms.Button();
            this.RegisterBTN = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 20);
            this.label2.TabIndex = 6;
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(669, 24);
            this.menuStrip1.TabIndex = 7;
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
            this.backToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.backToolStripMenuItem.Text = "AvailableEvent";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // BookCrudTitle
            // 
            this.BookCrudTitle.AutoSize = true;
            this.BookCrudTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCrudTitle.Location = new System.Drawing.Point(286, 33);
            this.BookCrudTitle.Name = "BookCrudTitle";
            this.BookCrudTitle.Size = new System.Drawing.Size(93, 33);
            this.BookCrudTitle.TabIndex = 8;
            this.BookCrudTitle.Text = "Name";
            this.BookCrudTitle.Click += new System.EventHandler(this.BookCrudTitle_Click);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(353, 89);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(97, 20);
            this.TitleTextBox.TabIndex = 45;
            // 
            // MaxAttendance
            // 
            this.MaxAttendance.AutoSize = true;
            this.MaxAttendance.Location = new System.Drawing.Point(180, 144);
            this.MaxAttendance.Name = "MaxAttendance";
            this.MaxAttendance.Size = new System.Drawing.Size(85, 13);
            this.MaxAttendance.TabIndex = 30;
            this.MaxAttendance.Text = "Max Attendance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Available For Registry";
            // 
            // CurrentAtten
            // 
            this.CurrentAtten.AutoSize = true;
            this.CurrentAtten.Location = new System.Drawing.Point(180, 198);
            this.CurrentAtten.Name = "CurrentAtten";
            this.CurrentAtten.Size = new System.Drawing.Size(99, 13);
            this.CurrentAtten.TabIndex = 32;
            this.CurrentAtten.Text = "Current Attendance";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(180, 116);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 34;
            this.Date.Text = "Date";
            // 
            // lb_AuthorValue
            // 
            this.lb_AuthorValue.AutoSize = true;
            this.lb_AuthorValue.Location = new System.Drawing.Point(302, 144);
            this.lb_AuthorValue.Name = "lb_AuthorValue";
            this.lb_AuthorValue.Size = new System.Drawing.Size(0, 13);
            this.lb_AuthorValue.TabIndex = 35;
            // 
            // lb_PublishYearValue
            // 
            this.lb_PublishYearValue.AutoSize = true;
            this.lb_PublishYearValue.Location = new System.Drawing.Point(302, 168);
            this.lb_PublishYearValue.Name = "lb_PublishYearValue";
            this.lb_PublishYearValue.Size = new System.Drawing.Size(0, 13);
            this.lb_PublishYearValue.TabIndex = 36;
            // 
            // lb_LangueageValue
            // 
            this.lb_LangueageValue.AutoSize = true;
            this.lb_LangueageValue.Location = new System.Drawing.Point(302, 198);
            this.lb_LangueageValue.Name = "lb_LangueageValue";
            this.lb_LangueageValue.Size = new System.Drawing.Size(0, 13);
            this.lb_LangueageValue.TabIndex = 37;
            // 
            // lb_ISBN_value
            // 
            this.lb_ISBN_value.AutoSize = true;
            this.lb_ISBN_value.Location = new System.Drawing.Point(302, 116);
            this.lb_ISBN_value.Name = "lb_ISBN_value";
            this.lb_ISBN_value.Size = new System.Drawing.Size(0, 13);
            this.lb_ISBN_value.TabIndex = 39;
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(353, 116);
            this.ISBNTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(97, 20);
            this.ISBNTextBox.TabIndex = 40;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(353, 141);
            this.AuthorTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(97, 20);
            this.AuthorTextBox.TabIndex = 41;
            // 
            // PublishYearTextBox
            // 
            this.PublishYearTextBox.Location = new System.Drawing.Point(353, 168);
            this.PublishYearTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PublishYearTextBox.Name = "PublishYearTextBox";
            this.PublishYearTextBox.Size = new System.Drawing.Size(97, 20);
            this.PublishYearTextBox.TabIndex = 42;
            // 
            // languageTextBox
            // 
            this.languageTextBox.Location = new System.Drawing.Point(353, 196);
            this.languageTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.Size = new System.Drawing.Size(97, 20);
            this.languageTextBox.TabIndex = 43;
            // 
            // GuestName
            // 
            this.GuestName.AutoSize = true;
            this.GuestName.Location = new System.Drawing.Point(180, 92);
            this.GuestName.Name = "GuestName";
            this.GuestName.Size = new System.Drawing.Size(66, 13);
            this.GuestName.TabIndex = 44;
            this.GuestName.Text = "Guest Name";
            this.GuestName.Click += new System.EventHandler(this.Titlelbl_Click);
            // 
            // UpdateEvent
            // 
            this.UpdateEvent.Location = new System.Drawing.Point(154, 307);
            this.UpdateEvent.Name = "UpdateEvent";
            this.UpdateEvent.Size = new System.Drawing.Size(103, 23);
            this.UpdateEvent.TabIndex = 46;
            this.UpdateEvent.Text = "Update Event";
            this.UpdateEvent.UseVisualStyleBackColor = true;
            // 
            // CreateNewEvent
            // 
            this.CreateNewEvent.Location = new System.Drawing.Point(304, 307);
            this.CreateNewEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateNewEvent.Name = "CreateNewEvent";
            this.CreateNewEvent.Size = new System.Drawing.Size(109, 23);
            this.CreateNewEvent.TabIndex = 47;
            this.CreateNewEvent.Text = "Create New Event";
            this.CreateNewEvent.UseVisualStyleBackColor = true;
            // 
            // DeleteEvent
            // 
            this.DeleteEvent.Location = new System.Drawing.Point(467, 307);
            this.DeleteEvent.Name = "DeleteEvent";
            this.DeleteEvent.Size = new System.Drawing.Size(75, 23);
            this.DeleteEvent.TabIndex = 49;
            this.DeleteEvent.Text = "Delete Event";
            this.DeleteEvent.UseVisualStyleBackColor = true;
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.Location = new System.Drawing.Point(304, 263);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.Size = new System.Drawing.Size(109, 21);
            this.RegisterBTN.TabIndex = 50;
            this.RegisterBTN.Text = "Register For Event";
            this.RegisterBTN.UseVisualStyleBackColor = true;
            // 
            // EventCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 453);
            this.Controls.Add(this.RegisterBTN);
            this.Controls.Add(this.DeleteEvent);
            this.Controls.Add(this.CreateNewEvent);
            this.Controls.Add(this.UpdateEvent);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.GuestName);
            this.Controls.Add(this.languageTextBox);
            this.Controls.Add(this.PublishYearTextBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.lb_ISBN_value);
            this.Controls.Add(this.lb_LangueageValue);
            this.Controls.Add(this.lb_PublishYearValue);
            this.Controls.Add(this.lb_AuthorValue);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.CurrentAtten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaxAttendance);
            this.Controls.Add(this.BookCrudTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EventCrud";
            this.Text = "s";
            this.Load += new System.EventHandler(this.EventCrud_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label BookCrudTitle;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label MaxAttendance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CurrentAtten;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label lb_AuthorValue;
        private System.Windows.Forms.Label lb_PublishYearValue;
        private System.Windows.Forms.Label lb_LangueageValue;
        private System.Windows.Forms.Label lb_ISBN_value;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox PublishYearTextBox;
        private System.Windows.Forms.TextBox languageTextBox;
        private System.Windows.Forms.Label GuestName;
        private System.Windows.Forms.Button UpdateEvent;
        private System.Windows.Forms.Button CreateNewEvent;
        private System.Windows.Forms.Button DeleteEvent;
        private System.Windows.Forms.Button RegisterBTN;
    }
}