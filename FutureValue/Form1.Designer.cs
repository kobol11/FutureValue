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
            this.txb_MonthlyInvestment = new System.Windows.Forms.TextBox();
            this.txb_YearlyInterestRate = new System.Windows.Forms.TextBox();
            this.txb_NoOfYears = new System.Windows.Forms.TextBox();
            this.txb_FutureValue = new System.Windows.Forms.TextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
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
            this.lbl_yearlyinterestrate.Location = new System.Drawing.Point(30, 80);
            this.lbl_yearlyinterestrate.Name = "lbl_yearlyinterestrate";
            this.lbl_yearlyinterestrate.Size = new System.Drawing.Size(103, 13);
            this.lbl_yearlyinterestrate.TabIndex = 1;
            this.lbl_yearlyinterestrate.Text = "Yearly Interest Rate:";
            // 
            // lbl_NoOfYears
            // 
            this.lbl_NoOfYears.AutoSize = true;
            this.lbl_NoOfYears.Location = new System.Drawing.Point(30, 116);
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
            // txb_MonthlyInvestment
            // 
            this.txb_MonthlyInvestment.Location = new System.Drawing.Point(186, 37);
            this.txb_MonthlyInvestment.Name = "txb_MonthlyInvestment";
            this.txb_MonthlyInvestment.Size = new System.Drawing.Size(100, 20);
            this.txb_MonthlyInvestment.TabIndex = 4;
            // 
            // txb_YearlyInterestRate
            // 
            this.txb_YearlyInterestRate.Location = new System.Drawing.Point(186, 73);
            this.txb_YearlyInterestRate.Name = "txb_YearlyInterestRate";
            this.txb_YearlyInterestRate.Size = new System.Drawing.Size(100, 20);
            this.txb_YearlyInterestRate.TabIndex = 5;
            // 
            // txb_NoOfYears
            // 
            this.txb_NoOfYears.Location = new System.Drawing.Point(186, 109);
            this.txb_NoOfYears.Name = "txb_NoOfYears";
            this.txb_NoOfYears.Size = new System.Drawing.Size(100, 20);
            this.txb_NoOfYears.TabIndex = 6;
            // 
            // txb_FutureValue
            // 
            this.txb_FutureValue.Location = new System.Drawing.Point(186, 145);
            this.txb_FutureValue.Name = "txb_FutureValue";
            this.txb_FutureValue.ReadOnly = true;
            this.txb_FutureValue.Size = new System.Drawing.Size(100, 20);
            this.txb_FutureValue.TabIndex = 7;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(79, 207);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate.TabIndex = 8;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(211, 207);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.txb_FutureValue);
            this.Controls.Add(this.txb_NoOfYears);
            this.Controls.Add(this.txb_YearlyInterestRate);
            this.Controls.Add(this.txb_MonthlyInvestment);
            this.Controls.Add(this.lbl_FutureValue);
            this.Controls.Add(this.lbl_NoOfYears);
            this.Controls.Add(this.lbl_yearlyinterestrate);
            this.Controls.Add(this.lbl_monthlyinvetsment);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_monthlyinvetsment;
        private System.Windows.Forms.Label lbl_yearlyinterestrate;
        private System.Windows.Forms.Label lbl_NoOfYears;
        private System.Windows.Forms.Label lbl_FutureValue;
        private System.Windows.Forms.TextBox txb_MonthlyInvestment;
        private System.Windows.Forms.TextBox txb_YearlyInterestRate;
        private System.Windows.Forms.TextBox txb_NoOfYears;
        private System.Windows.Forms.TextBox txb_FutureValue;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Exit;
    }
}

