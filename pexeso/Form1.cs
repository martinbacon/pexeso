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
using System.Diagnostics;

namespace pexeso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 6; i++)
            {
                
                for (int j = 0; j < 6; j++)
                {
                   polepictureboxu[i, j] = new PictureBox();
                   polepictureboxu[i, j].Size = new Size(80, 80);
                   polepictureboxu[i, j].Text = i.ToString();
                   polepictureboxu[i, j].Top = i * 90 + 50;
                   polepictureboxu[i, j].Left = j * 90 + 50;
                   polepictureboxu[i, j].Click += new EventHandler(this.pictureBox1_Click);
                   polepictureboxu[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                   polepictureboxu[i, j].Image = global::pexeso.Properties.Resources.karta_rub;

                   this.Controls.Add(polepictureboxu[i, j]);

                }
            }
            int k=0;
            foreach (PictureBox c in polepictureboxu)
            {

                c.Tag = k;
                k++;
            }
            //
            nacticesty();
            Shuffle(poleimage);
        }

        private void nacticesty()
        {
            if (sada1ToolStripMenuItem.Checked)
            {
                int l = 0;
                for (int i = 0; i < 18; i++)
                {
                    poleimage[i] = "sada0/o" + l.ToString() + ".jpg";
                    l++;
                }

                int m = 0;
                for (int i = 18; i < 36; i++)
                {
                    poleimage[i] = "sada0/o" + m.ToString() + ".jpg";
                    m++;
                }
            }
            if (sada2ToolStripMenuItem.Checked)
            {
                int l = 0;
                for (int i = 0; i < 18; i++)
                {
                    poleimage[i] = "sada1/o" + l.ToString() + ".jpg";
                    l++;
                }

                int m = 0;
                for (int i = 18; i < 36; i++)
                {
                    poleimage[i] = "sada1/o" + m.ToString() + ".jpg";
                    m++;
                }
            }
        }
        PictureBox[,] polepictureboxu = new PictureBox[6,6];
        string[] poleimage=new string[36];
        int n = 0;
        string n1;
        string n2;
        int tag1 = 0;
        int tag2 = 0;
        int pocet = 36;
        public string user;
        static Random kostka = new Random();
        Form2 f2 = new Form2();
        Form4 f4 = new Form4();
        Stopwatch stopky = new Stopwatch();
        List<string> highscore = new List<string>();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox send = (PictureBox)sender;
            send.Image = Image.FromFile(poleimage[Convert.ToInt32(send.Tag)]);
            send.Enabled = false;
            n++;
            if (n == 1) { n1 = poleimage[Convert.ToInt32(send.Tag)]; tag1=Convert.ToInt32(send.Tag);}
            if (n == 2) { n2 = poleimage[Convert.ToInt32(send.Tag)]; tag2=Convert.ToInt32(send.Tag);}

            if (n == 2 && n1 == n2) 
            {
                n = 0;
                n1 = "";
                n2 = "";
                foreach (PictureBox c in polepictureboxu)
                {
                    if (Convert.ToInt32(c.Tag)==tag1){ c.Visible = false;}
                    if (Convert.ToInt32(c.Tag)==tag2) { c.Visible = false; }
                }
                pocet -= 2;
                System.Media.SystemSounds.Hand.Play();
            }
            if (n == 2 && n1 != n2) 
            {
                foreach (PictureBox c in polepictureboxu)
                {
                    c.Enabled = false;
                }
                backgroundWorker1.RunWorkerAsync();
            }
            if (pocet == 0)
            {
                stopky.Stop();
                FileStream fs = new FileStream("highscore.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(user + " - " + label2.Text);
                MessageBox.Show("Výhra" + "\n" + user + " - " + label2.Text);
                sw.Close();
                fs.Close();
                reset();
            }

        }

        //
        public static void Shuffle<T>(T[] array)
        {
            for (int i = array.Length; i > 1; i--)
            {
                // Pick random element to swap.
                int j = kostka.Next(i); // 0 <= j <= i-1
                // Swap.
                T tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
            }
        }

        private void sada2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sada1ToolStripMenuItem.Checked = false;
            sada2ToolStripMenuItem.Checked = true;
            nacticesty();
            reset();
        }

        private void sada1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sada2ToolStripMenuItem.Checked = false;
            sada1ToolStripMenuItem.Checked = true;
            nacticesty();
            reset();
        }

        private void reset()
        {
            foreach (PictureBox c in polepictureboxu)
            {
                c.Image = Image.FromFile("karta-rub.gif");
                c.Visible = true;
            }
            n = 0;
            n1 = "";
            n2 = "";
            tag1 = 0;
            tag2 = 0;
            pocet = 36;
            stopky.Restart();
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nováHraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void změnitHráčeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            f2.ShowDialog();
            timer1.Start();
            stopky.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = stopky.Elapsed;
            label2.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds / 10);
        }

        private void highscoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            highscore.Clear();
            FileStream fs = new FileStream("highscore.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                highscore.Add(sr.ReadLine());
            }
            sr.Close();
            fs.Close();
            if (highscore.Any())
            {
                MessageBox.Show(string.Join("\n", highscore.ToArray()));
            }
            else
            {
                MessageBox.Show("Žádná data");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            n = 0;
            n1 = "";
            n2 = "";
            foreach (PictureBox c in polepictureboxu)
            {
                c.Image = Image.FromFile("karta-rub.gif");
                c.Enabled = true;
            }
        }

        private void vyhledatAktulizaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.ShowDialog();
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vytvořil Martin Slanina v roce 2014\nVerze: " + f4.version);
        }

    }
}
