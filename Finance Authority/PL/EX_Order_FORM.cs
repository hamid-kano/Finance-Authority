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
    public partial class EX_Order_FORM : MetroFramework.Forms.MetroForm
    { BL.CLS_Exchange_Order order = new BL.CLS_Exchange_Order();
        CLS_Exchange_Orders_Category cat = new CLS_Exchange_Orders_Category();
        public EX_Order_FORM()
        {
            InitializeComponent();
            this.EX_Orders_dataGrid.DataSource = order.Exchange_Order_view();
            EX_Orders_CombCategorise.DataSource = order.EX_Orders_CombCategorise();
            EX_Orders_CombCategorise.DisplayMember = "Exchange_Order_Type";
            EX_Orders_CombCategorise.ValueMember = "Category_id";
            this.EX_Orders_dataGrid.Columns[0].Visible = false;
        }

        
        private void EX_Orders_add_Click(object sender, EventArgs e)
        {
            if (EX_Orders_order.Text == String.Empty)
            {

                MessageBox.Show("أضف رقم الطلب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable Dt = new DataTable();
            Dt = order.Exchange_Order_Cheack(EX_Orders_order.Text);
            if (Dt.Rows.Count == 0)
            {
                order.Exchange_Order_add(EX_Orders_order.Text, EX_Orders_DateTime.Value, EX_Orders_tosorce.Text, EX_Orders_Body_order.Text, EX_Orders_Notes.Text, Convert.ToInt32(EX_Orders_CombCategorise.SelectedValue));
                MessageBox.Show("تم الأضافة", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.EX_Orders_dataGrid.DataSource = order.Exchange_Order_view();
                this.EX_Orders_dataGrid.Columns[0].Visible = false;
                EX_Orders_order.Text = "";
                EX_Orders_tosorce.Text = "";
                EX_Orders_Body_order.Text = "";
                EX_Orders_Notes.Text = "";
                EX_Orders_CombCategorise.Text = "";
                EX_Orders_add.Enabled = false;
            }
            else
            {
                MessageBox.Show("موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
                return;
            }
            
        }

        private void EX_Orders_new_Click(object sender, EventArgs e)
        {
            EX_Orders_add.Enabled = true;
            EX_Orders_order.Text = "";
            EX_Orders_tosorce.Text = "";
            EX_Orders_Body_order.Text = "";
            EX_Orders_Notes.Text = "";
            
        }

        private void EX_Orders_dataGrid_Click(object sender, EventArgs e)
        {
            if (EX_Orders_dataGrid.CurrentRow != null)
            {
                Program.Exchange_Order_id = Convert.ToInt32(this.EX_Orders_dataGrid.CurrentRow.Cells[0].Value.ToString());
                EX_Orders_order.Text = this.EX_Orders_dataGrid.CurrentRow.Cells[1].Value.ToString();
                EX_Orders_DateTime.Text = this.EX_Orders_dataGrid.CurrentRow.Cells[2].Value.ToString();
                EX_Orders_tosorce.Text = this.EX_Orders_dataGrid.CurrentRow.Cells[3].Value.ToString();
                EX_Orders_Body_order.Text = this.EX_Orders_dataGrid.CurrentRow.Cells[4].Value.ToString();
                EX_Orders_Notes.Text = this.EX_Orders_dataGrid.CurrentRow.Cells[5].Value.ToString();
                EX_Orders_CombCategorise.Text = this.EX_Orders_dataGrid.CurrentRow.Cells[6].Value.ToString();
                EX_Orders_update.Enabled = true;
                EX_Orders_delete.Enabled = true;
                EX_Orders_add.Enabled = false;
            }
        }

        private void EX_Orders_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EX_Orders_update_Click(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = order.Exchange_Order_Cheack(EX_Orders_order.Text);
            if (Dt.Rows.Count == 0 || EX_Orders_order.Text== this.EX_Orders_dataGrid.CurrentRow.Cells[1].Value.ToString())
            {
               
               
               order.Exchange_Order_update(Program.Exchange_Order_id, EX_Orders_order.Text, EX_Orders_DateTime.Value, EX_Orders_tosorce.Text, EX_Orders_Body_order.Text, EX_Orders_Notes.Text, Convert.ToInt32(EX_Orders_CombCategorise.SelectedValue));
                MessageBox.Show("تم التحديث", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.EX_Orders_dataGrid.DataSource = order.Exchange_Order_view();
                this.EX_Orders_dataGrid.Columns[0].Visible = false;
                EX_Orders_order.Text = "";
                EX_Orders_tosorce.Text = "";
                EX_Orders_Body_order.Text = "";
                EX_Orders_Notes.Text = "";
              
                EX_Orders_update.Enabled = false;
                EX_Orders_delete.Enabled = false;
            }
            else
            {
                MessageBox.Show("موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                EX_Orders_update.Enabled = false;
                EX_Orders_delete.Enabled = false;
                return;
            }
            
        }

        private void EX_Orders_delete_Click(object sender, EventArgs e)
        {
            order.Exchange_Order_Delete(Program.Exchange_Order_id);
            this.EX_Orders_dataGrid.DataSource = order.Exchange_Order_view();
            this.EX_Orders_dataGrid.Columns[0].Visible = false;
            EX_Orders_order.Text = "";
            EX_Orders_tosorce.Text = "";
            EX_Orders_Body_order.Text = "";
            EX_Orders_Notes.Text = "";
            
            EX_Orders_update.Enabled = false;
            EX_Orders_delete.Enabled = false;
        }

        private void EX_Orders_search_All_TextChanged(object sender, EventArgs e)
        {
            this.EX_Orders_dataGrid.DataSource = order.Exchange_Order_Search_All(EX_Orders_search_All.Text);
            this.EX_Orders_dataGrid.Columns[0].Visible = false;
        }

        private void EX_Orders_search_TextChanged(object sender, EventArgs e)
        {
            this.EX_Orders_dataGrid.DataSource = order.Exchange_Order_Search_NO_Order(EX_Orders_search.Text);
            this.EX_Orders_dataGrid.Columns[0].Visible = false;
        }

        private void EX_Orders_first_ValueChanged(object sender, EventArgs e)
        {
            this.EX_Orders_dataGrid.DataSource = order.Exchange_Order_Search_Between_Date(EX_Orders_first.Value, EX_Orders_last.Value);
            this.EX_Orders_dataGrid.Columns[0].Visible = false;
        }

        private void EX_Orders_last_ValueChanged(object sender, EventArgs e)
        {
            this.EX_Orders_dataGrid.DataSource = order.Exchange_Order_Search_Between_Date(EX_Orders_first.Value, EX_Orders_last.Value);
            this.EX_Orders_dataGrid.Columns[0].Visible = false;
        }
    }
}
