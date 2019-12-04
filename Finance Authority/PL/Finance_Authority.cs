using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Finance_Authority.PL
{
    public partial class Finance_Authority : MetroFramework.Forms.MetroForm
    {
        public Finance_Authority()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void MetroTabPage1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void Management_Loan_Click(object sender, EventArgs e)
        {
            //PL.Loans_FORM frm = new PL.Loans_FORM();
            //frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            //AbrirFormInPanel(frm,this.Panel_Loan_MANAG);
        }
        private void MetroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroStyleManager1.Theme == MetroFramework.MetroThemeStyle.Light)
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                Program.theme = 0;
            }
            else
            { 
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                Program.theme = 1;

            }
        }

        private void MetroTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            switch (metroTrackBar1.Value)
            {
                case 0:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
                    Program.style = 0;
                    break;
                case 1:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
                    Program.style = 1;
                    break;
                case 2:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Pink;
                    Program.style = 2;
                    break;
                case 3:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Magenta;
                    Program.style = 3;
                    break;
                case 4:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple;
                    Program.style = 4;
                    break;
                case 5:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Yellow;
                    Program.style = 5;
                    break;
                default:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
                    break;
            }
        }

    }
}
