﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTier101_Live.PL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser frmUser = new frmUser();

            frmUser.Text = "Kullanıcı Bilgileri";

            frmUser.ShowDialog();
        }
    }
}
