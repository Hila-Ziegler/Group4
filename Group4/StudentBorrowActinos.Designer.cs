namespace Group4
{
    partial class StudentBorrowActinos
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
            System.Windows.Forms.Button RequestTimeExtention;
            this.BookCrudTitle = new System.Windows.Forms.Label();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.lb_ISBN_value = new System.Windows.Forms.Label();
            this.lb_RatingValue = new System.Windows.Forms.Label();
            this.lb_LangueageValue = new System.Windows.Forms.Label();
            this.lb_PublishYearValue = new System.Windows.Forms.Label();
            this.lb_AuthorValue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Ratinglbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuggestAlternativeBook = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.RatingCB = new System.Windows.Forms.ComboBox();
            this.PublishYearLB = new System.Windows.Forms.Label();
            this.AuthorLB = new System.Windows.Forms.Label();
            this.ISBNLB = new System.Windows.Forms.Label();
            this.TitleLB = new System.Windows.Forms.Label();
            this.LanguageLB = new System.Windows.Forms.Label();
            RequestTimeExtention = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RequestTimeExtention
            // 
            RequestTimeExtention.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RequestTimeExtention.Location = new System.Drawing.Point(115, 403);
            RequestTimeExtention.Margin = new System.Windows.Forms.Padding(4);
            RequestTimeExtention.Name = "RequestTimeExtention";
            RequestTimeExtention.Size = new System.Drawing.Size(167, 70);
            RequestTimeExtention.TabIndex = 39;
            RequestTimeExtention.Text = "Request Time Extention";
            RequestTimeExtention.UseVisualStyleBackColor = true;
            RequestTimeExtention.Click += new System.EventHandler(this.RequestTimeExtention_Click);
            // 
            // BookCrudTitle
            // 
            this.BookCrudTitle.AutoSize = true;
            this.BookCrudTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCrudTitle.Location = new System.Drawing.Point(315, 28);
            this.BookCrudTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookCrudTitle.Name = "BookCrudTitle";
            this.BookCrudTitle.Size = new System.Drawing.Size(88, 42);
            this.BookCrudTitle.TabIndex = 1;
            this.BookCrudTitle.Text = "Title";
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.Location = new System.Drawing.Point(197, 144);
            this.Titlelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(54, 26);
            this.Titlelbl.TabIndex = 38;
            this.Titlelbl.Text = "Title";
            // 
            // lb_ISBN_value
            // 
            this.lb_ISBN_value.AutoSize = true;
            this.lb_ISBN_value.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ISBN_value.ForeColor = System.Drawing.Color.Black;
            this.lb_ISBN_value.Location = new System.Drawing.Point(414, 186);
            this.lb_ISBN_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ISBN_value.Name = "lb_ISBN_value";
            this.lb_ISBN_value.Size = new System.Drawing.Size(0, 26);
            this.lb_ISBN_value.TabIndex = 37;
            // 
            // lb_RatingValue
            // 
            this.lb_RatingValue.AutoSize = true;
            this.lb_RatingValue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RatingValue.ForeColor = System.Drawing.Color.Black;
            this.lb_RatingValue.Location = new System.Drawing.Point(403, 349);
            this.lb_RatingValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_RatingValue.Name = "lb_RatingValue";
            this.lb_RatingValue.Size = new System.Drawing.Size(25, 26);
            this.lb_RatingValue.TabIndex = 36;
            this.lb_RatingValue.Text = "H";
            // 
            // lb_LangueageValue
            // 
            this.lb_LangueageValue.AutoSize = true;
            this.lb_LangueageValue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LangueageValue.ForeColor = System.Drawing.Color.Black;
            this.lb_LangueageValue.Location = new System.Drawing.Point(417, 304);
            this.lb_LangueageValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_LangueageValue.Name = "lb_LangueageValue";
            this.lb_LangueageValue.Size = new System.Drawing.Size(0, 26);
            this.lb_LangueageValue.TabIndex = 35;
            // 
            // lb_PublishYearValue
            // 
            this.lb_PublishYearValue.AutoSize = true;
            this.lb_PublishYearValue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PublishYearValue.ForeColor = System.Drawing.Color.Black;
            this.lb_PublishYearValue.Location = new System.Drawing.Point(414, 265);
            this.lb_PublishYearValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_PublishYearValue.Name = "lb_PublishYearValue";
            this.lb_PublishYearValue.Size = new System.Drawing.Size(0, 26);
            this.lb_PublishYearValue.TabIndex = 34;
            // 
            // lb_AuthorValue
            // 
            this.lb_AuthorValue.AutoSize = true;
            this.lb_AuthorValue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AuthorValue.ForeColor = System.Drawing.Color.Black;
            this.lb_AuthorValue.Location = new System.Drawing.Point(414, 223);
            this.lb_AuthorValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_AuthorValue.Name = "lb_AuthorValue";
            this.lb_AuthorValue.Size = new System.Drawing.Size(0, 26);
            this.lb_AuthorValue.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(197, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 26);
            this.label7.TabIndex = 32;
            this.label7.Text = "ISBN";
            // 
            // Ratinglbl
            // 
            this.Ratinglbl.AutoSize = true;
            this.Ratinglbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ratinglbl.Location = new System.Drawing.Point(197, 345);
            this.Ratinglbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ratinglbl.Name = "Ratinglbl";
            this.Ratinglbl.Size = new System.Drawing.Size(70, 26);
            this.Ratinglbl.TabIndex = 31;
            this.Ratinglbl.Text = "Rating";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 26);
            this.label5.TabIndex = 30;
            this.label5.Text = "Language";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 26);
            this.label4.TabIndex = 29;
            this.label4.Text = "Publish Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Author";
            // 
            // SuggestAlternativeBook
            // 
            this.SuggestAlternativeBook.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuggestAlternativeBook.Location = new System.Drawing.Point(439, 403);
            this.SuggestAlternativeBook.Name = "SuggestAlternativeBook";
            this.SuggestAlternativeBook.Size = new System.Drawing.Size(209, 70);
            this.SuggestAlternativeBook.TabIndex = 41;
            this.SuggestAlternativeBook.Text = "Suggest Alternative Book";
            this.SuggestAlternativeBook.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.bookHistoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 31);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.homeToolStripMenuItem.Text = "Home Page";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // bookHistoryToolStripMenuItem
            // 
            this.bookHistoryToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookHistoryToolStripMenuItem.Name = "bookHistoryToolStripMenuItem";
            this.bookHistoryToolStripMenuItem.Size = new System.Drawing.Size(121, 27);
            this.bookHistoryToolStripMenuItem.Text = "Book History";
            this.bookHistoryToolStripMenuItem.Click += new System.EventHandler(this.bookHistoryToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 508);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(548, 26);
            this.label2.TabIndex = 44;
            this.label2.Text = "The library is a brand, when you\'ve got a card in your hand";
            // 
            // RatingCB
            // 
            this.RatingCB.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingCB.FormattingEnabled = true;
            this.RatingCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.RatingCB.Location = new System.Drawing.Point(322, 349);
            this.RatingCB.Name = "RatingCB";
            this.RatingCB.Size = new System.Drawing.Size(128, 34);
            this.RatingCB.TabIndex = 50;
            this.RatingCB.SelectedIndexChanged += new System.EventHandler(this.RatingCB_SelectedIndexChanged);
            // 
            // PublishYearLB
            // 
            this.PublishYearLB.AutoSize = true;
            this.PublishYearLB.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishYearLB.ForeColor = System.Drawing.Color.Black;
            this.PublishYearLB.Location = new System.Drawing.Point(329, 265);
            this.PublishYearLB.Name = "PublishYearLB";
            this.PublishYearLB.Size = new System.Drawing.Size(0, 26);
            this.PublishYearLB.TabIndex = 51;
            // 
            // AuthorLB
            // 
            this.AuthorLB.AutoSize = true;
            this.AuthorLB.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLB.ForeColor = System.Drawing.Color.Black;
            this.AuthorLB.Location = new System.Drawing.Point(329, 223);
            this.AuthorLB.Name = "AuthorLB";
            this.AuthorLB.Size = new System.Drawing.Size(0, 26);
            this.AuthorLB.TabIndex = 52;
            // 
            // ISBNLB
            // 
            this.ISBNLB.AutoSize = true;
            this.ISBNLB.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNLB.ForeColor = System.Drawing.Color.Black;
            this.ISBNLB.Location = new System.Drawing.Point(329, 186);
            this.ISBNLB.Name = "ISBNLB";
            this.ISBNLB.Size = new System.Drawing.Size(0, 26);
            this.ISBNLB.TabIndex = 53;
            // 
            // TitleLB
            // 
            this.TitleLB.AutoSize = true;
            this.TitleLB.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLB.ForeColor = System.Drawing.Color.Black;
            this.TitleLB.Location = new System.Drawing.Point(329, 144);
            this.TitleLB.Name = "TitleLB";
            this.TitleLB.Size = new System.Drawing.Size(0, 26);
            this.TitleLB.TabIndex = 54;
            // 
            // LanguageLB
            // 
            this.LanguageLB.AutoSize = true;
            this.LanguageLB.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageLB.ForeColor = System.Drawing.Color.Black;
            this.LanguageLB.Location = new System.Drawing.Point(329, 304);
            this.LanguageLB.Name = "LanguageLB";
            this.LanguageLB.Size = new System.Drawing.Size(0, 26);
            this.LanguageLB.TabIndex = 55;
            // 
            // StudentBorrowActinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(798, 542);
            this.Controls.Add(this.LanguageLB);
            this.Controls.Add(this.TitleLB);
            this.Controls.Add(this.ISBNLB);
            this.Controls.Add(this.AuthorLB);
            this.Controls.Add(this.PublishYearLB);
            this.Controls.Add(this.RatingCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SuggestAlternativeBook);
            this.Controls.Add(RequestTimeExtention);
            this.Controls.Add(this.Titlelbl);
            this.Controls.Add(this.lb_ISBN_value);
            this.Controls.Add(this.lb_RatingValue);
            this.Controls.Add(this.lb_LangueageValue);
            this.Controls.Add(this.lb_PublishYearValue);
            this.Controls.Add(this.lb_AuthorValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Ratinglbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BookCrudTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentBorrowActinos";
            this.Text = "My Book Borrow";
            this.Load += new System.EventHandler(this.StudentBorrow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookCrudTitle;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Label lb_ISBN_value;
        private System.Windows.Forms.Label lb_RatingValue;
        private System.Windows.Forms.Label lb_LangueageValue;
        private System.Windows.Forms.Label lb_PublishYearValue;
        private System.Windows.Forms.Label lb_AuthorValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Ratinglbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SuggestAlternativeBook;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookHistoryToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RatingCB;
        private System.Windows.Forms.Label PublishYearLB;
        private System.Windows.Forms.Label AuthorLB;
        private System.Windows.Forms.Label ISBNLB;
        private System.Windows.Forms.Label TitleLB;
        private System.Windows.Forms.Label LanguageLB;
    }
}