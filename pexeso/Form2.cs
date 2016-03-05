/*
Pexeso - Simple memory game

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
using System.IO;

namespace pexeso
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public List<string> users=new List<string>();

        private void Form2_Load(object sender, EventArgs e)
        {
            nactiuzivatele();
            CenterToScreen();
        }

        private void nactiuzivatele()
        {
            users.Clear();
            listBox1.DataSource = null;
            FileStream fs = new FileStream("users.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                users.Add(sr.ReadLine());
            }
            sr.Close();
            fs.Close();
            listBox1.DataSource = users;
            if (!users.Any()) 
            { 
                button1.Enabled = false;
                button3.Enabled = false;
            }
            else
            { 
                button1.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("users.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            if (sr.ReadLine()=="")
            {
                sr.Close();
                FileStream fs2 = new FileStream("users.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs2);
                sw.Close();
                fs.Close();
            }
            fs.Close();
            nactiuzivatele();

            Form3 f3 = new Form3();
            f3.ShowDialog();
            nactiuzivatele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = Application.OpenForms[0] as Form1;
            f1.user = listBox1.SelectedItem.ToString();
            f1.label1.Text = f1.user;
            this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (users.Count>1)
                {
                    users.RemoveAt(listBox1.SelectedIndex);
                FileStream fs = new FileStream("users.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(string.Join("\n", users.ToArray()) + "\n");
                sw.Close();
                fs.Close();
                nactiuzivatele();
                }
                else
                {
                    users.Clear();
                    FileStream fs = new FileStream("users.txt", FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write("");
                    sw.Close();
                    fs.Close();
                    nactiuzivatele();
                }
            }
            catch 
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("Není vybráno");
            }
        }
    }
}
