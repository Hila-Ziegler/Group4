
namespace Group4
{
    partial class AdminConfirmDelete
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
            this.button2 = new System.Windows.Forms.Button();
            this.ConfirmDeleteBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 114);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConfirmDeleteBTN
            // 
            this.ConfirmDeleteBTN.Location = new System.Drawing.Point(334, 114);
            this.ConfirmDeleteBTN.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmDeleteBTN.Name = "ConfirmDeleteBTN";
            this.ConfirmDeleteBTN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ConfirmDeleteBTN.Size = new System.Drawing.Size(100, 28);
            this.ConfirmDeleteBTN.TabIndex = 4;
            this.ConfirmDeleteBTN.Text = "Delete";
            this.ConfirmDeleteBTN.UseVisualStyleBackColor = true;
            this.ConfirmDeleteBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Are You Sure You Want To DELETE This Item?";
            // 
            // AdminConfirmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 180);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ConfirmDeleteBTN);
            this.Controls.Add(this.label1);
            this.Name = "AdminConfirmDelete";
            this.Text = "AdminConfirmDelete";
            this.Load += new System.EventHandler(this.AdminConfirmDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ConfirmDeleteBTN;
        private System.Windows.Forms.Label label1;
    }
}