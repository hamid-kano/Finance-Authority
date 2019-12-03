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
    public partial class Payment_Document_FORM : MetroFramework.Forms.MetroForm
    {
        public Payment_Document_FORM()
        {
            InitializeComponent();
        }

        private void Payment_Document_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Payment_Document_new_Click(object sender, EventArgs e)
        {
            Payment_Document_add.Enabled = true;
            Payment_Document_sy.Text = "";
            Payment_Document_Dollar.Text = "";
            Payment_Document_rate.Text = "";
            Payment_Document_no.Text = "";
            Payment_Document_No_Order.Text = "";
            Payment_Document_Reason.Text = "";
            Payment_Document_Receve.Text = "";
            Payment_Document_Notes.Text = "";
            Payment_Document_update.Enabled = false;
            Payment_Document_delete.Enabled = false;
        }

        private void Payment_Document_dataGrid_Click(object sender, EventArgs e)
        {
            if (Payment_Document_dataGrid.CurrentRow != null)
            {
                Program.Payment_Document_id = Convert.ToInt32(this.Payment_Document_dataGrid.CurrentRow.Cells[0].Value.ToString());
                Payment_Document_sy.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[1].Value.ToString();
                Payment_Document_Dollar.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[2].Value.ToString();
                Payment_Document_rate.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[3].Value.ToString();
                Payment_Document_no.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[4].Value.ToString();
                Payment_Document_No_Order.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[5].Value.ToString();
                Payment_Document_Reason.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[6].Value.ToString();
                Payment_Document_Receve.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[7].Value.ToString();
                Payment_Document_DateTime.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[8].Value.ToString();
                Payment_Document_Notes.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[9].Value.ToString();
                Payment_Document_Comb_Date.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[10].Value.ToString();
                Payment_Document_Comb_Cate.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[11].Value.ToString();
                Payment_Document_update.Enabled = true;
                Payment_Document_delete.Enabled = true;
            }
        }
    }
}
