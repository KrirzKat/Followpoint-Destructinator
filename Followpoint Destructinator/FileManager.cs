using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using System.Diagnostics;

namespace Followpoint_Destructinator
{
    static class FileManager
    {
        //
        public static void CreateDirectory(string filepath, string name)
        {
            if(!Directory.Exists(filepath + name))
                Directory.CreateDirectory((filepath + name));   
        }

        public static void CreateDirectory(string name)
        {
            if(!Directory.Exists(name))
                Directory.CreateDirectory(name);
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

        public static void ChooseFile(OpenFileDialog dialog, TextBox pathBox)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pathBox.Text = dialog.FileName;
            }
        }

        public static void UnpackSkins(string packedFile)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo($@"{Directory.GetCurrentDirectory()}/Dependencies/OSKUnpacker.exe");
            startInfo.CreateNoWindow = false;
            startInfo.Arguments = packedFile;

            Process unpacker = new Process();
            unpacker.StartInfo = startInfo;
            
            unpacker.Start();

            while(!unpacker.HasExited)
            {

            }
        }

        public static void PackSkins(string file)
        {

        }

        public static void DestroySkin(string fileName)
        {
            Directory.Delete(fileName);
        }

        /*public static int GetFileCount(string filepath)
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
        }*/

        public static void ChangeImage(TextBox box, bool packed)
        {
            if(!packed)
            {
                UnpackSkins(box.Text);
            }
            else
            {
                
            }
        }
    }
}
