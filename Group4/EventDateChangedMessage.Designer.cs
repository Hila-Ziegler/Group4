
namespace Group4
{
    partial class EventDateChangedMessage
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
            this.Confirmbtn = new System.Windows.Forms.Button();
            this.DateChangedMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Confirmbtn
            // 
            this.Confirmbtn.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmbtn.Location = new System.Drawing.Point(302, 173);
            this.Confirmbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Confirmbtn.Name = "Confirmbtn";
            this.Confirmbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Confirmbtn.Size = new System.Drawing.Size(100, 28);
            this.Confirmbtn.TabIndex = 4;
            this.Confirmbtn.Text = "OK";
            this.Confirmbtn.UseVisualStyleBackColor = true;
            this.Confirmbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // DateChangedMessage
            // 
            this.DateChangedMessage.AutoSize = true;
            this.DateChangedMessage.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateChangedMessage.Location = new System.Drawing.Point(138, 27);
            this.DateChangedMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateChangedMessage.Name = "DateChangedMessage";
            this.DateChangedMessage.Size = new System.Drawing.Size(417, 23);
            this.DateChangedMessage.TabIndex = 3;
            this.DateChangedMessage.Text = "The date of the event you Registered to has changed.";
            // 
            // EventDateChangedMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(700, 231);
            this.Controls.Add(this.Confirmbtn);
            this.Controls.Add(this.DateChangedMessage);
            this.Name = "EventDateChangedMessage";
            this.Text = "Message";
            this.Load += new System.EventHandler(this.EventDateChangedMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirmbtn;
        private System.Windows.Forms.Label DateChangedMessage;
    }
}