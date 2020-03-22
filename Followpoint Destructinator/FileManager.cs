using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Followpoint_Destructinator
{
    static class FileManager
    {
        //
        public static void CreateDirectory(string filepath, string name)
        {
            if (!Directory.Exists(filepath + name))
                Directory.CreateDirectory((filepath + name));
        }

        public static void CreateDirectory(string name)
        {
            if (!Directory.Exists(name))
                Directory.CreateDirectory(name);
        }

        public static void DeleteDirectory(TextBox pathBox)
        {
            if (Directory.Exists(pathBox.Text))
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
                pathBox.Text = dialog.FileName;
        }

        public static string ChooseDirectory(FolderBrowserDialog dialog, TextBox pathBox)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
                return dialog.SelectedPath;
            else
                return null;
        }

        public static void UnpackSkins(string packedFile)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo($@"{Directory.GetCurrentDirectory()}/Dependencies/OSKUnpacker.exe");
            startInfo.CreateNoWindow = true;
            startInfo.Arguments = packedFile;

            Process unpacker = new Process();
            unpacker.StartInfo = startInfo;

            unpacker.Start();

            while (!unpacker.HasExited)
            {

            }
        }

        public static void PackSkins(string packedFile, string dir)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo($@"{Directory.GetCurrentDirectory()}/Dependencies/OSKPacker.exe");
            startInfo.CreateNoWindow = true;
            startInfo.Arguments = packedFile;

            Process packer = new Process();
            packer.StartInfo = startInfo;

            packer.Start();

            while (!packer.HasExited)
            {

            }

            if (dir != null)
            {
                int i = 0;
                if (File.Exists($"{dir}/followpoint-0,png"))
                {
                    File.Copy($"{dir}/followpoint.png", $"{Directory.GetCurrentDirectory()}/tmp/followpoint.png");
                    while (File.Exists($"{dir}/followpoint-{i + 1}.png"))
                    {
                        File.Copy($"{dir}/followpoint-{i}.png", $"{Directory.GetCurrentDirectory()}/tmp/followpoint-{i}.png");
                    }
                }
            }
        }

        public static void DestroySkin(string fileName)
        {
            Directory.Delete(fileName);
        }

        public static void ChangeImage(string path, string dir = null)
        {
            UnpackSkins(path);
            PackSkins(path, dir);
        }
    }
}
