﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Followpoint_Destructinator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            folderBrowserDialog1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            FileManager.ChooseFolder(folderBrowserDialog1, textBox1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
