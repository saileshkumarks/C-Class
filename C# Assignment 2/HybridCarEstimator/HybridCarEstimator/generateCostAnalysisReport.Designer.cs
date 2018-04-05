namespace HybridCarEstimator
{
    partial class generateCostAnalysisReport
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
            this.lblReport1 = new System.Windows.Forms.Label();
            this.dataGridViewReport1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMulitline = new System.Windows.Forms.TextBox();
            this.dataGridViewReport2 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReport1
            // 
            this.lblReport1.AutoSize = true;
            this.lblReport1.Location = new System.Drawing.Point(13, 13);
            this.lblReport1.Name = "lblReport1";
            this.lblReport1.Size = new System.Drawing.Size(127, 13);
            this.lblReport1.TabIndex = 0;
            this.lblReport1.Text = "Report 1: All Assumptions";
            // 
            // dataGridViewReport1
            // 
            this.dataGridViewReport1.AllowUserToDeleteRows = false;
            this.dataGridViewReport1.AllowUserToOrderColumns = true;
            this.dataGridViewReport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport1.Location = new System.Drawing.Point(16, 43);
            this.dataGridViewReport1.Name = "dataGridViewReport1";
            this.dataGridViewReport1.ReadOnly = true;
            this.dataGridViewReport1.Size = new System.Drawing.Size(250, 305);
            this.dataGridViewReport1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Report 2: Cost of Ownership Report";
            // 
            // txtMulitline
            // 
            this.txtMulitline.Location = new System.Drawing.Point(294, 42);
            this.txtMulitline.Multiline = true;
            this.txtMulitline.Name = "txtMulitline";
            this.txtMulitline.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMulitline.Size = new System.Drawing.Size(525, 84);
            this.txtMulitline.TabIndex = 3;
            // 
            // dataGridViewReport2
            // 
            this.dataGridViewReport2.AllowUserToOrderColumns = true;
            this.dataGridViewReport2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport2.Location = new System.Drawing.Point(294, 150);
            this.dataGridViewReport2.Name = "dataGridViewReport2";
            this.dataGridViewReport2.Size = new System.Drawing.Size(783, 138);
            this.dataGridViewReport2.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(294, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // generateCostAnalysisReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 407);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridViewReport2);
            this.Controls.Add(this.txtMulitline);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewReport1);
            this.Controls.Add(this.lblReport1);
            this.Name = "generateCostAnalysisReport";
            this.Text = "generateCostAnalysisReport";
            this.Load += new System.EventHandler(this.generateCostAnalysisReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReport1;
        private System.Windows.Forms.DataGridView dataGridViewReport1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMulitline;
        private System.Windows.Forms.DataGridView dataGridViewReport2;
        private System.Windows.Forms.Button btnSave;
    }
}