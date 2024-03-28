namespace xVersion
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Request = new System.Windows.Forms.Button();
            cmbSource = new System.Windows.Forms.ComboBox();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tbSettings = new System.Windows.Forms.ToolStripLabel();
            label1 = new System.Windows.Forms.Label();
            logs = new System.Windows.Forms.ListBox();
            label2 = new System.Windows.Forms.Label();
            lbrefcmb = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Request
            // 
            Request.Location = new System.Drawing.Point(166, 117);
            Request.Name = "Request";
            Request.Size = new System.Drawing.Size(228, 34);
            Request.TabIndex = 0;
            Request.Text = "Version Sync";
            Request.UseVisualStyleBackColor = true;
            Request.Click += Request_Click;
            // 
            // cmbSource
            // 
            cmbSource.FormattingEnabled = true;
            cmbSource.Location = new System.Drawing.Point(24, 75);
            cmbSource.Name = "cmbSource";
            cmbSource.Size = new System.Drawing.Size(370, 33);
            cmbSource.TabIndex = 2;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tbSettings });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(422, 30);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // tbSettings
            // 
            tbSettings.Name = "tbSettings";
            tbSettings.Size = new System.Drawing.Size(76, 25);
            tbSettings.Text = "Settings";
            tbSettings.Click += tbSettings_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(24, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(175, 25);
            label1.TabIndex = 4;
            label1.Text = "Server Source Folder";
            // 
            // logs
            // 
            logs.FormattingEnabled = true;
            logs.ItemHeight = 25;
            logs.Location = new System.Drawing.Point(24, 157);
            logs.Name = "logs";
            logs.Size = new System.Drawing.Size(370, 204);
            logs.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(24, 129);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 25);
            label2.TabIndex = 6;
            label2.Text = "Logs";
            // 
            // lbrefcmb
            // 
            lbrefcmb.AutoSize = true;
            lbrefcmb.Location = new System.Drawing.Point(205, 46);
            lbrefcmb.Name = "lbrefcmb";
            lbrefcmb.Size = new System.Drawing.Size(80, 25);
            lbrefcmb.TabIndex = 7;
            lbrefcmb.Text = "(Refresh)";
            lbrefcmb.Click += lbrefcmb_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(312, 364);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(82, 25);
            label3.TabIndex = 8;
            label3.Text = "mtroLAB";
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(422, 398);
            Controls.Add(label3);
            Controls.Add(lbrefcmb);
            Controls.Add(label2);
            Controls.Add(logs);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(cmbSource);
            Controls.Add(Request);
            Name = "Main";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "xVersion | v0.1";
            Load += Main_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Request;
        private System.Windows.Forms.ComboBox cmbSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tbSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox logs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbrefcmb;
        private System.Windows.Forms.Label label3;
    }
}
