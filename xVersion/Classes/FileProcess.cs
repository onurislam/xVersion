using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xVersion.Classes
{
    internal class FileProcess
    {
        public static string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public static void DeleteFolder(string folderPath)
        {
            foreach (string filePath in Directory.GetFiles(folderPath))
            {
                File.Delete(filePath);
            }
            foreach (string subFolderPath in Directory.GetDirectories(folderPath))
            {
                DeleteFolder(subFolderPath);
            }
            Directory.Delete(folderPath);
        }
        public static void Delete(string path, int main)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    string[] files = Directory.GetFiles(path);
                    string[] subDirectories = Directory.GetDirectories(path);

                    foreach (string file in files)
                    {
                        File.Delete(file);
                    }

                    foreach (string directory in subDirectories)
                    {
                        if (Path.GetFileName(directory).ToLower() != ".idea" || Path.GetFileName(directory).ToLower() != ".git" || Path.GetFileName(directory).ToLower() != ".gitignore")
                        {
                            DeleteFolder(directory);
                        }
                    }

                    /*if (main == 1)
                    {
                        Directory.Delete(path);
                    }*/
                }
                else
                {
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Delete ERROR: " + e.Message);
            }

        }

        public static void unZip(string Version, string extractPath, string source)
        {
            string[] types = Version.Split('-');

            extractPath = extractPath + "\\" + source;

            string zipPath = Path.Combine(path, Version);

            ZipFile.ExtractToDirectory(zipPath, extractPath, true);
            if (File.Exists(zipPath))
            {
                File.Delete(zipPath);
            }
        }
    }
}
