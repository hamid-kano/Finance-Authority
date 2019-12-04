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
        public static int Reciver_Document_id;
        public static int Payment_Document_id;
        public static int Employee_id;
        public static int Employee_Description_id;
        public static int Contracts_id;
        /// </summary>
        /// 
        public static int theme;
        public static int style;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MAIN_FORM());
        }


        public static MetroFramework.Components.MetroStyleManager theme_style(MetroFramework.Forms.MetroForm frm)
        {
            MetroFramework.Components.MetroStyleManager metroStyleManager = new MetroFramework.Components.MetroStyleManager();
            metroStyleManager.Owner = frm;
            if (theme==0)
                metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            else
                metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
           
            //// style

            switch (style)
            {
                case 0:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Red;
                    break;
                case 1:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Orange;
                    break;
                case 2:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Pink;
                    break;
                case 3:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Magenta;
                    break;
                case 4:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Purple;
                    break;
                case 5:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Yellow;
                    break;
                default:
                    metroStyleManager.Style = MetroFramework.MetroColorStyle.Brown;
                    break;
            }

            return metroStyleManager;

        }


    }
}
