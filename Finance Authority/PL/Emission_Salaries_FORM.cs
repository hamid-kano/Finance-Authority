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
    public partial class Emission_Salaries_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Emission_Salaries Emiss = new BL.CLS_Emission_Salaries();
        BL.Department Dep = new BL.Department();
        BL.CLS_Budget Bud = new BL.CLS_Budget();
        BL.CLS_Employee_Description des = new BL.CLS_Employee_Description();
        BL.CLS_Employee_Salaries emp_Sal = new BL.CLS_Employee_Salaries();
        BL.CLS_Employee emp = new BL.CLS_Employee();
        public Emission_Salaries_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            this.Emission_Salaries_dataGrid.DataSource = Emiss.Emission_Salaries_View();
            Emission_Salaries_dataGrid.Columns[0].Visible = false;
            Emission_Salaries_Comb_Budget.DataSource = Bud.Budget_combo_Last_Budget();
            Emission_Salaries_Comb_Budget.DisplayMember = "Date";
            Emission_Salaries_Comb_Budget.ValueMember = "Budget_Id";
            Emission_Salaries_Name_office.DataSource = Dep.Department_CombOffice();
            Emission_Salaries_Name_office.DisplayMember = "Office_Name";
            Emission_Salaries_Name_office.ValueMember = "Office_ID";
        }

        private void Emission_Salaries_new_Click(object sender, EventArgs e)
        {
            Emission_Salaries_add.Enabled = true;
            Emission_Salaries_update.Enabled = false;
            Emission_Salaries_delete.Enabled = false;
            Emission_Salaries_Brows_Docs.Enabled = false;
        }

        private void Emission_Salaries_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Emission_Salaries_add_Click(object sender, EventArgs e)
        {
            Emiss.Emission_Salaries_add(Convert.ToInt32(Emission_Salaries_Name_office.SelectedValue) , Emission_Salaries_Date.Value , Convert.ToInt32(Emission_Salaries_Comb_Budget.SelectedValue));
            /////// اضافة العاملين في هذا المكتب لاصدار رواتبهم لكي تظهر في نافذة رواتب العامليت وتعديل بياناتهم هناك
            DataTable dt = des.Employee_Description_Search_Office(Emission_Salaries_Name_office.Text);
            int id_last_emission =Convert.ToInt32(Emiss.Emission_Salaries_Max_ID().Rows[0][0]);

            //  الحصول على الايام المتبقية للعقد الخاص بالموظف حلقة الادخال
            
            foreach (DataRow item in dt.Rows)
            {
                if(item[1].ToString()=="عقد")
                {       
                    int TotalDays_Remind = Convert.ToInt32((Convert.ToDateTime(emp.Contracts_View_id((int)item[0]).Rows[0][3]) - DateTime.Now.Date).TotalDays);
                    emp_Sal.Employee_Salaries_add("", TotalDays_Remind.ToString(), "", "", "", "", "", "", "", "", "", "", "", "", "", "", id_last_emission,Convert.ToInt32(item[0]));
                }
                else
                {
                    emp_Sal.Employee_Salaries_add("", "مثبت", "", "", "", "", "", "", "", "", "", "", "", "", "", "", id_last_emission, Convert.ToInt32(item[0]));

                }
            }

            ////////

            /// اضافة ملحقات لهذا لاصدار الرواتب
            if (MessageBox.Show("هل تريد اضافة ملحقات لهذا الاصدار؟", "ملحقات", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int MAX_EEmission_Salaries_ID = Convert.ToInt32(Emiss.Emission_Salaries_Max_ID().Rows[0][0]);
                Document_FORM FRM = new Document_FORM(MAX_EEmission_Salaries_ID, "اصدار الرواتب");
                FRM.ShowDialog();
            }
            ////
            this.Emission_Salaries_dataGrid.DataSource = Emiss.Emission_Salaries_View();
            Emission_Salaries_dataGrid.Columns[0].Visible = false;
            Program.Add_Message();
            Emission_Salaries_add.Enabled = false;
        }

        private void Emission_Salaries_update_Click(object sender, EventArgs e)
        {
            Emiss.Emission_Salaries_update(Convert.ToInt32(Emission_Salaries_Name_office.SelectedValue), Emission_Salaries_Date.Value, Convert.ToInt32(Emission_Salaries_Comb_Budget.SelectedValue), Program.Emission_Salaries_id);
            this.Emission_Salaries_dataGrid.DataSource = Emiss.Emission_Salaries_View();
            Emission_Salaries_dataGrid.Columns[0].Visible = false;
            Program.Update_Message();
            Emission_Salaries_update.Enabled = false;
            Emission_Salaries_delete.Enabled = false;
            Emission_Salaries_Brows_Docs.Enabled = false;
        }

        private void Emission_Salaries_dataGrid_Click(object sender, EventArgs e)
        {
            if (Emission_Salaries_dataGrid.CurrentRow != null)
            {
                Program.Emission_Salaries_id = Convert.ToInt32(this.Emission_Salaries_dataGrid.CurrentRow.Cells[0].Value.ToString());
                Emission_Salaries_Name_office.Text = this.Emission_Salaries_dataGrid.CurrentRow.Cells[1].Value.ToString();
                Emission_Salaries_Date.Text = this.Emission_Salaries_dataGrid.CurrentRow.Cells[2].Value.ToString();
                Emission_Salaries_Comb_Budget.Text = this.Emission_Salaries_dataGrid.CurrentRow.Cells[3].Value.ToString();
                Emission_Salaries_update.Enabled = true;
                Emission_Salaries_delete.Enabled = true;
                Emission_Salaries_Brows_Docs.Enabled = true;
                Emission_Salaries_add.Enabled = false;
            }
        }

        private void Emission_Salaries_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف اصدار الراتب .اذا تم الحذف فسيتم حذف كافة تفاصيلها من البرنامج؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Emiss.Emission_Salaries_Delete(Program.Emission_Salaries_id);
                this.Emission_Salaries_dataGrid.DataSource = Emiss.Emission_Salaries_View();
                Emission_Salaries_dataGrid.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Emission_Salaries_update.Enabled = false;
                Emission_Salaries_delete.Enabled = false;
                Emission_Salaries_Brows_Docs.Enabled = false;
            }
        }

        private void Emission_Salaries_Brows_Docs_Click(object sender, EventArgs e)
        {
            Document_FORM FRM = new Document_FORM(Program.Emission_Salaries_id, "اصدار الرواتب");
            FRM.ShowDialog();
        }
    }
}
