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
    public partial class Loans_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Employee_Description Empl_Des = new BL.CLS_Employee_Description();
        BL.CLS_Coin_Exchange Coin = new BL.CLS_Coin_Exchange();
        BL.CLS_Loan Loa = new BL.CLS_Loan();
        BL.CLS_Contracts cont = new BL.CLS_Contracts();
        BL.CLS_Budget Bud = new BL.CLS_Budget();
        BL.Authority Auth = new BL.Authority();
        BL.Department Dep = new BL.Department();
        public Loans_FORM()
        {
            InitializeComponent();
            Loans_Search_Budget.DataSource = Coin.Coin_Exchange_CombBudg();
            Loans_Search_Budget.DisplayMember = "Date";
            Loans_Search_Budget.ValueMember = "Budget_Id";
            this.StyleManager = Program.theme_style(this);
            this.Loans_Gridview.DataSource = Loa.Loans_View();
            Loans_Gridview.Columns[0].Visible = false;
            
            Loans_Comb_Budget.DataSource = Bud.Budget_combo_Last_Budget();
            Loans_Comb_Budget.DisplayMember = "Date";
            Loans_Comb_Budget.ValueMember = "Budget_Id";
            Loans_CombAthuontic.DataSource = Auth.Authority_view();
            Loans_CombAthuontic.DisplayMember = "اسم الهيئة";
            Loans_CombAthuontic.ValueMember = "Authority_ID";
        }

      
        private void Loans_Comb_Department_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idDepartment = Convert.ToInt32(Loans_Comb_Department.SelectedValue);
                //MessageBox.Show(Contracts_Comb_Department.SelectedValue.GetType().ToString());
                Loans_Comb_Employ.DataSource = cont.Contracts_Comb_Employee(idDepartment);
                Loans_Comb_Employ.DisplayMember = "fullName";
                Loans_Comb_Employ.ValueMember = "Emp_id";

            }
            catch (Exception)
            {

                //throw;
            }
        }

      
        private void Loans_new_Click(object sender, EventArgs e)
        {
            Loans_add.Enabled = true;
            Loans_Amont.Text = "";
            Loans_Notes.Text = "";
            Loans_update.Enabled = false;
            Loans_delete.Enabled = false;
            Loans_Brows_Docs.Enabled = false;
            Loans_Dail.Enabled = false;
        }

        private void Loans_add_Click(object sender, EventArgs e)
        {
            if (Loans_Amont.Text == String.Empty)
            {

                MessageBox.Show("ادخل المبلغ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int idDepartment = Convert.ToInt32(Loans_Comb_Department.SelectedValue);
            int idemployee = Convert.ToInt32(Loans_Comb_Employ.SelectedValue);
            DataTable DT = cont.Contracts_by_Departmentid_Employeeid(idDepartment, idemployee);
            if (DT.Rows.Count > 0)
            {
                DataRow row = DT.Rows[0];
                int id_EmployeeDEsS = Convert.ToInt32(row["Employee_Des_ID"]);
                //MessageBox.Show(id_EmployeeDES.ToString());
                //   bool Functunal_status = Contracts_end.Checked ? true : false;
                Loa.Loans_add(Loans_Amont.Text , Loans_Notes.Text , Loans_Date.Value , Loans_Date_Start.Value , Convert.ToInt32(Loans_Comb_Budget.SelectedValue) , id_EmployeeDEsS);
                this.Loans_Gridview.DataSource = Loa.Loans_View();
                Loans_Gridview.Columns[0].Visible = false;
                int Max_loan_id =Convert.ToInt32(Loa.Leoan_Max_ID().Rows[0][0]);
                /// اضافة ملحقات للقرض
                if (MessageBox.Show("هل تريد اضافة ملحقات لهذا القرض؟", "ملحقات", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Document_FORM FRM = new Document_FORM(Max_loan_id, "قرض");
                    FRM.ShowDialog();
                }
                ////
                Program.Add_Message();
                Loans_Amont.Text = "";
                Loans_Notes.Text = "";
                Loans_update.Enabled = false;
                Loans_delete.Enabled = false;
                Loans_Brows_Docs.Enabled = false;
                Loans_Dail.Enabled = false;
            }

        }

        private void Loans_Gridview_Click(object sender, EventArgs e)
        {
            if (Loans_Gridview.CurrentRow != null)
            {
                Program.Loan_id = Convert.ToInt32(this.Loans_Gridview.CurrentRow.Cells[0].Value.ToString());
                Loans_Amont.Text = this.Loans_Gridview.CurrentRow.Cells[1].Value.ToString();
                Loans_Notes.Text = this.Loans_Gridview.CurrentRow.Cells[2].Value.ToString();
                Loans_Date.Text = this.Loans_Gridview.CurrentRow.Cells[3].Value.ToString();
                Loans_Date_Start.Text = this.Loans_Gridview.CurrentRow.Cells[4].Value.ToString();
                Loans_Comb_Department.Text = this.Loans_Gridview.CurrentRow.Cells[7].Value.ToString();
                Loans_Comb_Employ.Text = this.Loans_Gridview.CurrentRow.Cells[6].Value.ToString();
                Loans_update.Enabled = true;
                Loans_delete.Enabled = true;
                Loans_Brows_Docs.Enabled = true;
                Loans_Dail.Enabled = true;
                Loans_add.Enabled = false;
            }
        }

        private void Loans_update_Click(object sender, EventArgs e)
        {
            if (Loans_Amont.Text == String.Empty)
            {

                MessageBox.Show("ادخل المبلغ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int idDepartment = Convert.ToInt32(Loans_Comb_Department.SelectedValue);
            int idemployee = Convert.ToInt32(Loans_Comb_Employ.SelectedValue);
            DataTable DT = cont.Contracts_by_Departmentid_Employeeid(idDepartment, idemployee);
            if (DT.Rows.Count > 0)
            {
                DataRow row = DT.Rows[0];
                int id_EmployeeDEsS = Convert.ToInt32(row["Employee_Des_ID"]);
                //MessageBox.Show(id_EmployeeDES.ToString());
                //   bool Functunal_status = Contracts_end.Checked ? true : false;
                Loa.Loans_update(Loans_Amont.Text, Loans_Notes.Text, Loans_Date.Value, Loans_Date_Start.Value, Convert.ToInt32(Loans_Comb_Budget.SelectedValue), id_EmployeeDEsS , Program.Loan_id);
                this.Loans_Gridview.DataSource = Loa.Loans_View();
                Loans_Gridview.Columns[0].Visible = false;
                Program.Update_Message();
                Loans_Amont.Text = "";
                Loans_Notes.Text = "";
                Loans_update.Enabled = false;
                Loans_delete.Enabled = false;
                Loans_Brows_Docs.Enabled = false;
                Loans_Dail.Enabled = false;
            }
        }

        private void Loans_Fexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loans_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف القرض .اذا تم الحذف فسيتم حذف كافة تفاصيلها من البرنامج؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Loa.Loans_Delete(Program.Loan_id);
                this.Loans_Gridview.DataSource = Loa.Loans_View();
                Loans_Gridview.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Loans_Amont.Text = "";
                Loans_Notes.Text = "";
                Loans_update.Enabled = false;
                Loans_delete.Enabled = false;
                Loans_Brows_Docs.Enabled = false;
                Loans_Dail.Enabled = false;
            }
        }

       
        private void Loans_Search_Budget_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Loans_Gridview.DataSource = Loa.Loans_Search_Budget_Date(Convert.ToInt32(Loans_Search_Budget.SelectedValue));
                Loans_Gridview.Columns[0].Visible = false;
            }
            catch { return; }
        }

        private void Loans_Print_Click(object sender, EventArgs e)
        {
            REPT.Crystal_Loans Art = new REPT.Crystal_Loans();

            REPT.FRM_Report FRPT = new REPT.FRM_Report();

            if (Loans_Gridview.Rows.Count != 0)
            {
                // DataTable dt = dataGrid_Ringall.DataSource;
                Art.SetDataSource(Loans_Gridview.DataSource);

                FRPT.crystalReportViewer1.ReportSource = Art;
                FRPT.ShowDialog();
            }
        }

        private void Loans_Search_All_TextChanged_1(object sender, EventArgs e)
        {
            this.Loans_Gridview.DataSource = Loa.Loans_Search_All(Loans_Search_All.Text);
            Loans_Gridview.Columns[0].Visible = false;
        }

        private void Loans_Amont_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void update_Click(object sender, EventArgs e)
        {
            this.Loans_Gridview.DataSource = Loa.Loans_View();
            Loans_Gridview.Columns[0].Visible = false;
        }
        private void Loans_CombAthuontic_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idAthuontic = Convert.ToInt32(Loans_CombAthuontic.SelectedValue);
                //MessageBox.Show(Contracts_Comb_Department.SelectedValue.GetType().ToString());
                Loans_CombOffice.DataSource = Dep.Department_CombAuthority_Office(idAthuontic);
                Loans_CombOffice.DisplayMember = "Office_Name";
                Loans_CombOffice.ValueMember = "Office_ID";

            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void Loans_CombOffice_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idOffice = Convert.ToInt32(Loans_CombOffice.SelectedValue);
                Loans_Comb_Department.DataSource = Dep.Loans_Comb_Department(idOffice);
                Loans_Comb_Department.DisplayMember = "Department_Name";
                Loans_Comb_Department.ValueMember = "Department_ID";

            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void Loans_Dail_Click(object sender, EventArgs e)
        {
            Leoan_Payments_FORM FRM = new Leoan_Payments_FORM();
            FRM.Leoan_Payments_Total.Text=this.Loans_Gridview.CurrentRow.Cells[1].Value.ToString();
            FRM.ShowDialog();
        }

        private void Loans_Brows_Docs_Click(object sender, EventArgs e)
        {
            Document_FORM FRM = new Document_FORM(Program.Loan_id, "قرض");
            FRM.ShowDialog();
        }
    }
}
