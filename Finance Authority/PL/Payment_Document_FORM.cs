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
        BL.CLS_Coin_Exchange Coin = new BL.CLS_Coin_Exchange();
        BL.CLS_Reciver_Document Reciv = new BL.CLS_Reciver_Document();
        BL.CLS_Payment_Document pay = new BL.CLS_Payment_Document();
        public Payment_Document_FORM()
        {
            InitializeComponent();
            this.Payment_Document_dataGrid.DataSource = pay.Payment_Document_View();
            this.Payment_Document_dataGrid.Columns[0].Visible = false;
            Payment_Document_Comb_Date.DataSource = Coin.Coin_Exchange_CombBudg();
            Payment_Document_Comb_Date.DisplayMember = "Date";
            Payment_Document_Comb_Date.ValueMember = "Budget_Id";
            Payment_Document_Comb_Cate.DataSource = Reciv.Reciver_Document_Comb_Cate();
            Payment_Document_Comb_Cate.DisplayMember = "Document_Type";
            Payment_Document_Comb_Cate.ValueMember = "Category_id";
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

        private void Payment_Document_add_Click(object sender, EventArgs e)
        {
            pay.Payment_Document_add(Payment_Document_sy.Text, Payment_Document_Dollar.Text, Payment_Document_rate.Text,
                Payment_Document_no.Text , Payment_Document_No_Order.Text, Payment_Document_Reason.Text ,
                Payment_Document_Receve.Text, Payment_Document_DateTime.Value, Payment_Document_Notes.Text ,
                Convert.ToInt32(Payment_Document_Comb_Date.SelectedValue), Convert.ToInt32( Payment_Document_Comb_Cate.SelectedValue));
            this.Payment_Document_dataGrid.DataSource = pay.Payment_Document_View();
            this.Payment_Document_dataGrid.Columns[0].Visible = false;
            Program.Add_Message();
            Payment_Document_sy.Text = "";
            Payment_Document_Dollar.Text = "";
            Payment_Document_rate.Text = "";
            Payment_Document_no.Text = "";
            Payment_Document_No_Order.Text = "";
            Payment_Document_Reason.Text = "";
            Payment_Document_Receve.Text = "";
            Payment_Document_Notes.Text = "";
            Payment_Document_add.Enabled = false;
        }

        private void Payment_Document_update_Click(object sender, EventArgs e)
        {
            pay.Payment_Document_update(Payment_Document_sy.Text, Payment_Document_Dollar.Text, Payment_Document_rate.Text,
               Payment_Document_no.Text, Payment_Document_No_Order.Text, Payment_Document_Reason.Text,
               Payment_Document_Receve.Text, Payment_Document_DateTime.Value, Payment_Document_Notes.Text,
               Convert.ToInt32(Payment_Document_Comb_Date.SelectedValue), Convert.ToInt32(Payment_Document_Comb_Cate.SelectedValue) , Program.Payment_Document_id);
            this.Payment_Document_dataGrid.DataSource = pay.Payment_Document_View();
            this.Payment_Document_dataGrid.Columns[0].Visible = false;
            Program.Update_Message();
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

        private void Payment_Document_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف؟؟  ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pay.Payment_Document_Delete(Program.Payment_Document_id);
                this.Payment_Document_dataGrid.DataSource = pay.Payment_Document_View();
                this.Payment_Document_dataGrid.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void Payment_Document_Search_TextChanged(object sender, EventArgs e)
        {
            this.Payment_Document_dataGrid.DataSource = pay.Payment_Document_Search(Payment_Document_Search.Text);
            this.Payment_Document_dataGrid.Columns[0].Visible = false;
        }

        private void Payment_Document_Date_first_ValueChanged(object sender, EventArgs e)
        {
            this.Payment_Document_dataGrid.DataSource = pay.Payment_Document_Date_between(Payment_Document_Date_first.Value , Payment_Document_Date_last.Value);
            this.Payment_Document_dataGrid.Columns[0].Visible = false;
        }

        private void Payment_Document_Date_last_ValueChanged(object sender, EventArgs e)
        {
            this.Payment_Document_dataGrid.DataSource = pay.Payment_Document_Date_between(Payment_Document_Date_first.Value, Payment_Document_Date_last.Value);
            this.Payment_Document_dataGrid.Columns[0].Visible = false;
        }
    }
}
