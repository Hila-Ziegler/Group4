﻿
namespace Group4
{
    partial class ManageBooks
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Copies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddNewBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ManageBooksHomePagemenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BookManagmentGoToArchieve = new System.Windows.Forms.Button();
            this.btnShowActiveBooks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Books";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Title,
            this.Author,
            this.Language,
            this.Copies,
            this.PublishYear});
            this.dataGridView1.Location = new System.Drawing.Point(75, 236);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(839, 304);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.Width = 125;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Title.Width = 200;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.Width = 125;
            // 
            // Language
            // 
            this.Language.HeaderText = "Language";
            this.Language.MinimumWidth = 6;
            this.Language.Name = "Language";
            this.Language.Width = 125;
            // 
            // Copies
            // 
            this.Copies.HeaderText = "Copies";
            this.Copies.MinimumWidth = 6;
            this.Copies.Name = "Copies";
            this.Copies.Width = 50;
            // 
            // PublishYear
            // 
            this.PublishYear.HeaderText = "Publish Year";
            this.PublishYear.MinimumWidth = 6;
            this.PublishYear.Name = "PublishYear";
            this.PublishYear.Width = 70;
            // 
            // AddNewBook
            // 
            this.AddNewBook.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewBook.Location = new System.Drawing.Point(511, 166);
            this.AddNewBook.Margin = new System.Windows.Forms.Padding(4);
            this.AddNewBook.Name = "AddNewBook";
            this.AddNewBook.Size = new System.Drawing.Size(184, 28);
            this.AddNewBook.TabIndex = 3;
            this.AddNewBook.Text = "Add New Book";
            this.AddNewBook.UseVisualStyleBackColor = true;
            this.AddNewBook.Click += new System.EventHandler(this.AddNewBook_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 570);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(548, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "The library is a brand, when you\'ve got a card in your hand";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageBooksHomePagemenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(992, 31);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ManageBooksHomePagemenu
            // 
            this.ManageBooksHomePagemenu.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageBooksHomePagemenu.Name = "ManageBooksHomePagemenu";
            this.ManageBooksHomePagemenu.Size = new System.Drawing.Size(107, 27);
            this.ManageBooksHomePagemenu.Text = "Home Page";
            this.ManageBooksHomePagemenu.Click += new System.EventHandler(this.ManageBooksHomePagemenu_Click);
            // 
            // BookManagmentGoToArchieve
            // 
            this.BookManagmentGoToArchieve.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookManagmentGoToArchieve.Location = new System.Drawing.Point(730, 166);
            this.BookManagmentGoToArchieve.Name = "BookManagmentGoToArchieve";
            this.BookManagmentGoToArchieve.Size = new System.Drawing.Size(184, 28);
            this.BookManagmentGoToArchieve.TabIndex = 6;
            this.BookManagmentGoToArchieve.Text = "View Archive";
            this.BookManagmentGoToArchieve.UseVisualStyleBackColor = true;
            this.BookManagmentGoToArchieve.Click += new System.EventHandler(this.BookManagmentGoToArchieve_Click);
            // 
            // btnShowActiveBooks
            // 
            this.btnShowActiveBooks.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowActiveBooks.Location = new System.Drawing.Point(730, 166);
            this.btnShowActiveBooks.Name = "btnShowActiveBooks";
            this.btnShowActiveBooks.Size = new System.Drawing.Size(184, 28);
            this.btnShowActiveBooks.TabIndex = 7;
            this.btnShowActiveBooks.Text = "Show active books";
            this.btnShowActiveBooks.UseVisualStyleBackColor = true;
            this.btnShowActiveBooks.Click += new System.EventHandler(this.btnShowActiveBooks_Click);
            // 
            // ManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(992, 613);
            this.Controls.Add(this.btnShowActiveBooks);
            this.Controls.Add(this.BookManagmentGoToArchieve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddNewBook);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageBooks";
            this.Text = "Book Managment";
            this.Load += new System.EventHandler(this.BookCrud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddNewBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ManageBooksHomePagemenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewButtonColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn Copies;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishYear;
        private System.Windows.Forms.Button BookManagmentGoToArchieve;
        private System.Windows.Forms.Button btnShowActiveBooks;
    }
}