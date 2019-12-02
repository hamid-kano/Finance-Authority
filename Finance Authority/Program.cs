using System;
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
        public static int Office_ID;
        public static int Department_ID;
        public static int Role_Functional_id;
        public static int  Budget_Id;
        public static int Coin_Exchange_id;
        public static int Category_id_id;
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
