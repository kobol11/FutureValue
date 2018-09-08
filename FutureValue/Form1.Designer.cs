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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_monthlyinvetsment);
            this.Name = "Form1";
            this.Text = "Future Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_monthlyinvetsment;
    }
}

