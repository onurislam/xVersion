using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static xVersion.Classes.Config;

namespace xVersion.Classes
{
    internal class WebRequest
    {
        public class ApiResponse
        {
            public string statu { get; set; }
            public string result { get; set; }
        }

        public static string[] Directions()
        {

            Configs config = Config.ConfigRead();
            using var httpClient = new HttpClient();
            var response = httpClient.GetAsync(config.SourceURL + "/backup.php?key=" + config.SecureKey + "&type=dir&ignore=" + config.Ignore).Result;
            var content = response.Content.ReadAsStringAsync().Result;
            string[] data = JsonConvert.DeserializeObject<string[]>(content);

            return data;
        }

        public static ApiResponse Request(string folderName)
        {
            ApiResponse data = null;
            try
            {
                Configs config = Config.ConfigRead();
                using var httpClient = new HttpClient();
                var response = httpClient.GetAsync(config.SourceURL + "/backup.php?key=" + config.SecureKey + "&ignore=" + config.Ignore + "&backupfolder=" + config.BackupFile + "&type=" + folderName).Result;
                var content = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject<ApiResponse>(content);


            }
            catch
            {
                data = new ApiResponse { statu = "error", result = "try error" };
            }
            return data;

        }

        public static void Download(string Version)
        {
            Configs config = Config.ConfigRead();
            using var client = new WebClient();
            client.DownloadFile(config.SourceURL + "/" + config.BackupFile + "/" + Version, Version);
        }


    }
}
