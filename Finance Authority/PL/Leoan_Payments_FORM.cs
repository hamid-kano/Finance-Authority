using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Finance_Authority.PL
{
    public partial class Leoan_Payments_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Employee_Description Empl_Des = new BL.CLS_Employee_Description();
        BL.CLS_Coin_Exchange Coin = new BL.CLS_Coin_Exchange();
        BL.CLS_Contracts cont = new BL.CLS_Contracts();
        BL.CLS_Leoan_Payments pay_Leo = new BL.CLS_Leoan_Payments();
        public Leoan_Payments_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            Leoan_Payments_CombSerach.DataSource = Coin.Coin_Exchange_CombBudg();
            Leoan_Payments_CombSerach.DisplayMember = "Date";
            Leoan_Payments_CombSerach.ValueMember = "Budget_Id";
            this.Leoan_Payments_Gridview.DataSource = pay_Leo.Leoan_Payments_View();
            Leoan_Payments_Gridview.Columns[0].Visible = false;
            Leoan_Payments_Comb_Department.DataSource = Empl_Des.Employee_Description_Comb_Department();
            Leoan_Payments_Comb_Department.DisplayMember = "Department_Name";
            Leoan_Payments_Comb_Department.ValueMember = "Department_ID";
            Leoan_Payments_Comb_Budget.DataSource = Coin.Coin_Exchange_CombBudg();
            Leoan_Payments_Comb_Budget.DisplayMember = "Date";
            Leoan_Payments_Comb_Budget.ValueMember = "Budget_Id";
        }

        private void Leoan_Payments_Comb_Department_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idDepartment = Convert.ToInt32(Leoan_Payments_Comb_Department.SelectedValue);
                //MessageBox.Show(Contracts_Comb_Department.SelectedValue.GetType().ToString());
                Leoan_Payments_Comb_Employ.DataSource = cont.Contracts_Comb_Employee(idDepartment);
                Leoan_Payments_Comb_Employ.DisplayMember = "fullName";
                Leoan_Payments_Comb_Employ.ValueMember = "Emp_id";

            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void Leoan_Payments_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Leoan_Payments_new_Click(object sender, EventArgs e)
        {
            Leoan_Payments_add.Enabled = true;
            Leoan_Payments_Amont.Text = "";
            Leoan_Payments_Notes.Text = "";
            Leoan_Payments_update.Enabled = false;
            Leoan_Payments_delete.Enabled = false;
        }

        private void Leoan_Payments_Comb_Employ_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idDepartment = Convert.ToInt32(Leoan_Payments_Comb_Department.SelectedValue);
                int idEmployee = Convert.ToInt32(Leoan_Payments_Comb_Employ.SelectedValue);
                //MessageBox.Show(Contracts_Comb_Department.SelectedValue.GetType().ToString());
                Leoan_Payments_Comb_Dateloean.DataSource = pay_Leo.Leoan_Payments_Comb_Employee_Department(idDepartment, idEmployee);
                Leoan_Payments_Comb_Dateloean.DisplayMember = "Date";
                Leoan_Payments_Comb_Dateloean.ValueMember = "Loans_ID";

            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void Leoan_Payments_add_Click(object sender, EventArgs e)
        {
            int idDepartment = Convert.ToInt32(Leoan_Payments_Comb_Department.SelectedValue);
            int idemployee = Convert.ToInt32(Leoan_Payments_Comb_Employ.SelectedValue);
            int idDatelaon = Convert.ToInt32(Leoan_Payments_Comb_Dateloean.SelectedValue);
            DataTable DT = pay_Leo.Payments_Leoan_by_Departmentid_Employeeid_Loean(idDepartment, idemployee, idDatelaon);
            if (DT.Rows.Count > 0)
            {
                DataRow row = DT.Rows[0];
                int idLoans_ID = Convert.ToInt32(row["Loans_ID"]);
                pay_Leo.Leoan_Payments_add(idLoans_ID,Leoan_Payments_Amont.Text, Leoan_Payments_Notes.Text , Leoan_Payments_Date.Value , Convert.ToInt32(Leoan_Payments_Comb_Budget.SelectedValue));
                this.Leoan_Payments_Gridview.DataSource = pay_Leo.Leoan_Payments_View();
                Leoan_Payments_Gridview.Columns[0].Visible = false;
                Program.Add_Message();
                Leoan_Payments_Amont.Text = "";
                Leoan_Payments_Notes.Text = "";
                Leoan_Payments_update.Enabled = false;
                Leoan_Payments_delete.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Leoan_Payments_update_Click(object sender, EventArgs e)
        {
            int idDepartment = Convert.ToInt32(Leoan_Payments_Comb_Department.SelectedValue);
            int idemployee = Convert.ToInt32(Leoan_Payments_Comb_Employ.SelectedValue);
            int idDatelaon = Convert.ToInt32(Leoan_Payments_Comb_Dateloean.SelectedValue);
            DataTable DT = pay_Leo.Payments_Leoan_by_Departmentid_Employeeid_Loean(idDepartment, idemployee, idDatelaon);
            if (DT.Rows.Count > 0)
            {
                DataRow row = DT.Rows[0];
                int idLoans_ID = Convert.ToInt32(row["Loans_ID"]);
                pay_Leo.Leoan_Payments_update(idLoans_ID, Leoan_Payments_Amont.Text, Leoan_Payments_Notes.Text, Leoan_Payments_Date.Value, Convert.ToInt32(Leoan_Payments_Comb_Budget.SelectedValue), Program.Leoan_Payments_id);
                this.Leoan_Payments_Gridview.DataSource = pay_Leo.Leoan_Payments_View();
                Leoan_Payments_Gridview.Columns[0].Visible = false;
                Program.Update_Message();
                Leoan_Payments_Amont.Text = "";
                Leoan_Payments_Notes.Text = "";
                Leoan_Payments_update.Enabled = false;
                Leoan_Payments_delete.Enabled = false;
            }
        }

        private void Leoan_Payments_Gridview_Click(object sender, EventArgs e)
        {
            if (Leoan_Payments_Gridview.CurrentRow != null)
            {
                Program.Leoan_Payments_id = Convert.ToInt32(this.Leoan_Payments_Gridview.CurrentRow.Cells[0].Value.ToString());
                Leoan_Payments_Amont.Text = this.Leoan_Payments_Gridview.CurrentRow.Cells[1].Value.ToString();
                Leoan_Payments_Notes.Text = this.Leoan_Payments_Gridview.CurrentRow.Cells[2].Value.ToString();
                Leoan_Payments_Date.Text = this.Leoan_Payments_Gridview.CurrentRow.Cells[3].Value.ToString();
                Leoan_Payments_Comb_Budget.Text = this.Leoan_Payments_Gridview.CurrentRow.Cells[4].Value.ToString();
                Leoan_Payments_Comb_Dateloean.Text = this.Leoan_Payments_Gridview.CurrentRow.Cells[7].Value.ToString();
                Leoan_Payments_Comb_Department.Text = this.Leoan_Payments_Gridview.CurrentRow.Cells[6].Value.ToString();
                Leoan_Payments_Comb_Employ.Text = this.Leoan_Payments_Gridview.CurrentRow.Cells[5].Value.ToString();
                Leoan_Payments_update.Enabled = true;
                Leoan_Payments_delete.Enabled = true;
            }
        }

        private void Leoan_Payments_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف؟؟  ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pay_Leo.Leoan_Payments_Delete(Program.Leoan_Payments_id);
                this.Leoan_Payments_Gridview.DataSource = pay_Leo.Leoan_Payments_View();
                Leoan_Payments_Gridview.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Leoan_Payments_Amont.Text = "";
                Leoan_Payments_Notes.Text = "";
                Leoan_Payments_update.Enabled = false;
                Leoan_Payments_delete.Enabled = false;
            }
        }

        private void Leoan_Payments_Search_All_TextChanged(object sender, EventArgs e)
        {
            this.Leoan_Payments_Gridview.DataSource = pay_Leo.Leoan_Payments_Search_All(Leoan_Payments_Search_All.Text);
            Leoan_Payments_Gridview.Columns[0].Visible = false;
        }

        private void Leoan_Payments_CombSerach_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Leoan_Payments_Gridview.DataSource = pay_Leo.Leoan_Payments_Budget_Date(Convert.ToInt32(Leoan_Payments_CombSerach.SelectedValue));
                Leoan_Payments_Gridview.Columns[0].Visible = false;
            }
            catch { return; }
        }

        private void Leoan_Payments_Print_Click(object sender, EventArgs e)
        {
            REPT.Crystal_Leoan_Payments Art = new REPT.Crystal_Leoan_Payments();

            REPT.FRM_Report FRPT = new REPT.FRM_Report();

            if (Leoan_Payments_Gridview.Rows.Count != 0)
            {
                // DataTable dt = dataGrid_Ringall.DataSource;
                Art.SetDataSource(Leoan_Payments_Gridview.DataSource);

                FRPT.crystalReportViewer1.ReportSource = Art;
                FRPT.ShowDialog();
            }
        }
    }
}
