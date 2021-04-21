
namespace PersonnelRegistrationAutomation
{
    partial class Statistics
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblTotPer = new System.Windows.Forms.Label();
            this.LblTotSalary = new System.Windows.Forms.Label();
            this.LblDifCity = new System.Windows.Forms.Label();
            this.LblAvgSalary = new System.Windows.Forms.Label();
            this.LblMarried = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Personnel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Salary:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Different City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average Salary:";
            // 
            // LblTotPer
            // 
            this.LblTotPer.AutoSize = true;
            this.LblTotPer.Location = new System.Drawing.Point(256, 55);
            this.LblTotPer.Name = "LblTotPer";
            this.LblTotPer.Size = new System.Drawing.Size(25, 29);
            this.LblTotPer.TabIndex = 4;
            this.LblTotPer.Text = "0";
            // 
            // LblTotSalary
            // 
            this.LblTotSalary.AutoSize = true;
            this.LblTotSalary.Location = new System.Drawing.Point(256, 154);
            this.LblTotSalary.Name = "LblTotSalary";
            this.LblTotSalary.Size = new System.Drawing.Size(25, 29);
            this.LblTotSalary.TabIndex = 5;
            this.LblTotSalary.Text = "0";
            this.LblTotSalary.Click += new System.EventHandler(this.label6_Click);
            // 
            // LblDifCity
            // 
            this.LblDifCity.AutoSize = true;
            this.LblDifCity.Location = new System.Drawing.Point(256, 104);
            this.LblDifCity.Name = "LblDifCity";
            this.LblDifCity.Size = new System.Drawing.Size(25, 29);
            this.LblDifCity.TabIndex = 6;
            this.LblDifCity.Text = "0";
            // 
            // LblAvgSalary
            // 
            this.LblAvgSalary.AutoSize = true;
            this.LblAvgSalary.Location = new System.Drawing.Point(256, 203);
            this.LblAvgSalary.Name = "LblAvgSalary";
            this.LblAvgSalary.Size = new System.Drawing.Size(25, 29);
            this.LblAvgSalary.TabIndex = 7;
            this.LblAvgSalary.Text = "0";
            // 
            // LblMarried
            // 
            this.LblMarried.AutoSize = true;
            this.LblMarried.Location = new System.Drawing.Point(256, 250);
            this.LblMarried.Name = "LblMarried";
            this.LblMarried.Size = new System.Drawing.Size(25, 29);
            this.LblMarried.TabIndex = 9;
            this.LblMarried.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Married Personnel:";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(401, 327);
            this.Controls.Add(this.LblMarried);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblAvgSalary);
            this.Controls.Add(this.LblDifCity);
            this.Controls.Add(this.LblTotSalary);
            this.Controls.Add(this.LblTotPer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Statistics_FormClosed);
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblTotPer;
        private System.Windows.Forms.Label LblTotSalary;
        private System.Windows.Forms.Label LblDifCity;
        private System.Windows.Forms.Label LblAvgSalary;
        private System.Windows.Forms.Label LblMarried;
        private System.Windows.Forms.Label label6;
    }
}