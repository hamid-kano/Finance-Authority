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
    {
        BL.CLS_Bill Bil = new BL.CLS_Bill();
        BL.CLS_Employee_Description Empl_Des = new BL.CLS_Employee_Description();
        BL.CLS_Emission_Salaries Emiss = new BL.CLS_Emission_Salaries();
        public Bills_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            this.Bills_dataGrid.DataSource = Bil.Bill_View();
            Bills_dataGrid.Columns[0].Visible = false;
            Bills_Comb_Department.DataSource = Empl_Des.Employee_Description_Comb_Department();
            Bills_Comb_Department.DisplayMember = "Department_Name";
            Bills_Comb_Department.ValueMember = "Department_ID";
            Bills_Comb_Budget.DataSource = Emiss.Emission_Salaries_Comb_Budget();
            Bills_Comb_Budget.DisplayMember = "Date";
            Bills_Comb_Budget.ValueMember = "Budget_Id";
        }

        private void Bills_new_Click(object sender, EventArgs e)
        {
            Bills_add.Enabled = true;
            Bills_Buyer_Name.Text = "";
            Bills_Coin_Type.Text = "";
            Bills_Exchange_rate.Text = "";
            Bill_Type.Text = "";
            Bill_Total.Text = "";
            Bills_Notes.Text = "";
            Bills_NO_Bill.Text = "";
        }

        private void Bills_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bills_dataGrid_Click(object sender, EventArgs e)
        {
            if (Bills_dataGrid.CurrentRow != null)
            {
                Program.Bill_id = Convert.ToInt32(this.Bills_dataGrid.CurrentRow.Cells[0].Value.ToString());
                Bills_NO_Bill.Text = this.Bills_dataGrid.CurrentRow.Cells[1].Value.ToString();
                Bills_Buyer_Name.Text = this.Bills_dataGrid.CurrentRow.Cells[2].Value.ToString();
                Bills_Coin_Type.Text = this.Bills_dataGrid.CurrentRow.Cells[3].Value.ToString();
                Bills_Exchange_rate.Text = this.Bills_dataGrid.CurrentRow.Cells[4].Value.ToString();
                Bill_Type.Text = this.Bills_dataGrid.CurrentRow.Cells[5].Value.ToString();
                Bill_Total.Text = this.Bills_dataGrid.CurrentRow.Cells[6].Value.ToString();
                Bills_Date.Text = this.Bills_dataGrid.CurrentRow.Cells[7].Value.ToString();
                Bills_Paid.Checked = Convert.ToBoolean(this.Bills_dataGrid.CurrentRow.Cells[8].Value) ? true : false;
                Bills_Not.Checked = Bills_Paid.Checked? false : true;
                Bills_Notes.Text = this.Bills_dataGrid.CurrentRow.Cells[9].Value.ToString();
                Bills_Comb_Department.Text= this.Bills_dataGrid.CurrentRow.Cells[11].Value.ToString();
                Bills_update.Enabled = true;
                Bills_delete.Enabled = true;
            }
        }

        private void Bills_add_Click(object sender, EventArgs e)
        {
            Bil.Bill_add(Convert.ToInt32(Bills_NO_Bill.Text), Bills_Buyer_Name.Text, Bills_Coin_Type.Text, Bills_Exchange_rate.Text, Bill_Type.Text,
               Bill_Total.Text , Bills_Date.Value, Bills_Paid.Checked, Bills_Notes.Text ,Convert.ToInt32(Bills_Comb_Budget.SelectedValue) , Convert.ToInt32(Bills_Comb_Department.SelectedValue));
            this.Bills_dataGrid.DataSource = Bil.Bill_View();
            Bills_dataGrid.Columns[0].Visible = false;
            Program.Add_Message();
            Bills_add.Enabled = false;
            Bills_Buyer_Name.Text = "";
            Bills_Coin_Type.Text = "";
            Bills_Exchange_rate.Text = "";
            Bill_Type.Text = "";
            Bill_Total.Text = "";
            Bills_Notes.Text = "";
            Bills_NO_Bill.Text = "";
        }

        private void Bills_update_Click(object sender, EventArgs e)
        {
            Bil.Bill_update(Convert.ToInt32(Bills_NO_Bill.Text), Bills_Buyer_Name.Text, Bills_Coin_Type.Text, Bills_Exchange_rate.Text, Bill_Type.Text,
             Bill_Total.Text, Bills_Date.Value, Bills_Paid.Checked, Bills_Notes.Text, Convert.ToInt32(Bills_Comb_Budget.SelectedValue), Convert.ToInt32(Bills_Comb_Department.SelectedValue) , Program.Bill_id);
            this.Bills_dataGrid.DataSource = Bil.Bill_View();
            Bills_dataGrid.Columns[0].Visible = false;
            Program.Update_Message();
            Bills_update.Enabled = false;
            Bills_delete.Enabled = false;
            Bills_Buyer_Name.Text = "";
            Bills_Coin_Type.Text = "";
            Bills_Exchange_rate.Text = "";
            Bill_Type.Text = "";
            Bill_Total.Text = "";
            Bills_Notes.Text = "";
            Bills_NO_Bill.Text = "";
        }

        private void Bills_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف؟؟  ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Bil.Bill_Delete(Program.Bill_id);
                this.Bills_dataGrid.DataSource = Bil.Bill_View();
                Bills_dataGrid.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bills_update.Enabled = false;
                Bills_delete.Enabled = false;
                Bills_Buyer_Name.Text = "";
                Bills_Coin_Type.Text = "";
                Bills_Exchange_rate.Text = "";
                Bill_Type.Text = "";
                Bill_Total.Text = "";
                Bills_Notes.Text = "";
                Bills_NO_Bill.Text = "";
            }
        }
    }
}
