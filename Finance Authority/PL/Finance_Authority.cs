﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_Authority.PL
{
    public partial class Finance_Authority : MetroFramework.Forms.MetroForm
    {
        public Finance_Authority()
        {
            InitializeComponent();
        }

        private void MetroTabPage1_Scroll(object sender, ScrollEventArgs e)
        {
            metroTile1.Text = "hamid";
        }
    }
}
