
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
            this.readinggoallbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readinggoallbl.Location = new System.Drawing.Point(85, 37);
            this.readinggoallbl.Name = "readinggoallbl";
            this.readinggoallbl.Size = new System.Drawing.Size(192, 26);
            this.readinggoallbl.TabIndex = 0;
            this.readinggoallbl.Text = "Yearly Reading Goal";
            // 
            // setGoalbtn
            // 
            this.setGoalbtn.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setGoalbtn.Location = new System.Drawing.Point(237, 79);
            this.setGoalbtn.Name = "setGoalbtn";
            this.setGoalbtn.Size = new System.Drawing.Size(71, 32);
            this.setGoalbtn.TabIndex = 1;
            this.setGoalbtn.Text = "Set Goal";
            this.setGoalbtn.UseVisualStyleBackColor = true;
            this.setGoalbtn.Click += new System.EventHandler(this.setGoalbtn_Click);
            // 
            // numericYearlyGoal
            // 
            this.numericYearlyGoal.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericYearlyGoal.Location = new System.Drawing.Point(90, 79);
            this.numericYearlyGoal.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericYearlyGoal.Name = "numericYearlyGoal";
            this.numericYearlyGoal.Size = new System.Drawing.Size(120, 27);
            this.numericYearlyGoal.TabIndex = 2;
            // 
            // generateReport
            // 
            this.generateReport.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReport.Location = new System.Drawing.Point(75, 152);
            this.generateReport.Name = "generateReport";
            this.generateReport.Size = new System.Drawing.Size(233, 69);
            this.generateReport.TabIndex = 3;
            this.generateReport.Text = "Generate Reading Goal Report";
            this.generateReport.UseVisualStyleBackColor = true;
            this.generateReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReadingGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(413, 261);
            this.Controls.Add(this.generateReport);
            this.Controls.Add(this.numericYearlyGoal);
            this.Controls.Add(this.setGoalbtn);
            this.Controls.Add(this.readinggoallbl);
            this.Name = "ReadingGoals";
            this.Text = " Get Reading Goals";
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