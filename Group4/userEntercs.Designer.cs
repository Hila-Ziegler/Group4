namespace Group4
{
    partial class userEntercs
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
            this.labUserLogin = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.MaskedTextBox();
            this.labUser = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labUserLogin
            // 
            this.labUserLogin.AutoSize = true;
            this.labUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labUserLogin.Location = new System.Drawing.Point(229, 48);
            this.labUserLogin.Name = "labUserLogin";
            this.labUserLogin.Size = new System.Drawing.Size(213, 39);
            this.labUserLogin.TabIndex = 0;
            this.labUserLogin.Text = "כניסת משתמש";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtUserName.Location = new System.Drawing.Point(145, 128);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(258, 45);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TxtPassword.Location = new System.Drawing.Point(145, 230);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(258, 45);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxtPassword_MaskInputRejected);
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labUser.Location = new System.Drawing.Point(509, 134);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(254, 39);
            this.labUser.TabIndex = 3;
            this.labUser.Text = "הכנס שם משתמש";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labPassword.Location = new System.Drawing.Point(509, 236);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(187, 39);
            this.labPassword.TabIndex = 4;
            this.labPassword.Text = "הכנס סיסמה";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnEnter.Location = new System.Drawing.Point(209, 329);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(128, 48);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "כניסה";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // userEntercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labUserLogin);
            this.Name = "userEntercs";
            this.Load += new System.EventHandler(this.userEntercs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labUserLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.MaskedTextBox TxtPassword;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Button btnEnter;
    }
}