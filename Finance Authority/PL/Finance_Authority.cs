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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //int LX, LY, SW, SH;
        private void AbrirFormInPanel(object formHijo,MetroFramework.Controls.MetroPanel panel)
        {
            if (panel.Controls.Count > 0)
                panel.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            panel.Controls.Add(fh);
            panel.Tag = fh;
            fh.Show();
        }
        private void mostrarlogo()
        {
            AbrirFormInPanel(new PL.Disply_FORM(), null);
        }
        private void mostrarlogoAlCerrarForm(object sender, FormClosedEventArgs e)
        {
            mostrarlogo();
        }

        protected override void WndProc(ref Message msj)
        {
            const int CoordenadaWFP = 0x84; //ibicacion de la parte derecha inferior del form
            const int DesIzquierda = 16;
            const int DesDerecha = 17;
            if (msj.Msg == CoordenadaWFP)
            {
                int x = (int)(msj.LParam.ToInt64() & 0xFFFF);
                int y = (int)((msj.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point CoordenadaArea = PointToClient(new Point(x, y));
                Size TamañoAreaForm = ClientSize;
                if (CoordenadaArea.X >= TamañoAreaForm.Width - 16 && CoordenadaArea.Y >= TamañoAreaForm.Height - 16 && TamañoAreaForm.Height >= 16)
                {
                    msj.Result = (IntPtr)(IsMirrored ? DesIzquierda : DesDerecha);
                    return;
                }
            }
            base.WndProc(ref msj);
        }




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
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            else
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private void MetroTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            switch (metroTrackBar1.Value)
            {
                case 0:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
                    break;
                case 1:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
                    break;
                case 2:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Pink;
                    break;
                case 3:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Magenta;
                    break;
                case 4:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple;
                    break;
                case 5:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Yellow;
                    break;
                default:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Brown;
                    break;
            }
        }

    }
}
