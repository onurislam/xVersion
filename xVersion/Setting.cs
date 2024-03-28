using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static xVersion.Classes.Config;
using xVersion.Classes;
using System.IO;

namespace xVersion
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            if (File.Exists("config.json"))
            {
                Configs Data = Config.ConfigRead();
                txtSourceUrl.Text = Data.SourceURL.ToString();
                txtLocalDir.Text = Data.LocalDir;
                if (Data.BackupFile != "")
                    txtBackupFile.Text = Data.BackupFile;
                if (Data.Ignore != "")
                    txtIgnore.Text = Data.Ignore;
            }
            else
            {
                MessageBox.Show("Enter your information for backup remote configuration!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Config.ConfigSave(new Configs
            {
                SourceURL = txtSourceUrl.Text,
                Ignore = txtIgnore.Text,
                BackupFile = txtBackupFile.Text,
                LocalDir = txtLocalDir.Text
            });
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtLocalDir.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
