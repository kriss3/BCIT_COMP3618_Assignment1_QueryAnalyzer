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
            this.txtConnectionDetails.Location = new System.Drawing.Point(16, 36);
            this.txtConnectionDetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtConnectionDetails.Multiline = true;
            this.txtConnectionDetails.Name = "txtConnectionDetails";
            this.txtConnectionDetails.ReadOnly = true;
            this.txtConnectionDetails.Size = new System.Drawing.Size(445, 151);
            this.txtConnectionDetails.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection Details:";
            // 
            // sStrip
            // 
            this.sStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblToolStripStatus});
            this.sStrip.Location = new System.Drawing.Point(0, 227);
            this.sStrip.Name = "sStrip";
            this.sStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.sStrip.Size = new System.Drawing.Size(479, 25);
            this.sStrip.TabIndex = 2;
            this.sStrip.Text = "statusStrip";
            // 
            // lblToolStripStatus
            // 
            this.lblToolStripStatus.Name = "lblToolStripStatus";
            this.lblToolStripStatus.Size = new System.Drawing.Size(143, 20);
            this.lblToolStripStatus.Text = "toolStripStatusLabel";
            // 
            // btnAnalyzer
            // 
            this.btnAnalyzer.Location = new System.Drawing.Point(361, 195);
            this.btnAnalyzer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnalyzer.Name = "btnAnalyzer";
            this.btnAnalyzer.Size = new System.Drawing.Size(100, 28);
            this.btnAnalyzer.TabIndex = 3;
            this.btnAnalyzer.Text = "Sql Analyzer";
            this.btnAnalyzer.UseVisualStyleBackColor = true;
            this.btnAnalyzer.Click += new System.EventHandler(this.btnAnalyzer_Click);
            // 
            // frmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 252);
            this.Controls.Add(this.btnAnalyzer);
            this.Controls.Add(this.sStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConnectionDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BCIT 3618 Assignment 1 by Krzysztof Szczurowski";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConnection_FormClosing);
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

