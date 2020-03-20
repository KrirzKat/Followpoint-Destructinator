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

        public static void DeleteDirectory(string dirPath)
        {

        }

        public static void CheckDirectoryExistence(string dirPath)
        {
            
        }

        public static void ChooseFolder(FolderBrowserDialog dialog, TextBox pathBox)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pathBox.Text = dialog.SelectedPath;
            }
        }
    }
}
