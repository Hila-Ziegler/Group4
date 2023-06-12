
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
            this.CopyNum = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Borrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.CreateNewBook = new System.Windows.Forms.Button();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.updateScreenratinglbl = new System.Windows.Forms.Label();
            this.ISBNUpdateScreen = new System.Windows.Forms.Label();
            this.BringBackFromArchieve = new System.Windows.Forms.Button();
            this.LngCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookCrudTitle
            // 
            this.BookCrudTitle.AutoSize = true;
            this.BookCrudTitle.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCrudTitle.Location = new System.Drawing.Point(268, 28);
            this.BookCrudTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookCrudTitle.Name = "BookCrudTitle";
            this.BookCrudTitle.Size = new System.Drawing.Size(96, 46);
            this.BookCrudTitle.TabIndex = 0;
            this.BookCrudTitle.Text = "Title";
            this.BookCrudTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 601);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(548, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "The library is a brand, when you\'ve got a card in your hand";
            // 
            // BookCrudUpdateBTN
            // 
            this.BookCrudUpdateBTN.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCrudUpdateBTN.Location = new System.Drawing.Point(147, 349);
            this.BookCrudUpdateBTN.Margin = new System.Windows.Forms.Padding(4);
            this.BookCrudUpdateBTN.Name = "BookCrudUpdateBTN";
            this.BookCrudUpdateBTN.Size = new System.Drawing.Size(97, 46);
            this.BookCrudUpdateBTN.TabIndex = 6;
            this.BookCrudUpdateBTN.Text = "Update";
            this.BookCrudUpdateBTN.UseVisualStyleBackColor = true;
            this.BookCrudUpdateBTN.Click += new System.EventHandler(this.BookCrudUpdateBTN_Click);
            // 
            // BookCrudDeleteBTN
            // 
            this.BookCrudDeleteBTN.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCrudDeleteBTN.Location = new System.Drawing.Point(403, 349);
            this.BookCrudDeleteBTN.Margin = new System.Windows.Forms.Padding(4);
            this.BookCrudDeleteBTN.Name = "BookCrudDeleteBTN";
            this.BookCrudDeleteBTN.Size = new System.Drawing.Size(100, 46);
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
            this.dataGridView1.Location = new System.Drawing.Point(183, 424);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(306, 158);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Author";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Publish Year";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(113, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Language";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Ratinglbl
            // 
            this.Ratinglbl.AutoSize = true;
            this.Ratinglbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ratinglbl.Location = new System.Drawing.Point(113, 263);
            this.Ratinglbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ratinglbl.Name = "Ratinglbl";
            this.Ratinglbl.Size = new System.Drawing.Size(70, 26);
            this.Ratinglbl.TabIndex = 12;
            this.Ratinglbl.Text = "Rating";
            this.Ratinglbl.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "ISBN";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BookCrudHomePage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(839, 31);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BookCrudHomePage
            // 
            this.BookCrudHomePage.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCrudHomePage.Name = "BookCrudHomePage";
            this.BookCrudHomePage.Size = new System.Drawing.Size(107, 27);
            this.BookCrudHomePage.Text = "Home Page";
            this.BookCrudHomePage.Click += new System.EventHandler(this.BookCrudHomePage_Click);
            // 
            // lb_ISBN_value
            // 
            this.lb_ISBN_value.AutoSize = true;
            this.lb_ISBN_value.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ISBN_value.Location = new System.Drawing.Point(276, 127);
            this.lb_ISBN_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ISBN_value.Name = "lb_ISBN_value";
            this.lb_ISBN_value.Size = new System.Drawing.Size(0, 26);
            this.lb_ISBN_value.TabIndex = 19;
            this.lb_ISBN_value.Click += new System.EventHandler(this.label8_Click);
            // 
            // lb_RatingValue
            // 
            this.lb_RatingValue.AutoSize = true;
            this.lb_RatingValue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RatingValue.Location = new System.Drawing.Point(276, 263);
            this.lb_RatingValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_RatingValue.Name = "lb_RatingValue";
            this.lb_RatingValue.Size = new System.Drawing.Size(0, 26);
            this.lb_RatingValue.TabIndex = 18;
            this.lb_RatingValue.Click += new System.EventHandler(this.label9_Click);
            // 
            // lb_LangueageValue
            // 
            this.lb_LangueageValue.AutoSize = true;
            this.lb_LangueageValue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LangueageValue.Location = new System.Drawing.Point(276, 228);
            this.lb_LangueageValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_LangueageValue.Name = "lb_LangueageValue";
            this.lb_LangueageValue.Size = new System.Drawing.Size(0, 26);
            this.lb_LangueageValue.TabIndex = 17;
            this.lb_LangueageValue.Click += new System.EventHandler(this.label10_Click);
            // 
            // lb_PublishYearValue
            // 
            this.lb_PublishYearValue.AutoSize = true;
            this.lb_PublishYearValue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PublishYearValue.Location = new System.Drawing.Point(276, 191);
            this.lb_PublishYearValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_PublishYearValue.Name = "lb_PublishYearValue";
            this.lb_PublishYearValue.Size = new System.Drawing.Size(0, 26);
            this.lb_PublishYearValue.TabIndex = 16;
            this.lb_PublishYearValue.Click += new System.EventHandler(this.label11_Click);
            // 
            // lb_AuthorValue
            // 
            this.lb_AuthorValue.AutoSize = true;
            this.lb_AuthorValue.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AuthorValue.Location = new System.Drawing.Point(276, 161);
            this.lb_AuthorValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_AuthorValue.Name = "lb_AuthorValue";
            this.lb_AuthorValue.Size = new System.Drawing.Size(0, 26);
            this.lb_AuthorValue.TabIndex = 15;
            this.lb_AuthorValue.Click += new System.EventHandler(this.label12_Click);
            // 
            // bookCrudAddNewCopy
            // 
            this.bookCrudAddNewCopy.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookCrudAddNewCopy.Location = new System.Drawing.Point(519, 424);
            this.bookCrudAddNewCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookCrudAddNewCopy.Name = "bookCrudAddNewCopy";
            this.bookCrudAddNewCopy.Size = new System.Drawing.Size(103, 66);
            this.bookCrudAddNewCopy.TabIndex = 20;
            this.bookCrudAddNewCopy.Text = "Add a new copy";
            this.bookCrudAddNewCopy.UseVisualStyleBackColor = true;
            this.bookCrudAddNewCopy.Click += new System.EventHandler(this.bookCrudAddNewCopy_Click);
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNTextBox.Location = new System.Drawing.Point(283, 130);
            this.ISBNTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(128, 27);
            this.ISBNTextBox.TabIndex = 21;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorTextBox.Location = new System.Drawing.Point(283, 161);
            this.AuthorTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(128, 27);
            this.AuthorTextBox.TabIndex = 22;
            // 
            // PublishYearTextBox
            // 
            this.PublishYearTextBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishYearTextBox.Location = new System.Drawing.Point(283, 194);
            this.PublishYearTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PublishYearTextBox.Name = "PublishYearTextBox";
            this.PublishYearTextBox.Size = new System.Drawing.Size(128, 27);
            this.PublishYearTextBox.TabIndex = 23;
            // 
            // CreateNewBook
            // 
            this.CreateNewBook.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewBook.Location = new System.Drawing.Point(251, 328);
            this.CreateNewBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateNewBook.Name = "CreateNewBook";
            this.CreateNewBook.Size = new System.Drawing.Size(145, 67);
            this.CreateNewBook.TabIndex = 26;
            this.CreateNewBook.Text = "Create New Book";
            this.CreateNewBook.UseVisualStyleBackColor = true;
            this.CreateNewBook.Click += new System.EventHandler(this.button3_Click);
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.Location = new System.Drawing.Point(113, 97);
            this.Titlelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(54, 26);
            this.Titlelbl.TabIndex = 27;
            this.Titlelbl.Text = "Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextBox.Location = new System.Drawing.Point(283, 97);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(128, 27);
            this.TitleTextBox.TabIndex = 28;
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBook.Location = new System.Drawing.Point(275, 291);
            this.btnUpdateBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(90, 61);
            this.btnUpdateBook.TabIndex = 29;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // updateScreenratinglbl
            // 
            this.updateScreenratinglbl.AutoSize = true;
            this.updateScreenratinglbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateScreenratinglbl.Location = new System.Drawing.Point(371, 262);
            this.updateScreenratinglbl.Name = "updateScreenratinglbl";
            this.updateScreenratinglbl.Size = new System.Drawing.Size(0, 26);
            this.updateScreenratinglbl.TabIndex = 30;
            this.updateScreenratinglbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ISBNUpdateScreen
            // 
            this.ISBNUpdateScreen.AutoSize = true;
            this.ISBNUpdateScreen.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNUpdateScreen.Location = new System.Drawing.Point(371, 126);
            this.ISBNUpdateScreen.Name = "ISBNUpdateScreen";
            this.ISBNUpdateScreen.Size = new System.Drawing.Size(0, 26);
            this.ISBNUpdateScreen.TabIndex = 31;
            // 
            // BringBackFromArchieve
            // 
            this.BringBackFromArchieve.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BringBackFromArchieve.Location = new System.Drawing.Point(465, 100);
            this.BringBackFromArchieve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BringBackFromArchieve.Name = "BringBackFromArchieve";
            this.BringBackFromArchieve.Size = new System.Drawing.Size(128, 69);
            this.BringBackFromArchieve.TabIndex = 32;
            this.BringBackFromArchieve.Text = "Return From Archieve";
            this.BringBackFromArchieve.UseVisualStyleBackColor = true;
            this.BringBackFromArchieve.Click += new System.EventHandler(this.BringBackFromArchieve_Click);
            // 
            // LngCombo
            // 
            this.LngCombo.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LngCombo.FormattingEnabled = true;
            this.LngCombo.Location = new System.Drawing.Point(283, 231);
            this.LngCombo.Margin = new System.Windows.Forms.Padding(4);
            this.LngCombo.Name = "LngCombo";
            this.LngCombo.Size = new System.Drawing.Size(128, 31);
            this.LngCombo.TabIndex = 33;
            this.LngCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BookCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(839, 659);
            this.Controls.Add(this.LngCombo);
            this.Controls.Add(this.BringBackFromArchieve);
            this.Controls.Add(this.ISBNUpdateScreen);
            this.Controls.Add(this.updateScreenratinglbl);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.Titlelbl);
            this.Controls.Add(this.CreateNewBook);
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
        private System.Windows.Forms.Button CreateNewBook;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Label updateScreenratinglbl;
        private System.Windows.Forms.Label ISBNUpdateScreen;
        private System.Windows.Forms.DataGridViewButtonColumn CopyNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrowed;
        private System.Windows.Forms.Button BringBackFromArchieve;
        private System.Windows.Forms.ComboBox LngCombo;
    }
}