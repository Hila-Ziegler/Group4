
namespace Group4
{
    partial class BookCrud
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
            this.BookCrudTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BookCrudUpdateBTN = new System.Windows.Forms.Button();
            this.BookCrudDeleteBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Ratinglbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BookCrudHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_ISBN_value = new System.Windows.Forms.Label();
            this.lb_RatingValue = new System.Windows.Forms.Label();
            this.lb_LangueageValue = new System.Windows.Forms.Label();
            this.lb_PublishYearValue = new System.Windows.Forms.Label();
            this.lb_AuthorValue = new System.Windows.Forms.Label();
            this.bookCrudAddNewCopy = new System.Windows.Forms.Button();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.PublishYearTextBox = new System.Windows.Forms.TextBox();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.CreateNewBook = new System.Windows.Forms.Button();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.updateScreenratinglbl = new System.Windows.Forms.Label();
            this.ISBNUpdateScreen = new System.Windows.Forms.Label();
            this.CopyNum = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Borrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BringBackFromArchieve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookCrudTitle
            // 
            this.BookCrudTitle.AutoSize = true;
            this.BookCrudTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCrudTitle.Location = new System.Drawing.Point(633, 30);
            this.BookCrudTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookCrudTitle.Name = "BookCrudTitle";
            this.BookCrudTitle.Size = new System.Drawing.Size(88, 42);
            this.BookCrudTitle.TabIndex = 0;
            this.BookCrudTitle.Text = "Title";
            this.BookCrudTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 644);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "The library is a brand, when you\'ve got a card in your hand";
            // 
            // BookCrudUpdateBTN
            // 
            this.BookCrudUpdateBTN.Location = new System.Drawing.Point(476, 341);
            this.BookCrudUpdateBTN.Margin = new System.Windows.Forms.Padding(4);
            this.BookCrudUpdateBTN.Name = "BookCrudUpdateBTN";
            this.BookCrudUpdateBTN.Size = new System.Drawing.Size(100, 28);
            this.BookCrudUpdateBTN.TabIndex = 6;
            this.BookCrudUpdateBTN.Text = "Update";
            this.BookCrudUpdateBTN.UseVisualStyleBackColor = true;
            this.BookCrudUpdateBTN.Click += new System.EventHandler(this.BookCrudUpdateBTN_Click);
            // 
            // BookCrudDeleteBTN
            // 
            this.BookCrudDeleteBTN.Location = new System.Drawing.Point(732, 341);
            this.BookCrudDeleteBTN.Margin = new System.Windows.Forms.Padding(4);
            this.BookCrudDeleteBTN.Name = "BookCrudDeleteBTN";
            this.BookCrudDeleteBTN.Size = new System.Drawing.Size(100, 28);
            this.BookCrudDeleteBTN.TabIndex = 7;
            this.BookCrudDeleteBTN.Text = "Delete";
            this.BookCrudDeleteBTN.UseVisualStyleBackColor = true;
            this.BookCrudDeleteBTN.Click += new System.EventHandler(this.BookCrudDeleteBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CopyNum,
            this.Borrowed});
            this.dataGridView1.Location = new System.Drawing.Point(512, 415);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(320, 185);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Author";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Publish Year";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Language";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Ratinglbl
            // 
            this.Ratinglbl.AutoSize = true;
            this.Ratinglbl.Location = new System.Drawing.Point(409, 247);
            this.Ratinglbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ratinglbl.Name = "Ratinglbl";
            this.Ratinglbl.Size = new System.Drawing.Size(49, 17);
            this.Ratinglbl.TabIndex = 12;
            this.Ratinglbl.Text = "Rating";
            this.Ratinglbl.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "ISBN";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BookCrudHomePage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1475, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BookCrudHomePage
            // 
            this.BookCrudHomePage.Name = "BookCrudHomePage";
            this.BookCrudHomePage.Size = new System.Drawing.Size(100, 24);
            this.BookCrudHomePage.Text = "Home Page";
            this.BookCrudHomePage.Click += new System.EventHandler(this.BookCrudHomePage_Click);
            // 
            // lb_ISBN_value
            // 
            this.lb_ISBN_value.AutoSize = true;
            this.lb_ISBN_value.Location = new System.Drawing.Point(572, 111);
            this.lb_ISBN_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ISBN_value.Name = "lb_ISBN_value";
            this.lb_ISBN_value.Size = new System.Drawing.Size(0, 17);
            this.lb_ISBN_value.TabIndex = 19;
            this.lb_ISBN_value.Click += new System.EventHandler(this.label8_Click);
            // 
            // lb_RatingValue
            // 
            this.lb_RatingValue.AutoSize = true;
            this.lb_RatingValue.Location = new System.Drawing.Point(572, 247);
            this.lb_RatingValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_RatingValue.Name = "lb_RatingValue";
            this.lb_RatingValue.Size = new System.Drawing.Size(0, 17);
            this.lb_RatingValue.TabIndex = 18;
            this.lb_RatingValue.Click += new System.EventHandler(this.label9_Click);
            // 
            // lb_LangueageValue
            // 
            this.lb_LangueageValue.AutoSize = true;
            this.lb_LangueageValue.Location = new System.Drawing.Point(572, 212);
            this.lb_LangueageValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_LangueageValue.Name = "lb_LangueageValue";
            this.lb_LangueageValue.Size = new System.Drawing.Size(0, 17);
            this.lb_LangueageValue.TabIndex = 17;
            this.lb_LangueageValue.Click += new System.EventHandler(this.label10_Click);
            // 
            // lb_PublishYearValue
            // 
            this.lb_PublishYearValue.AutoSize = true;
            this.lb_PublishYearValue.Location = new System.Drawing.Point(572, 175);
            this.lb_PublishYearValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_PublishYearValue.Name = "lb_PublishYearValue";
            this.lb_PublishYearValue.Size = new System.Drawing.Size(0, 17);
            this.lb_PublishYearValue.TabIndex = 16;
            this.lb_PublishYearValue.Click += new System.EventHandler(this.label11_Click);
            // 
            // lb_AuthorValue
            // 
            this.lb_AuthorValue.AutoSize = true;
            this.lb_AuthorValue.Location = new System.Drawing.Point(572, 145);
            this.lb_AuthorValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_AuthorValue.Name = "lb_AuthorValue";
            this.lb_AuthorValue.Size = new System.Drawing.Size(0, 17);
            this.lb_AuthorValue.TabIndex = 15;
            this.lb_AuthorValue.Click += new System.EventHandler(this.label12_Click);
            // 
            // bookCrudAddNewCopy
            // 
            this.bookCrudAddNewCopy.Location = new System.Drawing.Point(848, 479);
            this.bookCrudAddNewCopy.Name = "bookCrudAddNewCopy";
            this.bookCrudAddNewCopy.Size = new System.Drawing.Size(103, 45);
            this.bookCrudAddNewCopy.TabIndex = 20;
            this.bookCrudAddNewCopy.Text = "Add a new copy";
            this.bookCrudAddNewCopy.UseVisualStyleBackColor = true;
            this.bookCrudAddNewCopy.Click += new System.EventHandler(this.bookCrudAddNewCopy_Click);
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(640, 111);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(128, 22);
            this.ISBNTextBox.TabIndex = 21;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(640, 142);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(128, 22);
            this.AuthorTextBox.TabIndex = 22;
            // 
            // PublishYearTextBox
            // 
            this.PublishYearTextBox.Location = new System.Drawing.Point(640, 175);
            this.PublishYearTextBox.Name = "PublishYearTextBox";
            this.PublishYearTextBox.Size = new System.Drawing.Size(128, 22);
            this.PublishYearTextBox.TabIndex = 23;
            // 
            // languageTextBox
            // 
            this.languageTextBox.Location = new System.Drawing.Point(640, 209);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.Size = new System.Drawing.Size(128, 22);
            this.languageTextBox.TabIndex = 24;
            // 
            // CreateNewBook
            // 
            this.CreateNewBook.Location = new System.Drawing.Point(580, 344);
            this.CreateNewBook.Name = "CreateNewBook";
            this.CreateNewBook.Size = new System.Drawing.Size(145, 49);
            this.CreateNewBook.TabIndex = 26;
            this.CreateNewBook.Text = "Create New Book";
            this.CreateNewBook.UseVisualStyleBackColor = true;
            this.CreateNewBook.Click += new System.EventHandler(this.button3_Click);
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Location = new System.Drawing.Point(409, 81);
            this.Titlelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(35, 17);
            this.Titlelbl.TabIndex = 27;
            this.Titlelbl.Text = "Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(640, 78);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(128, 22);
            this.TitleTextBox.TabIndex = 28;
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(609, 315);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(85, 54);
            this.btnUpdateBook.TabIndex = 29;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // updateScreenratinglbl
            // 
            this.updateScreenratinglbl.AutoSize = true;
            this.updateScreenratinglbl.Location = new System.Drawing.Point(652, 247);
            this.updateScreenratinglbl.Name = "updateScreenratinglbl";
            this.updateScreenratinglbl.Size = new System.Drawing.Size(0, 17);
            this.updateScreenratinglbl.TabIndex = 30;
            this.updateScreenratinglbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ISBNUpdateScreen
            // 
            this.ISBNUpdateScreen.AutoSize = true;
            this.ISBNUpdateScreen.Location = new System.Drawing.Point(652, 111);
            this.ISBNUpdateScreen.Name = "ISBNUpdateScreen";
            this.ISBNUpdateScreen.Size = new System.Drawing.Size(0, 17);
            this.ISBNUpdateScreen.TabIndex = 31;
            // 
            // CopyNum
            // 
            this.CopyNum.HeaderText = "Copy Number";
            this.CopyNum.MinimumWidth = 6;
            this.CopyNum.Name = "CopyNum";
            this.CopyNum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CopyNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CopyNum.Width = 125;
            // 
            // Borrowed
            // 
            this.Borrowed.HeaderText = "Borrowed";
            this.Borrowed.MinimumWidth = 6;
            this.Borrowed.Name = "Borrowed";
            this.Borrowed.Width = 125;
            // 
            // BringBackFromArchieve
            // 
            this.BringBackFromArchieve.Location = new System.Drawing.Point(862, 127);
            this.BringBackFromArchieve.Name = "BringBackFromArchieve";
            this.BringBackFromArchieve.Size = new System.Drawing.Size(128, 52);
            this.BringBackFromArchieve.TabIndex = 32;
            this.BringBackFromArchieve.Text = "Return From Archieve";
            this.BringBackFromArchieve.UseVisualStyleBackColor = true;
            this.BringBackFromArchieve.Click += new System.EventHandler(this.BringBackFromArchieve_Click);
            // 
            // BookCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 743);
            this.Controls.Add(this.BringBackFromArchieve);
            this.Controls.Add(this.ISBNUpdateScreen);
            this.Controls.Add(this.updateScreenratinglbl);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.Titlelbl);
            this.Controls.Add(this.CreateNewBook);
            this.Controls.Add(this.languageTextBox);
            this.Controls.Add(this.PublishYearTextBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.bookCrudAddNewCopy);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BookCrudDeleteBTN);
            this.Controls.Add(this.BookCrudUpdateBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookCrudTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookCrud";
            this.Text = "BookCrud";
            this.Load += new System.EventHandler(this.BookCrud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookCrudTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BookCrudUpdateBTN;
        private System.Windows.Forms.Button BookCrudDeleteBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Ratinglbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BookCrudHomePage;
        private System.Windows.Forms.Label lb_ISBN_value;
        private System.Windows.Forms.Label lb_RatingValue;
        private System.Windows.Forms.Label lb_LangueageValue;
        private System.Windows.Forms.Label lb_PublishYearValue;
        private System.Windows.Forms.Label lb_AuthorValue;
        private System.Windows.Forms.Button bookCrudAddNewCopy;
        private System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox PublishYearTextBox;
        private System.Windows.Forms.TextBox languageTextBox;
        private System.Windows.Forms.Button CreateNewBook;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Label updateScreenratinglbl;
        private System.Windows.Forms.Label ISBNUpdateScreen;
        private System.Windows.Forms.DataGridViewButtonColumn CopyNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrowed;
        private System.Windows.Forms.Button BringBackFromArchieve;
    }
}