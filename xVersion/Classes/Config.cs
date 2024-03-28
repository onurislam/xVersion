using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace xVersion.Classes
{
    internal class Config
    {
        public class Configs
        {
            public string SourceURL { get; set; }
            public string Ignore { get; set; } 
            public string BackupFile { get; set; }
            public string LocalDir { get; set; }
            public string SecureKey { get; set; }
        }

        public static void ConfigSave(Configs config)
        {
            try
            {
                string jsonText = JsonConvert.SerializeObject(config, Formatting.Indented);
                string configPath = "config.json";
                File.WriteAllText(configPath, jsonText);

                MessageBox.Show("Configuration saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving configuration file: " + ex.Message);
            }
        }

        public static Configs ConfigRead()
        {
            string configPath = "config.json";
            Configs result = null;
            if (File.Exists(configPath))
            {
                result = JsonConvert.DeserializeObject<Configs>(File.ReadAllText(configPath));
            }
            return result;
            // config.SourceURL

        }
    }
}
