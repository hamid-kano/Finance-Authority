﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_Authority
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        public static int Category_id;
        public static int Exchange_Order_id;
        public static int Authority_ID;
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MAIN_FORM());
        }
    }
}
