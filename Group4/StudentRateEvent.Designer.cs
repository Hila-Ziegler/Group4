
namespace Group4
{
    partial class StudentRateEvent
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
            this.AddAReviewbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ReviewTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddAReviewbtn
            // 
            this.AddAReviewbtn.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAReviewbtn.Location = new System.Drawing.Point(274, 353);
            this.AddAReviewbtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddAReviewbtn.Name = "AddAReviewbtn";
            this.AddAReviewbtn.Size = new System.Drawing.Size(170, 60);
            this.AddAReviewbtn.TabIndex = 5;
            this.AddAReviewbtn.Text = "Add a review";
            this.AddAReviewbtn.UseVisualStyleBackColor = true;
            this.AddAReviewbtn.Click += new System.EventHandler(this.AddAReviewbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "An event you took a part in..";
            // 
            // ReviewTextBox
            // 
            this.ReviewTextBox.Location = new System.Drawing.Point(187, 182);
            this.ReviewTextBox.Name = "ReviewTextBox";
            this.ReviewTextBox.Size = new System.Drawing.Size(329, 116);
            this.ReviewTextBox.TabIndex = 6;
            this.ReviewTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Review:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rating:";
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ratingComboBox.Location = new System.Drawing.Point(187, 136);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(121, 24);
            this.ratingComboBox.TabIndex = 9;
            // 
            // StudentRateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ratingComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReviewTextBox);
            this.Controls.Add(this.AddAReviewbtn);
            this.Controls.Add(this.label1);
            this.Name = "StudentRateEvent";
            this.Text = "StudentRateEvent";
            this.Load += new System.EventHandler(this.StudentRateEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddAReviewbtn;
        private System.Windows.Forms.RichTextBox ReviewTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ratingComboBox;
        private System.Windows.Forms.Label label1;
    }
}