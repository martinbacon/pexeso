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

namespace pexeso
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nováHraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastaveníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.změnitHráčeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.změToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sada1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sada2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highscoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vyhledatAktulizaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nováHraToolStripMenuItem,
            this.nastaveníToolStripMenuItem,
            this.highscoreToolStripMenuItem,
            this.oToolStripMenuItem,
            this.konecToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nováHraToolStripMenuItem
            // 
            this.nováHraToolStripMenuItem.Name = "nováHraToolStripMenuItem";
            this.nováHraToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.nováHraToolStripMenuItem.Text = "Nová hra";
            this.nováHraToolStripMenuItem.Click += new System.EventHandler(this.nováHraToolStripMenuItem_Click);
            // 
            // nastaveníToolStripMenuItem
            // 
            this.nastaveníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.změnitHráčeToolStripMenuItem,
            this.změToolStripMenuItem});
            this.nastaveníToolStripMenuItem.Name = "nastaveníToolStripMenuItem";
            this.nastaveníToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.nastaveníToolStripMenuItem.Text = "Nastavení";
            // 
            // změnitHráčeToolStripMenuItem
            // 
            this.změnitHráčeToolStripMenuItem.Name = "změnitHráčeToolStripMenuItem";
            this.změnitHráčeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.změnitHráčeToolStripMenuItem.Text = "Změnit hráče";
            this.změnitHráčeToolStripMenuItem.Click += new System.EventHandler(this.změnitHráčeToolStripMenuItem_Click);
            // 
            // změToolStripMenuItem
            // 
            this.změToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sada1ToolStripMenuItem,
            this.sada2ToolStripMenuItem});
            this.změToolStripMenuItem.Name = "změToolStripMenuItem";
            this.změToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.změToolStripMenuItem.Text = "Změnit sadu";
            // 
            // sada1ToolStripMenuItem
            // 
            this.sada1ToolStripMenuItem.Checked = true;
            this.sada1ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sada1ToolStripMenuItem.Name = "sada1ToolStripMenuItem";
            this.sada1ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.sada1ToolStripMenuItem.Text = "Sada 1";
            this.sada1ToolStripMenuItem.Click += new System.EventHandler(this.sada1ToolStripMenuItem_Click);
            // 
            // sada2ToolStripMenuItem
            // 
            this.sada2ToolStripMenuItem.Name = "sada2ToolStripMenuItem";
            this.sada2ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.sada2ToolStripMenuItem.Text = "Sada 2";
            this.sada2ToolStripMenuItem.Click += new System.EventHandler(this.sada2ToolStripMenuItem_Click);
            // 
            // highscoreToolStripMenuItem
            // 
            this.highscoreToolStripMenuItem.Name = "highscoreToolStripMenuItem";
            this.highscoreToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.highscoreToolStripMenuItem.Text = "Highscore";
            this.highscoreToolStripMenuItem.Click += new System.EventHandler(this.highscoreToolStripMenuItem_Click);
            // 
            // oToolStripMenuItem
            // 
            this.oToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vyhledatAktulizaceToolStripMenuItem,
            this.toolStripMenuItem2,
            this.oProgramuToolStripMenuItem});
            this.oToolStripMenuItem.Name = "oToolStripMenuItem";
            this.oToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.oToolStripMenuItem.Text = "Nápověda";
            // 
            // vyhledatAktulizaceToolStripMenuItem
            // 
            this.vyhledatAktulizaceToolStripMenuItem.Enabled = false;
            this.vyhledatAktulizaceToolStripMenuItem.Name = "vyhledatAktulizaceToolStripMenuItem";
            this.vyhledatAktulizaceToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.vyhledatAktulizaceToolStripMenuItem.Text = "Vyhledat aktulizace";
            this.vyhledatAktulizaceToolStripMenuItem.Click += new System.EventHandler(this.vyhledatAktulizaceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(172, 6);
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.konecToolStripMenuItem.Text = "Konec";
            this.konecToolStripMenuItem.Click += new System.EventHandler(this.konecToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "Pexeso";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nováHraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastaveníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem změnitHráčeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem změToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sada1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sada2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highscoreToolStripMenuItem;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem oToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vyhledatAktulizaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;




    }
}

