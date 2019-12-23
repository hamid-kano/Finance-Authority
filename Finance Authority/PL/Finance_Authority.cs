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
            Update_label_finance_Box();
            Month_imports_ProgressSpinner.Value =  Program.Month_Imports_rate() > 100 ? 100 : Program.Month_Imports_rate();
            Month_imports_Label.Text = Program.Month_Imports_rate() > 100? "%"+ Program.Month_Imports_rate(): "%" + Program.Month_Imports_rate();
            Month_export_ProgressSpinner.Value =  Program.Month_Exmports_rate() > 100? 100: Program.Month_Exmports_rate();
            Month_exmports_Label.Text = Program.Month_Exmports_rate() > 100 ? "%" + Program.Month_Exmports_rate() : "%" + Program.Month_Exmports_rate();
        }

        private static Finance_Authority frm;

        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static Finance_Authority getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Finance_Authority();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
                }
                return frm;
            }
        }
        private void MetroTabPage1_Scroll(object sender, ScrollEventArgs e)
        {

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
                case 6:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.White;
                    Program.style = 6;
                    break;
                case 7:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
                    Program.style = 7;
                    break;
                case 8:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Teal;
                    Program.style = 8;
                    break;
                case 9:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
                    Program.style = 9;
                    break;
                case 10:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
                    Program.style = 10;
                    break;
                case 11:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Brown;
                    Program.style = 11;
                    break;
                case 12:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Lime;
                    Program.style = 12;
                    break;
                case 13:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Silver;
                    Program.style = 13;
                    break;
                case 14:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
                    Program.style = 14;
                    break;
                
            }
        }
        private void Authority_Button_Click(object sender, EventArgs e)
        {
            Authority_FORM FRM = new Authority_FORM();
            FRM.ShowDialog();
        }

        private void Office_Button_Click(object sender, EventArgs e)
        {
            Office_FORM FRM = new Office_FORM();
            FRM.ShowDialog();
        }

        private void Department_Button_Click(object sender, EventArgs e)
        {
            Department_FORM FRM = new Department_FORM();
            FRM.ShowDialog();
        }

        private void Budget_Button_Click(object sender, EventArgs e)
        {
            Budget_FORM FRM = new Budget_FORM();
            FRM.ShowDialog();
        }

        private void Coin_Exchange_Button_Click(object sender, EventArgs e)
        {
            Coin_Exchange_FORM FRM = new Coin_Exchange_FORM();
            FRM.ShowDialog();
        }

        private void EX_Orders_Cat_Button_Click(object sender, EventArgs e)
        {
            EX_Orders_Cat_FORM FRM = new EX_Orders_Cat_FORM();
            FRM.ShowDialog();
        }

        private void EX_Order_Button_Click(object sender, EventArgs e)
        {
            EX_Order_FORM FRM = new EX_Order_FORM();
            FRM.ShowDialog();
        }

        private void Emission_Salaries_Button_Click(object sender, EventArgs e)
        {
            Emission_Salaries_FORM FRM = new Emission_Salaries_FORM();
            FRM.ShowDialog();
        }

        private void Loans_Button_Click(object sender, EventArgs e)
        {
            Loans_FORM FRM = new Loans_FORM();
            FRM.ShowDialog();
        }

        private void Leoan_Payments_Button_Click(object sender, EventArgs e)
        {
            Leoan_Payments_FORM FRM = new Leoan_Payments_FORM();
            FRM.ShowDialog();
        }

        private void Backup_Button_Click(object sender, EventArgs e)
        {
            Backup_FORM FRM = new Backup_FORM();
            FRM.ShowDialog();
        }

        private void Backup_Restor_Button_Click(object sender, EventArgs e)
        {
            Backup_Restor_FORM FRM = new Backup_Restor_FORM();
            FRM.ShowDialog();
        }

        private void Employee_Button_Click(object sender, EventArgs e)
        {
            Employee_FORM FRM = new Employee_FORM(-1);
            FRM.ShowDialog();
        }

        private void Employee_Description_Button_Click(object sender, EventArgs e)
        {
            Employee_Description_FORM FRM = new Employee_Description_FORM();
            FRM.ShowDialog();
        }

        private void Role_Functional_Button_Click(object sender, EventArgs e)
        {
            Role_Functional_FORM FRM = new Role_Functional_FORM();
            FRM.ShowDialog();
        }

        private void Contracts_Button_Click(object sender, EventArgs e)
        {
            Contracts_FORM FRM = new Contracts_FORM();
            FRM.ShowDialog();
        }

        private void Document_Button_Click(object sender, EventArgs e)
        {
            Document_FORM FRM = new Document_FORM(-1,"");
            FRM.ShowDialog();
        }

        private void Document_Category_Button_Click(object sender, EventArgs e)
        {
            Document_Category_FORM FRM = new Document_Category_FORM();
            FRM.ShowDialog();
        }

        private void Payment_Document_Button_Click(object sender, EventArgs e)
        {
            Payment_Document_FORM FRM = new Payment_Document_FORM();
            FRM.ShowDialog();
            Update_label_finance_Box();
        }

        private void Reciver_Document_Button_Click(object sender, EventArgs e)
        {
            Reciver_Document_FORM FRM = new Reciver_Document_FORM();
            FRM.ShowDialog();
        }

        private void Employee_Salaries_Button_Click(object sender, EventArgs e)
        {
            Employee_Salaries_FORM FRM = new Employee_Salaries_FORM();
            FRM.ShowDialog();
        }

        private void Payment_Document_Button_MAIN_Click(object sender, EventArgs e)
        {
            Payment_Document_FORM FRM = new Payment_Document_FORM();
            FRM.ShowDialog();
        }

        private void Reciver_Document_Button_MAIN_Click(object sender, EventArgs e)
        {
            Reciver_Document_FORM FRM = new Reciver_Document_FORM();
            FRM.ShowDialog();
        }

        private void Employee_Button_MAIN_Click(object sender, EventArgs e)
        {
            Employee_FORM FRM = new Employee_FORM(-1);
            FRM.ShowDialog();
        }

        private void Bill_Button_MAIN_Click(object sender, EventArgs e)
        {
            Bills_FORM FRM = new Bills_FORM();
            FRM.ShowDialog();
            Update_label_finance_Box();
        }

        private void Coin_Exchange_Button_MAIN_Click(object sender, EventArgs e)
        {
            Coin_Exchange_FORM FRM = new Coin_Exchange_FORM();
            FRM.ShowDialog();
        }

        public void Update_label_finance_Box()
        {
            if (Program.Budget_NOW()!=null)
            {
                DataRow dt = Program.Budget_NOW();
                this.SY_Now_Label.Text = dt[1].ToString();
                this.Dollar_Now_Label.Text = dt[2].ToString();
            }
            else
            {
                this.SY_Now_Label.Text = "";
                this.Dollar_Now_Label.Text = "";
            }
        }

        private void metroTile32_Click(object sender, EventArgs e)
        {
            Update_label_finance_Box();
        }

        private void Budget_Now_Click(object sender, EventArgs e)
        {
            Budget_Now_FORM FRM = new Budget_Now_FORM();
            FRM.ShowDialog();
        }

        private void Finance_Authority_Load(object sender, EventArgs e)
        {

        }
    }
}
