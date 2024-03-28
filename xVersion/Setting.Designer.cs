namespace xVersion
{
    partial class Setting
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
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtIgnore = new System.Windows.Forms.TextBox();
            txtSourceUrl = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            txtBackupFile = new System.Windows.Forms.TextBox();
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            txtLocalDir = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            btnPath = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            txtSecureKey = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(50, 365);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(103, 25);
            label2.TabIndex = 9;
            label2.Text = "Ignore Files";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(50, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 25);
            label1.TabIndex = 8;
            label1.Text = "Source URL";
            // 
            // txtIgnore
            // 
            txtIgnore.Location = new System.Drawing.Point(50, 395);
            txtIgnore.Multiline = true;
            txtIgnore.Name = "txtIgnore";
            txtIgnore.Size = new System.Drawing.Size(338, 93);
            txtIgnore.TabIndex = 7;
            txtIgnore.Text = "{\"file\":[\"backup.php\"],\"dir\":[\".well-known\",\"backup\",\"cdn\"]}";
            // 
            // txtSourceUrl
            // 
            txtSourceUrl.Location = new System.Drawing.Point(50, 65);
            txtSourceUrl.Name = "txtSourceUrl";
            txtSourceUrl.Size = new System.Drawing.Size(338, 31);
            txtSourceUrl.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(50, 502);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(130, 34);
            btnSave.TabIndex = 5;
            btnSave.Text = "Config Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(50, 110);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(233, 25);
            label3.TabIndex = 11;
            label3.Text = "Backup File Name (optionel)";
            // 
            // txtBackupFile
            // 
            txtBackupFile.Location = new System.Drawing.Point(50, 140);
            txtBackupFile.Name = "txtBackupFile";
            txtBackupFile.Size = new System.Drawing.Size(338, 31);
            txtBackupFile.TabIndex = 10;
            txtBackupFile.Text = "backup";
            // 
            // txtLocalDir
            // 
            txtLocalDir.AcceptsReturn = true;
            txtLocalDir.Location = new System.Drawing.Point(50, 314);
            txtLocalDir.Name = "txtLocalDir";
            txtLocalDir.Size = new System.Drawing.Size(288, 31);
            txtLocalDir.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(50, 284);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(169, 25);
            label4.TabIndex = 11;
            label4.Text = "Local Backup Folder";
            // 
            // btnPath
            // 
            btnPath.Location = new System.Drawing.Point(344, 314);
            btnPath.Name = "btnPath";
            btnPath.Size = new System.Drawing.Size(44, 34);
            btnPath.TabIndex = 12;
            btnPath.Text = "...";
            btnPath.UseVisualStyleBackColor = true;
            btnPath.Click += btnPath_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(50, 196);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(159, 25);
            label5.TabIndex = 14;
            label5.Text = "Backup Secure Key";
            // 
            // txtSecureKey
            // 
            txtSecureKey.Location = new System.Drawing.Point(50, 226);
            txtSecureKey.Name = "txtSecureKey";
            txtSecureKey.Size = new System.Drawing.Size(338, 31);
            txtSecureKey.TabIndex = 13;
            txtSecureKey.Text = "securekey12345";
            // 
            // Setting
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(433, 613);
            Controls.Add(label5);
            Controls.Add(txtSecureKey);
            Controls.Add(btnPath);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtLocalDir);
            Controls.Add(txtBackupFile);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIgnore);
            Controls.Add(txtSourceUrl);
            Controls.Add(btnSave);
            Name = "Setting";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Setting";
            Load += Setting_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIgnore;
        private System.Windows.Forms.TextBox txtSourceUrl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBackupFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtLocalDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSecureKey;
    }
}