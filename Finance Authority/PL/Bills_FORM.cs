using System;
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
    public partial class Bills_FORM : MetroFramework.Forms.MetroForm 
    { BL.CLS_Bills bill = new BL.CLS_Bills();
        public Bills_FORM()
        {
            InitializeComponent();
            Bills_dataGrid.DataSource = bill.Bills_View();
        }

        private void Bills_dataGrid_Click(object sender, EventArgs e)
        {
            if(Bills_dataGrid.CurrentRow!=null)
            {
                Bills_Details.Enabled = true;
                Bills_delete.Enabled = true;

            }
        }

        private void Bills_add_Click(object sender, EventArgs e)
        {
            PL.Bills_Details_FORM FRM = new Bills_Details_FORM(-1);
            FRM.ShowDialog();
        }

        private void Bills_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bills_Details_Click(object sender, EventArgs e)
        {
            if (Bills_dataGrid.CurrentRow != null)
            {
                int Bill_Id =Convert.ToInt32(Bills_dataGrid.CurrentRow.Cells[0].Value);
                Program.Bill_id = Bill_Id;
                PL.Bills_Details_FORM FRM = new Bills_Details_FORM(Bill_Id);
                FRM.ShowDialog();
            }
        }

          
    }
}
