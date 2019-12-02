using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Finance_Authority
{
    public partial class MAIN_FORM :MetroForm
    {
        public MAIN_FORM()
        {
            InitializeComponent();
        }

        private void EX_Orders_Cat_BTN_Click(object sender, EventArgs e)
        {
            PL.EX_Orders_Cat_FORM FRM = new PL.EX_Orders_Cat_FORM();
            FRM.ShowDialog();
        }

        private void EX_Order_BTN_Click(object sender, EventArgs e)
        {
            PL.EX_Order_FORM FRM = new PL.EX_Order_FORM();
            FRM.ShowDialog();
        }

        private void Authority_BTN_Click(object sender, EventArgs e)
        {
            PL.Authority_FORM FRM = new PL.Authority_FORM();
            FRM.ShowDialog();
        }

        private void Office_BTN_Click(object sender, EventArgs e)
        {
            PL.Office_FORM FRM = new PL.Office_FORM();
            FRM.ShowDialog();
        }

        private void Department_BTN_Click(object sender, EventArgs e)
        {
            PL.Department_FORM FRM = new PL.Department_FORM();
            FRM.ShowDialog();
        }

        private void Employee_BTN_Click(object sender, EventArgs e)
        {
            PL.Employee_FORM FRM = new PL.Employee_FORM();
            FRM.ShowDialog();
        }

        private void Role_Functional_BTN_Click(object sender, EventArgs e)
        {
            PL.Role_Functional_FORM FRM = new PL.Role_Functional_FORM();
            FRM.ShowDialog();
        }

        private void Emission_Salaries_BTN_Click(object sender, EventArgs e)
        {
            PL.Emission_Salaries_FORM FRM = new PL.Emission_Salaries_FORM();
            FRM.ShowDialog();
        }

        private void Employee_Salaries_BTN_Click(object sender, EventArgs e)
        {
            PL.Employee_Salaries_FORM FRM = new PL.Employee_Salaries_FORM();
            FRM.ShowDialog();
        }

        private void Employee_Description_BTN_Click(object sender, EventArgs e)
        {
            PL.Employee_Description_FORM FRM = new PL.Employee_Description_FORM();
            FRM.ShowDialog();
        }

        private void Contracts_BTN_Click(object sender, EventArgs e)
        {
            PL.Contracts_FORM FRM = new PL.Contracts_FORM();
            FRM.ShowDialog();
        }

        private void Loans_BTN_Click(object sender, EventArgs e)
        {
            PL.Loans_FORM FRM = new PL.Loans_FORM();
            FRM.ShowDialog();
        }

        private void Leoan_Payments_BTN_Click(object sender, EventArgs e)
        {
            PL.Leoan_Payments_FORM FRM = new PL.Leoan_Payments_FORM();
            FRM.ShowDialog();
        }

        private void Budget_FORM_Click(object sender, EventArgs e)
        {
            PL.Budget_FORM FRM = new PL.Budget_FORM();
            FRM.ShowDialog();
        }

        private void Coin_Exchange_BTN_Click(object sender, EventArgs e)
        {
            PL.Coin_Exchange_FORM FRM = new PL.Coin_Exchange_FORM();
            FRM.ShowDialog();
        }

        private void Payment_Document_BTN_Click(object sender, EventArgs e)
        {
            PL.Payment_Document_FORM FRM = new PL.Payment_Document_FORM();
            FRM.ShowDialog();
        }

        private void Reciver_Document_BTN_Click(object sender, EventArgs e)
        {
            PL.Reciver_Document_FORM FRM = new PL.Reciver_Document_FORM();
            FRM.ShowDialog();
        }

        private void Document_Category_BTN_Click(object sender, EventArgs e)
        {
            PL.Document_Category_FORM FRM = new PL.Document_Category_FORM();
            FRM.ShowDialog();
        }

        private void Document_BTN_Click(object sender, EventArgs e)
        {
            PL.Document_FORM FRM = new PL.Document_FORM();
            FRM.ShowDialog();
        }

        private void Backup_Button_Click(object sender, EventArgs e)
        {
            PL.Backup_FORM FRM = new PL.Backup_FORM();
            FRM.ShowDialog();
        }

        private void Objects_Button_Click(object sender, EventArgs e)
        {
            PL.Objects_FORM FRM = new PL.Objects_FORM();
            FRM.ShowDialog();
        }

        private void Bills_Button_Click(object sender, EventArgs e)
        {
            PL.Bills_FORM FRM = new PL.Bills_FORM();
            FRM.ShowDialog();
        }
    }
}
