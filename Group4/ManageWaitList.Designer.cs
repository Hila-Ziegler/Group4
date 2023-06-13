
namespace Group4
{
    partial class ManageWaitList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentIdlbl = new System.Windows.Forms.Label();
            this.StudentIDComboBox = new System.Windows.Forms.ComboBox();
            this.addToWaitListbtn = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Closebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.AddedOn});
            this.dataGridView1.Location = new System.Drawing.Point(122, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(439, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // StudentIdlbl
            // 
            this.StudentIdlbl.AutoSize = true;
            this.StudentIdlbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIdlbl.Location = new System.Drawing.Point(119, 79);
            this.StudentIdlbl.Name = "StudentIdlbl";
            this.StudentIdlbl.Size = new System.Drawing.Size(124, 26);
            this.StudentIdlbl.TabIndex = 1;
            this.StudentIdlbl.Text = "Student\'s ID:";
            // 
            // StudentIDComboBox
            // 
            this.StudentIDComboBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDComboBox.FormattingEnabled = true;
            this.StudentIDComboBox.Location = new System.Drawing.Point(124, 108);
            this.StudentIDComboBox.Name = "StudentIDComboBox";
            this.StudentIDComboBox.Size = new System.Drawing.Size(138, 34);
            this.StudentIDComboBox.TabIndex = 2;
            this.StudentIDComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // addToWaitListbtn
            // 
            this.addToWaitListbtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToWaitListbtn.Location = new System.Drawing.Point(268, 108);
            this.addToWaitListbtn.Name = "addToWaitListbtn";
            this.addToWaitListbtn.Size = new System.Drawing.Size(199, 34);
            this.addToWaitListbtn.TabIndex = 3;
            this.addToWaitListbtn.Text = "Add to Waitlist";
            this.addToWaitListbtn.UseVisualStyleBackColor = true;
            this.addToWaitListbtn.Click += new System.EventHandler(this.addToWaitListbtn_Click);
            // 
            // Student
            // 
            this.Student.HeaderText = "Student";
            this.Student.MinimumWidth = 6;
            this.Student.Name = "Student";
            this.Student.Width = 125;
            // 
            // AddedOn
            // 
            this.AddedOn.HeaderText = "Added On";
            this.AddedOn.MinimumWidth = 6;
            this.AddedOn.Name = "AddedOn";
            this.AddedOn.Width = 125;
            // 
            // Closebtn
            // 
            this.Closebtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closebtn.Location = new System.Drawing.Point(298, 372);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(87, 43);
            this.Closebtn.TabIndex = 4;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // ManageWaitList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.addToWaitListbtn);
            this.Controls.Add(this.StudentIDComboBox);
            this.Controls.Add(this.StudentIdlbl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageWaitList";
            this.Text = "ManageWaitList";
            this.Load += new System.EventHandler(this.ManageWaitList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label StudentIdlbl;
        private System.Windows.Forms.ComboBox StudentIDComboBox;
        private System.Windows.Forms.Button addToWaitListbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedOn;
        private System.Windows.Forms.Button Closebtn;
    }
}