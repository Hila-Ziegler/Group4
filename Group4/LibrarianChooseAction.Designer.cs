﻿
namespace Group4
{
    partial class LibrarianChooseAction
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
            this.TitleText = new System.Windows.Forms.Label();
            this.Action = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleText
            // 
            this.TitleText.AutoSize = true;
            this.TitleText.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleText.Location = new System.Drawing.Point(72, 45);
            this.TitleText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(756, 76);
            this.TitleText.TabIndex = 0;
            this.TitleText.Text = "Library Managment System";
            // 
            // Action
            // 
            this.Action.AutoSize = true;
            this.Action.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Action.Location = new System.Drawing.Point(306, 196);
            this.Action.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(267, 28);
            this.Action.TabIndex = 1;
            this.Action.Text = "Please choose an action:";
            this.Action.Click += new System.EventHandler(this.Action_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(225, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Books";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(512, 286);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 57);
            this.button2.TabIndex = 3;
            this.button2.Text = "Requests";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 426);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "The library is a brand, when you\'ve got a card in your hand";
            // 
            // LibrarianChooseAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(926, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.TitleText);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LibrarianChooseAction";
            this.Text = "Library Managment System";
            this.Load += new System.EventHandler(this.LibrarianChooseAction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.Label Action;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}