
namespace Group4
{
    partial class AdminActions
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
            this.AdminPagetxt = new System.Windows.Forms.Label();
            this.Actiontxt = new System.Windows.Forms.Label();
            this.Studentsbtn = new System.Windows.Forms.Button();
            this.Teachersbtn = new System.Windows.Forms.Button();
            this.Librariansbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminPagetxt
            // 
            this.AdminPagetxt.AutoSize = true;
            this.AdminPagetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPagetxt.Location = new System.Drawing.Point(249, 34);
            this.AdminPagetxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminPagetxt.Name = "AdminPagetxt";
            this.AdminPagetxt.Size = new System.Drawing.Size(355, 69);
            this.AdminPagetxt.TabIndex = 1;
            this.AdminPagetxt.Text = "Admin Page";
            // 
            // Actiontxt
            // 
            this.Actiontxt.AutoSize = true;
            this.Actiontxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actiontxt.Location = new System.Drawing.Point(292, 154);
            this.Actiontxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Actiontxt.Name = "Actiontxt";
            this.Actiontxt.Size = new System.Drawing.Size(281, 29);
            this.Actiontxt.TabIndex = 2;
            this.Actiontxt.Text = "Please choose an action:";
            // 
            // Studentsbtn
            // 
            this.Studentsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studentsbtn.Location = new System.Drawing.Point(105, 232);
            this.Studentsbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Studentsbtn.Name = "Studentsbtn";
            this.Studentsbtn.Size = new System.Drawing.Size(156, 57);
            this.Studentsbtn.TabIndex = 3;
            this.Studentsbtn.Text = "Students";
            this.Studentsbtn.UseVisualStyleBackColor = true;
            this.Studentsbtn.Click += new System.EventHandler(this.Studentsbtn_Click);
            // 
            // Teachersbtn
            // 
            this.Teachersbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teachersbtn.Location = new System.Drawing.Point(370, 232);
            this.Teachersbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Teachersbtn.Name = "Teachersbtn";
            this.Teachersbtn.Size = new System.Drawing.Size(156, 57);
            this.Teachersbtn.TabIndex = 4;
            this.Teachersbtn.Text = "Teachers";
            this.Teachersbtn.UseVisualStyleBackColor = true;
            this.Teachersbtn.Click += new System.EventHandler(this.Teachersbtn_Click);
            // 
            // Librariansbtn
            // 
            this.Librariansbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Librariansbtn.Location = new System.Drawing.Point(594, 232);
            this.Librariansbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Librariansbtn.Name = "Librariansbtn";
            this.Librariansbtn.Size = new System.Drawing.Size(156, 57);
            this.Librariansbtn.TabIndex = 5;
            this.Librariansbtn.Text = "Librarians";
            this.Librariansbtn.UseVisualStyleBackColor = true;
            this.Librariansbtn.Click += new System.EventHandler(this.Librariansbtn_Click);
            // 
            // AdminActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 460);
            this.Controls.Add(this.Librariansbtn);
            this.Controls.Add(this.Teachersbtn);
            this.Controls.Add(this.Studentsbtn);
            this.Controls.Add(this.Actiontxt);
            this.Controls.Add(this.AdminPagetxt);
            this.Name = "AdminActions";
            this.Text = "AdminActions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminPagetxt;
        private System.Windows.Forms.Label Actiontxt;
        private System.Windows.Forms.Button Studentsbtn;
        private System.Windows.Forms.Button Teachersbtn;
        private System.Windows.Forms.Button Librariansbtn;
    }
}