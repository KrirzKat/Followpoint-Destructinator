using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Followpoint_Destructinator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            osuSkin.Title = "Choose the skin you want to change!";
            osuSkin.Filter = "Osu skin file(*.osk)|";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileManager.ChangeImage(FileBox.Text);
            Directory.Delete($"{Directory.GetCurrentDirectory()}/tmp/", true);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FilepathButton_Click(object sender, EventArgs e)
        {
            FileManager.ChooseFile(osuSkin, FileBox);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void unpackedBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
