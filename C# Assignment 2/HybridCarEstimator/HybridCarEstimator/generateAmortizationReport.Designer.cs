namespace HybridCarEstimator
{
    partial class generateAmortizationReport
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
            this.listBoxAmrtizationReport = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxAmrtizationReport
            // 
            this.listBoxAmrtizationReport.FormattingEnabled = true;
            this.listBoxAmrtizationReport.Location = new System.Drawing.Point(13, 13);
            this.listBoxAmrtizationReport.Name = "listBoxAmrtizationReport";
            this.listBoxAmrtizationReport.Size = new System.Drawing.Size(120, 95);
            this.listBoxAmrtizationReport.TabIndex = 0;
            this.listBoxAmrtizationReport.SelectedIndexChanged += new System.EventHandler(this.listBoxAmrtizationReport_SelectedIndexChanged);
            // 
            // generateAmortizationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 395);
            this.Controls.Add(this.listBoxAmrtizationReport);
            this.Name = "generateAmortizationReport";
            this.Text = "generateAmortizationReport";
            this.Load += new System.EventHandler(this.generateAmortizationReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAmrtizationReport;
    }
}