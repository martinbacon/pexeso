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
using System.IO;

namespace pexeso
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("users.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(textBox1.Text);
            sw.Close();
            fs.Close();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Form2 f2 = Application.OpenForms[1] as Form2;
            if (f2.users.Contains(textBox1.Text)||textBox1.Text.Length<1)
            {
                textBox1.BackColor = Color.Red;
                button1.Enabled = false;
            }
            else
            {
                textBox1.BackColor = Color.Green;
                button1.Enabled = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            if (textBox1.Text.Length < 1)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }
    }
}
