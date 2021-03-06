﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAVinfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            if (System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1) System.Diagnostics.Process.GetCurrentProcess().Kill();
            InitializeComponent();
            this.Hide();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hovedmeny hmeny = new Hovedmeny();
            hmeny.Show();
            hmeny.Activate();
        }

        private void opplæringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://navno.sharepoint.com/sites/Office365Hjelp");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            // laster passord.nav.no i eget browser vindu
            byttpassord passordbytte = new byttpassord();
            passordbytte.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // åpner hovedmenyen ved dobbeltklikk på tray-iconet
            Hovedmeny hmeny = new Hovedmeny();
            hmeny.Show();
            hmeny.Activate();
        }
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            //åpner hovedmenyen ved left-klikk på tray-iconet
            if (e.Button == MouseButtons.Left)
            {
                
                Hovedmeny hmeny = new Hovedmeny();
                hmeny.Show();
                hmeny.Activate();
            }

        }

        private void applikasjonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"softwarecenter:");
        }
    }
}
