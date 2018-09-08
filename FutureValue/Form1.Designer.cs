namespace FutureValue
{
    partial class Form1
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
            this.lbl_monthlyinvetsment = new System.Windows.Forms.Label();
            this.lbl_yearlyinterestrate = new System.Windows.Forms.Label();
            this.lbl_NoOfYears = new System.Windows.Forms.Label();
            this.lbl_FutureValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_monthlyinvetsment
            // 
            this.lbl_monthlyinvetsment.AutoSize = true;
            this.lbl_monthlyinvetsment.Location = new System.Drawing.Point(30, 44);
            this.lbl_monthlyinvetsment.Name = "lbl_monthlyinvetsment";
            this.lbl_monthlyinvetsment.Size = new System.Drawing.Size(102, 13);
            this.lbl_monthlyinvetsment.TabIndex = 0;
            this.lbl_monthlyinvetsment.Text = "Monthly Investment:";
            // 
            // lbl_yearlyinterestrate
            // 
            this.lbl_yearlyinterestrate.AutoSize = true;
            this.lbl_yearlyinterestrate.Location = new System.Drawing.Point(30, 77);
            this.lbl_yearlyinterestrate.Name = "lbl_yearlyinterestrate";
            this.lbl_yearlyinterestrate.Size = new System.Drawing.Size(103, 13);
            this.lbl_yearlyinterestrate.TabIndex = 1;
            this.lbl_yearlyinterestrate.Text = "Yearly Interest Rate:";
            // 
            // lbl_NoOfYears
            // 
            this.lbl_NoOfYears.AutoSize = true;
            this.lbl_NoOfYears.Location = new System.Drawing.Point(30, 114);
            this.lbl_NoOfYears.Name = "lbl_NoOfYears";
            this.lbl_NoOfYears.Size = new System.Drawing.Size(89, 13);
            this.lbl_NoOfYears.TabIndex = 2;
            this.lbl_NoOfYears.Text = "Number of Years:";
            // 
            // lbl_FutureValue
            // 
            this.lbl_FutureValue.AutoSize = true;
            this.lbl_FutureValue.Location = new System.Drawing.Point(30, 152);
            this.lbl_FutureValue.Name = "lbl_FutureValue";
            this.lbl_FutureValue.Size = new System.Drawing.Size(70, 13);
            this.lbl_FutureValue.TabIndex = 3;
            this.lbl_FutureValue.Text = "Future Value:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_FutureValue);
            this.Controls.Add(this.lbl_NoOfYears);
            this.Controls.Add(this.lbl_yearlyinterestrate);
            this.Controls.Add(this.lbl_monthlyinvetsment);
            this.Name = "Form1";
            this.Text = "Future Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_monthlyinvetsment;
        private System.Windows.Forms.Label lbl_yearlyinterestrate;
        private System.Windows.Forms.Label lbl_NoOfYears;
        private System.Windows.Forms.Label lbl_FutureValue;
    }
}

