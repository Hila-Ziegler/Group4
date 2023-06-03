
namespace Group4
{
    partial class BookCrudErrorWindow
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
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessage.Location = new System.Drawing.Point(226, 71);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(176, 44);
            this.ErrorMessage.TabIndex = 0;
            this.ErrorMessage.Text = "Example";
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(287, 256);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(76, 36);
            this.GoBackButton.TabIndex = 1;
            this.GoBackButton.Text = "OK";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // BookCrudErrorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 318);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.ErrorMessage);
            this.Name = "BookCrudErrorWindow";
            this.Text = "Error";
            this.Load += new System.EventHandler(this.BookCrudErrorWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.Button GoBackButton;
    }
}