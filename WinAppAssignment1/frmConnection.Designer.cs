namespace WinAppAssignment1
{
    partial class frmConnection
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
            this.txtConnectionDetails = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sStrip = new System.Windows.Forms.StatusStrip();
            this.lblToolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAnalyzer = new System.Windows.Forms.Button();
            this.sStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConnectionDetails
            // 
            this.txtConnectionDetails.Location = new System.Drawing.Point(12, 29);
            this.txtConnectionDetails.Multiline = true;
            this.txtConnectionDetails.Name = "txtConnectionDetails";
            this.txtConnectionDetails.ReadOnly = true;
            this.txtConnectionDetails.Size = new System.Drawing.Size(335, 94);
            this.txtConnectionDetails.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection Details:";
            // 
            // sStrip
            // 
            this.sStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblToolStripStatus});
            this.sStrip.Location = new System.Drawing.Point(0, 157);
            this.sStrip.Name = "sStrip";
            this.sStrip.Size = new System.Drawing.Size(359, 22);
            this.sStrip.TabIndex = 2;
            this.sStrip.Text = "statusStrip";
            // 
            // lblToolStripStatus
            // 
            this.lblToolStripStatus.Name = "lblToolStripStatus";
            this.lblToolStripStatus.Size = new System.Drawing.Size(112, 17);
            this.lblToolStripStatus.Text = "toolStripStatusLabel";
            // 
            // btnAnalyzer
            // 
            this.btnAnalyzer.Location = new System.Drawing.Point(272, 129);
            this.btnAnalyzer.Name = "btnAnalyzer";
            this.btnAnalyzer.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyzer.TabIndex = 3;
            this.btnAnalyzer.Text = "Sql Analyzer";
            this.btnAnalyzer.UseVisualStyleBackColor = true;
            this.btnAnalyzer.Click += new System.EventHandler(this.btnAnalyzer_Click);
            // 
            // frmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 179);
            this.Controls.Add(this.btnAnalyzer);
            this.Controls.Add(this.sStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConnectionDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BCIT 3618 Assignment 1 by Krzysztof Szczurowski";
            this.Load += new System.EventHandler(this.frmConnection_Load);
            this.sStrip.ResumeLayout(false);
            this.sStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnectionDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip sStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblToolStripStatus;
        private System.Windows.Forms.Button btnAnalyzer;
    }
}

