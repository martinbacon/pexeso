/*
Copyright (C) 2016  Martin Slanina

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pexeso
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string versionNet;
        public int version = 1;

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                versionNet = new System.Net.WebClient().DownloadString("https://raw.githubusercontent.com/martinbacon/pexeso/master/pexeso/version.ver");
            }
            catch
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (version < Convert.ToInt32(versionNet))
            {
                label1.Text = "Verze: " + version.ToString();
                label2.Text = "Nová verze: " + versionNet.ToString();
                label3.Text = "Je k dispozici nová verze";
                label3.ForeColor = Color.Red;
            }
            else
            {
                label1.Text = "Verze: " + version.ToString();
                label2.Text = "Nová verze: " + versionNet.ToString();
                label3.Text = "Máte nejnovější verzi";
                label3.ForeColor = Color.Green;
            }
            button2.Enabled = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "Verze: " + version.ToString();
        }

    }
}
