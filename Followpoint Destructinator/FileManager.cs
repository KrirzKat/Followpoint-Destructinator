using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Followpoint_Destructinator
{
    static class FileManager
    {
        public static void CreateDirectory(string filepath, string name)
        {
            Directory.CreateDirectory((filepath + name));
        }

        public static void CreateDirectory(string name)
        {
            Directory.CreateDirectory($"..{name}");
        }

        public static void DeleteDirectory(TextBox pathBox)
        {
            if(Directory.Exists(pathBox.Text))
                Directory.Delete(pathBox.Text);
        }

        public static bool CheckDirectoryExistence(TextBox pathBox)
        {
            if (Directory.Exists(pathBox.Text))
                return true;
            return false;
        }

        public static void ChooseFolder(FolderBrowserDialog dialog, TextBox pathBox)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pathBox.Text = dialog.SelectedPath;
            }
        }

        public static void UnpackSkins(string fileName, string packedFile)
        {
            if (!Directory.Exists(fileName))
                Directory.CreateDirectory(@"fileName");

            Stream tream = Stream.Null;
            GZipStream stream = new GZipStream(tream, CompressionLevel.NoCompression);

            stream.Write
        }

        public static void DestroySkin(string fileName)
        {
            Directory.Delete(fileName);
        }

        public static int GetFileCount(string filepath)
        {
            int total = 0;
            foreach (string i in Directory.GetFiles(filepath))
            {
                if (i.Contains("followpoint") && i.Contains(".png"))
                {
                    if (i.Contains("-"))
                    {
                        total++;
                    }
                    else
                        return 0;
                }
            }
            return total;
        }

        public static void ChangeImage(string filepath, bool packed)
        {
            int totalFiles = GetFileCount(filepath);
            if(packed)
            {
                UnpackSkins(filepath);
                GetFileCount(filepath);
            }
            else
            {
                GetFileCount(filepath);
            }
        }
    }
}
