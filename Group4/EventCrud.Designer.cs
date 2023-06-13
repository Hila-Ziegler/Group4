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
            this.SpeakerName = new System.Windows.Forms.Label();
            this.GuestNameTextBox = new System.Windows.Forms.TextBox();
            this.MaxAttendance = new System.Windows.Forms.Label();
            this.OpenForRegistrationlbl = new System.Windows.Forms.Label();
            this.CurrentAtten = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.lb_MaxAttendanceValue = new System.Windows.Forms.Label();
            this.OpenForRegistrationValuelb = new System.Windows.Forms.Label();
            this.lb_CurrentAttendanceValue = new System.Windows.Forms.Label();
            this.lb_Date_value = new System.Windows.Forms.Label();
            this.GuestName = new System.Windows.Forms.Label();
            this.UpdateEvent = new System.Windows.Forms.Button();
            this.CreateNewEvent = new System.Windows.Forms.Button();
            this.DeleteEvent = new System.Windows.Forms.Button();
            this.RegisterBTN = new System.Windows.Forms.Button();
            this.EventDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EventPricelbl = new System.Windows.Forms.Label();
            this.numericMaxAttendance = new System.Windows.Forms.NumericUpDown();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.GuestTypelbl = new System.Windows.Forms.Label();
            this.GuestTypeValue = new System.Windows.Forms.Label();
            this.OpenForRegistrationCheckBox = new System.Windows.Forms.CheckBox();
            this.GuestTypeComboBox = new System.Windows.Forms.ComboBox();
            this.updateEventbtn = new System.Windows.Forms.Button();
            this.eventsPriceValuelbl = new System.Windows.Forms.Label();
            this.finalRatingScore = new System.Windows.Forms.Label();
            this.WatchReviews = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 553);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(548, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "The library is a brand, when you\'ve got a card in your hand";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(867, 31);
            this.menuStrip1.TabIndex = 7;
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
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(137, 27);
            this.backToolStripMenuItem.Text = "AvailableEvent";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // SpeakerName
            // 
            this.SpeakerName.AutoSize = true;
            this.SpeakerName.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeakerName.Location = new System.Drawing.Point(293, 37);
            this.SpeakerName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SpeakerName.Name = "SpeakerName";
            this.SpeakerName.Size = new System.Drawing.Size(119, 49);
            this.SpeakerName.TabIndex = 8;
            this.SpeakerName.Text = "Name";
            this.SpeakerName.Click += new System.EventHandler(this.BookCrudTitle_Click);
            // 
            // GuestNameTextBox
            // 
            this.GuestNameTextBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestNameTextBox.Location = new System.Drawing.Point(413, 122);
            this.GuestNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.GuestNameTextBox.Name = "GuestNameTextBox";
            this.GuestNameTextBox.Size = new System.Drawing.Size(169, 27);
            this.GuestNameTextBox.TabIndex = 45;
            // 
            // MaxAttendance
            // 
            this.MaxAttendance.AutoSize = true;
            this.MaxAttendance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxAttendance.Location = new System.Drawing.Point(105, 241);
            this.MaxAttendance.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MaxAttendance.Name = "MaxAttendance";
            this.MaxAttendance.Size = new System.Drawing.Size(157, 26);
            this.MaxAttendance.TabIndex = 30;
            this.MaxAttendance.Text = "Max Attendance";
            // 
            // OpenForRegistrationlbl
            // 
            this.OpenForRegistrationlbl.AutoSize = true;
            this.OpenForRegistrationlbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenForRegistrationlbl.Location = new System.Drawing.Point(105, 277);
            this.OpenForRegistrationlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.OpenForRegistrationlbl.Name = "OpenForRegistrationlbl";
            this.OpenForRegistrationlbl.Size = new System.Drawing.Size(209, 26);
            this.OpenForRegistrationlbl.TabIndex = 31;
            this.OpenForRegistrationlbl.Text = "Open For Registration";
            // 
            // CurrentAtten
            // 
            this.CurrentAtten.AutoSize = true;
            this.CurrentAtten.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentAtten.Location = new System.Drawing.Point(105, 313);
            this.CurrentAtten.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CurrentAtten.Name = "CurrentAtten";
            this.CurrentAtten.Size = new System.Drawing.Size(198, 26);
            this.CurrentAtten.TabIndex = 32;
            this.CurrentAtten.Text = "Currently Registered";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(105, 168);
            this.Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(54, 26);
            this.Date.TabIndex = 34;
            this.Date.Text = "Date";
            // 
            // lb_MaxAttendanceValue
            // 
            this.lb_MaxAttendanceValue.AutoSize = true;
            this.lb_MaxAttendanceValue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaxAttendanceValue.Location = new System.Drawing.Point(333, 241);
            this.lb_MaxAttendanceValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_MaxAttendanceValue.Name = "lb_MaxAttendanceValue";
            this.lb_MaxAttendanceValue.Size = new System.Drawing.Size(0, 26);
            this.lb_MaxAttendanceValue.TabIndex = 35;
            // 
            // OpenForRegistrationValuelb
            // 
            this.OpenForRegistrationValuelb.AutoSize = true;
            this.OpenForRegistrationValuelb.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenForRegistrationValuelb.Location = new System.Drawing.Point(333, 277);
            this.OpenForRegistrationValuelb.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.OpenForRegistrationValuelb.Name = "OpenForRegistrationValuelb";
            this.OpenForRegistrationValuelb.Size = new System.Drawing.Size(0, 26);
            this.OpenForRegistrationValuelb.TabIndex = 36;
            // 
            // lb_CurrentAttendanceValue
            // 
            this.lb_CurrentAttendanceValue.AutoSize = true;
            this.lb_CurrentAttendanceValue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CurrentAttendanceValue.Location = new System.Drawing.Point(332, 313);
            this.lb_CurrentAttendanceValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_CurrentAttendanceValue.Name = "lb_CurrentAttendanceValue";
            this.lb_CurrentAttendanceValue.Size = new System.Drawing.Size(0, 26);
            this.lb_CurrentAttendanceValue.TabIndex = 37;
            // 
            // lb_Date_value
            // 
            this.lb_Date_value.AutoSize = true;
            this.lb_Date_value.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date_value.Location = new System.Drawing.Point(333, 163);
            this.lb_Date_value.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Date_value.Name = "lb_Date_value";
            this.lb_Date_value.Size = new System.Drawing.Size(0, 26);
            this.lb_Date_value.TabIndex = 39;
            // 
            // GuestName
            // 
            this.GuestName.AutoSize = true;
            this.GuestName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestName.Location = new System.Drawing.Point(105, 125);
            this.GuestName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GuestName.Name = "GuestName";
            this.GuestName.Size = new System.Drawing.Size(122, 26);
            this.GuestName.TabIndex = 44;
            this.GuestName.Text = "Guest Name";
            this.GuestName.Click += new System.EventHandler(this.Titlelbl_Click);
            // 
            // UpdateEvent
            // 
            this.UpdateEvent.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateEvent.Location = new System.Drawing.Point(117, 463);
            this.UpdateEvent.Margin = new System.Windows.Forms.Padding(5);
            this.UpdateEvent.Name = "UpdateEvent";
            this.UpdateEvent.Size = new System.Drawing.Size(137, 63);
            this.UpdateEvent.TabIndex = 46;
            this.UpdateEvent.Text = "Update Event";
            this.UpdateEvent.UseVisualStyleBackColor = true;
            this.UpdateEvent.Click += new System.EventHandler(this.UpdateEvent_Click);
            // 
            // CreateNewEvent
            // 
            this.CreateNewEvent.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewEvent.Location = new System.Drawing.Point(326, 463);
            this.CreateNewEvent.Margin = new System.Windows.Forms.Padding(4);
            this.CreateNewEvent.Name = "CreateNewEvent";
            this.CreateNewEvent.Size = new System.Drawing.Size(145, 67);
            this.CreateNewEvent.TabIndex = 47;
            this.CreateNewEvent.Text = "Create New Event";
            this.CreateNewEvent.UseVisualStyleBackColor = true;
            this.CreateNewEvent.Click += new System.EventHandler(this.CreateNewEvent_Click);
            // 
            // DeleteEvent
            // 
            this.DeleteEvent.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEvent.Location = new System.Drawing.Point(545, 463);
            this.DeleteEvent.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteEvent.Name = "DeleteEvent";
            this.DeleteEvent.Size = new System.Drawing.Size(100, 63);
            this.DeleteEvent.TabIndex = 49;
            this.DeleteEvent.Text = "Delete Event";
            this.DeleteEvent.UseVisualStyleBackColor = true;
            this.DeleteEvent.Click += new System.EventHandler(this.DeleteEvent_Click);
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBTN.Location = new System.Drawing.Point(326, 464);
            this.RegisterBTN.Margin = new System.Windows.Forms.Padding(5);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.Size = new System.Drawing.Size(145, 65);
            this.RegisterBTN.TabIndex = 50;
            this.RegisterBTN.Text = "Register For Event";
            this.RegisterBTN.UseVisualStyleBackColor = true;
            this.RegisterBTN.Click += new System.EventHandler(this.RegisterBTN_Click);
            // 
            // EventDatePicker
            // 
            this.EventDatePicker.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventDatePicker.Location = new System.Drawing.Point(413, 163);
            this.EventDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.EventDatePicker.Name = "EventDatePicker";
            this.EventDatePicker.Size = new System.Drawing.Size(308, 27);
            this.EventDatePicker.TabIndex = 51;
            // 
            // EventPricelbl
            // 
            this.EventPricelbl.AutoSize = true;
            this.EventPricelbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventPricelbl.Location = new System.Drawing.Point(105, 345);
            this.EventPricelbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.EventPricelbl.Name = "EventPricelbl";
            this.EventPricelbl.Size = new System.Drawing.Size(126, 26);
            this.EventPricelbl.TabIndex = 52;
            this.EventPricelbl.Text = "Event\'s Price";
            // 
            // numericMaxAttendance
            // 
            this.numericMaxAttendance.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericMaxAttendance.Location = new System.Drawing.Point(413, 241);
            this.numericMaxAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.numericMaxAttendance.Name = "numericMaxAttendance";
            this.numericMaxAttendance.Size = new System.Drawing.Size(160, 27);
            this.numericMaxAttendance.TabIndex = 53;
            // 
            // numericPrice
            // 
            this.numericPrice.DecimalPlaces = 2;
            this.numericPrice.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPrice.Location = new System.Drawing.Point(411, 345);
            this.numericPrice.Margin = new System.Windows.Forms.Padding(4);
            this.numericPrice.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(160, 27);
            this.numericPrice.TabIndex = 54;
            // 
            // GuestTypelbl
            // 
            this.GuestTypelbl.AutoSize = true;
            this.GuestTypelbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestTypelbl.Location = new System.Drawing.Point(105, 200);
            this.GuestTypelbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.GuestTypelbl.Name = "GuestTypelbl";
            this.GuestTypelbl.Size = new System.Drawing.Size(112, 26);
            this.GuestTypelbl.TabIndex = 55;
            this.GuestTypelbl.Text = "Guest Type";
            // 
            // GuestTypeValue
            // 
            this.GuestTypeValue.AutoSize = true;
            this.GuestTypeValue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestTypeValue.Location = new System.Drawing.Point(332, 196);
            this.GuestTypeValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.GuestTypeValue.Name = "GuestTypeValue";
            this.GuestTypeValue.Size = new System.Drawing.Size(0, 26);
            this.GuestTypeValue.TabIndex = 57;
            // 
            // OpenForRegistrationCheckBox
            // 
            this.OpenForRegistrationCheckBox.AutoSize = true;
            this.OpenForRegistrationCheckBox.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenForRegistrationCheckBox.Location = new System.Drawing.Point(413, 279);
            this.OpenForRegistrationCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.OpenForRegistrationCheckBox.Name = "OpenForRegistrationCheckBox";
            this.OpenForRegistrationCheckBox.Size = new System.Drawing.Size(18, 17);
            this.OpenForRegistrationCheckBox.TabIndex = 58;
            this.OpenForRegistrationCheckBox.UseVisualStyleBackColor = true;
            // 
            // GuestTypeComboBox
            // 
            this.GuestTypeComboBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestTypeComboBox.FormattingEnabled = true;
            this.GuestTypeComboBox.Location = new System.Drawing.Point(411, 197);
            this.GuestTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.GuestTypeComboBox.Name = "GuestTypeComboBox";
            this.GuestTypeComboBox.Size = new System.Drawing.Size(160, 31);
            this.GuestTypeComboBox.TabIndex = 60;
            this.GuestTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.GuestTypeComboBox_SelectedIndexChanged);
            // 
            // updateEventbtn
            // 
            this.updateEventbtn.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEventbtn.Location = new System.Drawing.Point(673, 247);
            this.updateEventbtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateEventbtn.Name = "updateEventbtn";
            this.updateEventbtn.Size = new System.Drawing.Size(100, 49);
            this.updateEventbtn.TabIndex = 61;
            this.updateEventbtn.Text = "Update";
            this.updateEventbtn.UseVisualStyleBackColor = true;
            this.updateEventbtn.Click += new System.EventHandler(this.updateEventbtn_Click);
            // 
            // eventsPriceValuelbl
            // 
            this.eventsPriceValuelbl.AutoSize = true;
            this.eventsPriceValuelbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsPriceValuelbl.Location = new System.Drawing.Point(332, 345);
            this.eventsPriceValuelbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.eventsPriceValuelbl.Name = "eventsPriceValuelbl";
            this.eventsPriceValuelbl.Size = new System.Drawing.Size(0, 26);
            this.eventsPriceValuelbl.TabIndex = 62;
            // 
            // finalRatingScore
            // 
            this.finalRatingScore.AutoSize = true;
            this.finalRatingScore.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalRatingScore.Location = new System.Drawing.Point(620, 62);
            this.finalRatingScore.Name = "finalRatingScore";
            this.finalRatingScore.Size = new System.Drawing.Size(111, 24);
            this.finalRatingScore.TabIndex = 63;
            this.finalRatingScore.Text = "Final Rating";
            this.finalRatingScore.Click += new System.EventHandler(this.finalRatingScore_Click);
            // 
            // WatchReviews
            // 
            this.WatchReviews.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WatchReviews.Location = new System.Drawing.Point(624, 90);
            this.WatchReviews.Margin = new System.Windows.Forms.Padding(4);
            this.WatchReviews.Name = "WatchReviews";
            this.WatchReviews.Size = new System.Drawing.Size(182, 53);
            this.WatchReviews.TabIndex = 64;
            this.WatchReviews.Text = "Watch Reviews";
            this.WatchReviews.UseVisualStyleBackColor = true;
            this.WatchReviews.Click += new System.EventHandler(this.WatchReviews_Click);
            // 
            // EventCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(867, 600);
            this.Controls.Add(this.WatchReviews);
            this.Controls.Add(this.finalRatingScore);
            this.Controls.Add(this.eventsPriceValuelbl);
            this.Controls.Add(this.updateEventbtn);
            this.Controls.Add(this.GuestTypeComboBox);
            this.Controls.Add(this.OpenForRegistrationCheckBox);
            this.Controls.Add(this.GuestTypeValue);
            this.Controls.Add(this.GuestTypelbl);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.numericMaxAttendance);
            this.Controls.Add(this.EventPricelbl);
            this.Controls.Add(this.EventDatePicker);
            this.Controls.Add(this.RegisterBTN);
            this.Controls.Add(this.DeleteEvent);
            this.Controls.Add(this.CreateNewEvent);
            this.Controls.Add(this.UpdateEvent);
            this.Controls.Add(this.GuestNameTextBox);
            this.Controls.Add(this.GuestName);
            this.Controls.Add(this.lb_Date_value);
            this.Controls.Add(this.lb_CurrentAttendanceValue);
            this.Controls.Add(this.OpenForRegistrationValuelb);
            this.Controls.Add(this.lb_MaxAttendanceValue);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.CurrentAtten);
            this.Controls.Add(this.OpenForRegistrationlbl);
            this.Controls.Add(this.MaxAttendance);
            this.Controls.Add(this.SpeakerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EventCrud";
            this.Text = "Event";
            this.Load += new System.EventHandler(this.EventCrud_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label SpeakerName;
        private System.Windows.Forms.TextBox GuestNameTextBox;
        private System.Windows.Forms.Label MaxAttendance;
        private System.Windows.Forms.Label OpenForRegistrationlbl;
        private System.Windows.Forms.Label CurrentAtten;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label lb_MaxAttendanceValue;
        private System.Windows.Forms.Label OpenForRegistrationValuelb;
        private System.Windows.Forms.Label lb_CurrentAttendanceValue;
        private System.Windows.Forms.Label lb_Date_value;
        private System.Windows.Forms.Label GuestName;
        private System.Windows.Forms.Button UpdateEvent;
        private System.Windows.Forms.Button CreateNewEvent;
        private System.Windows.Forms.Button DeleteEvent;
        private System.Windows.Forms.Button RegisterBTN;
        private System.Windows.Forms.DateTimePicker EventDatePicker;
        private System.Windows.Forms.Label EventPricelbl;
        private System.Windows.Forms.NumericUpDown numericMaxAttendance;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.Label GuestTypelbl;
        private System.Windows.Forms.Label GuestTypeValue;
        private System.Windows.Forms.CheckBox OpenForRegistrationCheckBox;
        private System.Windows.Forms.ComboBox GuestTypeComboBox;
        private System.Windows.Forms.Button updateEventbtn;
        private System.Windows.Forms.Label eventsPriceValuelbl;
        private System.Windows.Forms.Label finalRatingScore;
        private System.Windows.Forms.Button WatchReviews;
    }
}