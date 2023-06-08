
namespace Group4
{
    partial class ReadingGoals
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
            this.readinggoallbl = new System.Windows.Forms.Label();
            this.setGoalbtn = new System.Windows.Forms.Button();
            this.numericYearlyGoal = new System.Windows.Forms.NumericUpDown();
            this.generateReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearlyGoal)).BeginInit();
            this.SuspendLayout();
            // 
            // readinggoallbl
            // 
            this.readinggoallbl.AutoSize = true;
            this.readinggoallbl.Location = new System.Drawing.Point(103, 63);
            this.readinggoallbl.Name = "readinggoallbl";
            this.readinggoallbl.Size = new System.Drawing.Size(139, 17);
            this.readinggoallbl.TabIndex = 0;
            this.readinggoallbl.Text = "Yearly Reading Goal";
            // 
            // setGoalbtn
            // 
            this.setGoalbtn.Location = new System.Drawing.Point(264, 73);
            this.setGoalbtn.Name = "setGoalbtn";
            this.setGoalbtn.Size = new System.Drawing.Size(75, 23);
            this.setGoalbtn.TabIndex = 1;
            this.setGoalbtn.Text = "Set Goal";
            this.setGoalbtn.UseVisualStyleBackColor = true;
            this.setGoalbtn.Click += new System.EventHandler(this.setGoalbtn_Click);
            // 
            // numericYearlyGoal
            // 
            this.numericYearlyGoal.Location = new System.Drawing.Point(122, 83);
            this.numericYearlyGoal.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericYearlyGoal.Name = "numericYearlyGoal";
            this.numericYearlyGoal.Size = new System.Drawing.Size(120, 22);
            this.numericYearlyGoal.TabIndex = 2;
            // 
            // generateReport
            // 
            this.generateReport.Location = new System.Drawing.Point(161, 144);
            this.generateReport.Name = "generateReport";
            this.generateReport.Size = new System.Drawing.Size(120, 72);
            this.generateReport.TabIndex = 3;
            this.generateReport.Text = "Generate Reading Goal Report";
            this.generateReport.UseVisualStyleBackColor = true;
            this.generateReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReadingGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 252);
            this.Controls.Add(this.generateReport);
            this.Controls.Add(this.numericYearlyGoal);
            this.Controls.Add(this.setGoalbtn);
            this.Controls.Add(this.readinggoallbl);
            this.Name = "ReadingGoals";
            this.Text = "ReadingGoals";
            this.Load += new System.EventHandler(this.ReadingGoals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericYearlyGoal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label readinggoallbl;
        private System.Windows.Forms.Button setGoalbtn;
        private System.Windows.Forms.NumericUpDown numericYearlyGoal;
        private System.Windows.Forms.Button generateReport;
    }
}