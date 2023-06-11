namespace Group4
{
    partial class StudentChooseAction
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
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tlxWalcome = new System.Windows.Forms.Label();
            this.Action = new System.Windows.Forms.Label();
            this.readingGoalsbtn = new System.Windows.Forms.Button();
            this.btnSocialPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBooks
            // 
            this.btnBooks.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.Location = new System.Drawing.Point(126, 341);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(298, 57);
            this.btnBooks.TabIndex = 3;
            this.btnBooks.Text = "Book History";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnEvent
            // 
            this.btnEvent.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvent.Location = new System.Drawing.Point(13, 224);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(235, 57);
            this.btnEvent.TabIndex = 4;
            this.btnEvent.Text = "Events";
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 426);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "The library is a brand, when you\'ve got a card in your hand";
            // 
            // tlxWalcome
            // 
            this.tlxWalcome.AutoSize = true;
            this.tlxWalcome.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlxWalcome.Location = new System.Drawing.Point(27, 52);
            this.tlxWalcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tlxWalcome.Name = "tlxWalcome";
            this.tlxWalcome.Size = new System.Drawing.Size(230, 59);
            this.tlxWalcome.TabIndex = 6;
            this.tlxWalcome.Text = "Welcome ";
            // 
            // Action
            // 
            this.Action.AutoSize = true;
            this.Action.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Action.Location = new System.Drawing.Point(373, 235);
            this.Action.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(322, 36);
            this.Action.TabIndex = 7;
            this.Action.Text = "Please choose an action:";
            // 
            // readingGoalsbtn
            // 
            this.readingGoalsbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readingGoalsbtn.Location = new System.Drawing.Point(610, 341);
            this.readingGoalsbtn.Name = "readingGoalsbtn";
            this.readingGoalsbtn.Size = new System.Drawing.Size(298, 57);
            this.readingGoalsbtn.TabIndex = 9;
            this.readingGoalsbtn.Text = "Reading Goals";
            this.readingGoalsbtn.UseVisualStyleBackColor = true;
            this.readingGoalsbtn.Click += new System.EventHandler(this.readingGoalsbtn_Click);
            // 
            // btnSocialPage
            // 
            this.btnSocialPage.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSocialPage.Location = new System.Drawing.Point(820, 235);
            this.btnSocialPage.Name = "btnSocialPage";
            this.btnSocialPage.Size = new System.Drawing.Size(235, 57);
            this.btnSocialPage.TabIndex = 10;
            this.btnSocialPage.Text = "Social Page";
            this.btnSocialPage.UseVisualStyleBackColor = true;
            this.btnSocialPage.Click += new System.EventHandler(this.btnSocialPage_Click);
            // 
            // StudentChooseAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1076, 463);
            this.Controls.Add(this.btnSocialPage);
            this.Controls.Add(this.readingGoalsbtn);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.tlxWalcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.btnBooks);
            this.Name = "StudentChooseAction";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.StudentChooseAction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tlxWalcome;
        private System.Windows.Forms.Label Action;
        private System.Windows.Forms.Button readingGoalsbtn;
        private System.Windows.Forms.Button btnSocialPage;
    }
}