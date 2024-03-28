using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xVersion.Classes;
using static System.Windows.Forms.DataFormats;
using static xVersion.Classes.Config;
using static xVersion.Classes.WebRequest;

namespace xVersion
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Request_Click(object sender, EventArgs e)
        {

            if (cmbSource.SelectedItem != null)
            {
                string selectItem = cmbSource.SelectedItem.ToString();
                ApiResponse Req = WebRequest.Request(selectItem);
                if (Req.statu == "success")
                {
                    Configs config = Config.ConfigRead();
                    string version = Req.result;
                    WebRequest.Download(version);
                    FileProcess.Delete(config.LocalDir + "\\" + selectItem, 1);
                    FileProcess.unZip(version, config.LocalDir, selectItem);
                    logs.Items.Add(version + " Version Syc");
                }
                else
                {
                    MessageBox.Show(Req.result.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please Select Server Source Folder!");
            }

        }

        private void tbSettings_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (File.Exists("config.json"))
            {
                Configs config = Config.ConfigRead();

                foreach (string item in WebRequest.Directions())
                {
                    cmbSource.Items.Add(item);
                }

            }
            else
            {
                Setting setting = new Setting();
                setting.ShowDialog();
            }
        }

        private void lbrefcmb_Click(object sender, EventArgs e)
        {
            if (File.Exists("config.json"))
            {
                Configs config = Config.ConfigRead();
                cmbSource.Items.Clear();
                foreach (string item in WebRequest.Directions())
                {
                    cmbSource.Items.Add(item);
                }
                MessageBox.Show("Server Source Folder Refresh!");
            }
            else
            {
                Setting setting = new Setting();
                setting.ShowDialog();
            }
        }
    }
}
