
namespace Group4
{
    partial class ReadBook
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleInput = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.TitleText = new System.Windows.Forms.Label();
            this.TitleSearch = new System.Windows.Forms.Label();
            this.AuthorSearch = new System.Windows.Forms.Label();
            this.AuthorInput = new System.Windows.Forms.TextBox();
            this.PublishSearch = new System.Windows.Forms.Label();
            this.PublishInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(310, 345);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(171, 27);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Author,
            this.PublishYear,
            this.Language,
            this.Rating,
            this.SerialNum});
            this.dataGridView1.Location = new System.Drawing.Point(310, 443);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 196);
            this.dataGridView1.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            // 
            // PublishYear
            // 
            this.PublishYear.HeaderText = "Publish Year";
            this.PublishYear.Name = "PublishYear";
            // 
            // Language
            // 
            this.Language.HeaderText = "Language";
            this.Language.Name = "Language";
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            // 
            // SerialNum
            // 
            this.SerialNum.HeaderText = "Serial Number";
            this.SerialNum.Name = "SerialNum";
            // 
            // TitleInput
            // 
            this.TitleInput.Location = new System.Drawing.Point(510, 152);
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(295, 20);
            this.TitleInput.TabIndex = 2;
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(821, 348);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(132, 24);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // TitleText
            // 
            this.TitleText.AutoSize = true;
            this.TitleText.Font = new System.Drawing.Font("ROG Fonts", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleText.Location = new System.Drawing.Point(477, 41);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(291, 32);
            this.TitleText.TabIndex = 4;
            this.TitleText.Text = "Search a book";
            this.TitleText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TitleText.Click += new System.EventHandler(this.TitleText_Click);
            // 
            // TitleSearch
            // 
            this.TitleSearch.AutoSize = true;
            this.TitleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleSearch.Location = new System.Drawing.Point(307, 152);
            this.TitleSearch.Name = "TitleSearch";
            this.TitleSearch.Size = new System.Drawing.Size(81, 20);
            this.TitleSearch.TabIndex = 5;
            this.TitleSearch.Text = "Enter title:";
            // 
            // AuthorSearch
            // 
            this.AuthorSearch.AutoSize = true;
            this.AuthorSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorSearch.Location = new System.Drawing.Point(307, 218);
            this.AuthorSearch.Name = "AuthorSearch";
            this.AuthorSearch.Size = new System.Drawing.Size(102, 20);
            this.AuthorSearch.TabIndex = 6;
            this.AuthorSearch.Text = "Enter author:";
            // 
            // AuthorInput
            // 
            this.AuthorInput.Location = new System.Drawing.Point(510, 211);
            this.AuthorInput.Name = "AuthorInput";
            this.AuthorInput.Size = new System.Drawing.Size(295, 20);
            this.AuthorInput.TabIndex = 7;
            // 
            // PublishSearch
            // 
            this.PublishSearch.AutoSize = true;
            this.PublishSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishSearch.Location = new System.Drawing.Point(307, 277);
            this.PublishSearch.Name = "PublishSearch";
            this.PublishSearch.Size = new System.Drawing.Size(140, 20);
            this.PublishSearch.TabIndex = 8;
            this.PublishSearch.Text = "Enter publish year:";
            // 
            // PublishInput
            // 
            this.PublishInput.Location = new System.Drawing.Point(510, 270);
            this.PublishInput.Name = "PublishInput";
            this.PublishInput.Size = new System.Drawing.Size(295, 20);
            this.PublishInput.TabIndex = 9;
            // 
            // ReadBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 703);
            this.Controls.Add(this.PublishInput);
            this.Controls.Add(this.PublishSearch);
            this.Controls.Add(this.AuthorInput);
            this.Controls.Add(this.AuthorSearch);
            this.Controls.Add(this.TitleSearch);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.TitleInput);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchButton);
            this.Name = "ReadBook";
            this.Text = "ReadBook";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNum;
        private System.Windows.Forms.TextBox TitleInput;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.Label TitleSearch;
        private System.Windows.Forms.Label AuthorSearch;
        private System.Windows.Forms.TextBox AuthorInput;
        private System.Windows.Forms.Label PublishSearch;
        private System.Windows.Forms.TextBox PublishInput;
    }
}