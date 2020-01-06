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
    public partial class Employee_Return_Job : MetroFramework.Forms.MetroForm
    {
        DataTable Dt = new DataTable();
        DataTable Dt_Descrip = new DataTable();
        DataTable Dt_emp = new DataTable();
        BL.CLS_Employee Emp = new BL.CLS_Employee();
        BL.CLS_Employee_Description Empl_Des = new BL.CLS_Employee_Description();
        BL.Authority Auth = new BL.Authority();
        BL.Department Dep = new BL.Department();
        BL.CLS_LOGS LOG = new BL.CLS_LOGS();
        int _Empolyee_Description_ID;
        int Employee_id;
        public Employee_Return_Job(int Empolyee_Description_ID)
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            // معلومات الوصف الوظيفي
            _Empolyee_Description_ID = Empolyee_Description_ID;
            Dt = Emp.Employee_Description_View_id(_Empolyee_Description_ID);
            Dt_emp = Emp.Employee_View_id((int)Dt.Rows[0][8]);
            Employee_id = (int)Dt_emp.Rows[0][0];
            Employee_CombAthuontic.Text = Dt.Rows[0][10].ToString();
            Employee_CombOffice.Text = Dt.Rows[0][9].ToString();
            Employee_Description_N0_Book.Text = Dt.Rows[0][4].ToString();
            Employee_Description_Salery.Text = Dt.Rows[0][5].ToString(); ;
            Employee_Description_Comb_Department.Text = Dt.Rows[0][6].ToString();
            Employee_Description_Comb_Role.Text = Dt.Rows[0][7].ToString();
            Employee_Description_Comb_Satutes.Text = Dt.Rows[0][1].ToString();
            Employee_Description_Now.Checked = Convert.ToBoolean(Dt.Rows[0][2].ToString()) ? true : false;
            Employee_Description_lift.Checked = Employee_Description_Now.Checked ? false : true;
            //
            Employee_Description_Comb_Role.DataSource = Empl_Des.Employee_Description_Comb_Role();
            Employee_Description_Comb_Role.DisplayMember = "Role_Name";
            Employee_Description_Comb_Role.ValueMember = "Role_Functional_id";
            //
            Employee_CombAthuontic.DataSource = Auth.Authority_view();
            Employee_CombAthuontic.DisplayMember = "اسم الهيئة";
            Employee_CombAthuontic.ValueMember = "Authority_ID";
        }
        private void Employee_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employee_Edit_Click(object sender, EventArgs e)
        {
            if (Employee_CombAthuontic.SelectedIndex == -1)
            {

                MessageBox.Show("يجب اختيار اسم الهيئة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Employee_CombOffice.SelectedIndex == -1)
            {

                MessageBox.Show("يجب اختيار اسم المكتب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Employee_Description_Comb_Department.SelectedIndex == -1)
            {

                MessageBox.Show("يجب اختيار اسم القسم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Employee_Description_Comb_Role.SelectedIndex == -1)
            {

                MessageBox.Show("يجب اختيار اسم الدور", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //// التحقق من معلومات الوصف الوظيفي
            if (Employee_Description_N0_Book.Text == String.Empty)
            {

                MessageBox.Show("أضف رقم الكتاب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Employee_Description_Salery.Text == String.Empty)
            {

                MessageBox.Show("أضف راتب الموظف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (CB_in_work.Checked)
            {
                if (Employee_Description_Comb_Satutes.SelectedIndex == -1)
                {

                    MessageBox.Show("يجب اختيار حالة قيد العمل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            Dt_Descrip = Empl_Des.Employee_Description_View();
            for (int i = 0; i < Dt_Descrip.Rows.Count; i++)
            {
                if ((int)Empl_Des.Employee_Description_View().Rows[i][0] != _Empolyee_Description_ID)
                {
                    if (Employee_Description_N0_Book.Text == Dt_Descrip.Rows[i][4].ToString())
                    {
                        MessageBox.Show("رقم الكتاب موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }

           Empl_Des.Employee_Description_update_Role_status_Empl_ID(Employee_id);// جعل الحالات الوظيفية السابقة سابقة
                Empl_Des.Employee_Description_add(Employee_Description_Comb_Satutes.Text , true, Employee_Description_DateTime.Value,
                    Employee_Description_N0_Book.Text, Employee_Description_Salery.Text, Convert.ToInt32(Employee_Description_Comb_Department.SelectedValue), Convert.ToInt32(Employee_Description_Comb_Role.SelectedValue), Employee_id);
            //
            Program.Update_Message();
            LOG.LOGS_add(Program.USER_ID, "تعديل", "اعادة موظف الى العمل", DateTime.Now);
        }

        private void Employee_CombAthuontic_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idAthuontic = Convert.ToInt32(Employee_CombAthuontic.SelectedValue);
                //MessageBox.Show(Contracts_Comb_Department.SelectedValue.GetType().ToString());
                Employee_CombOffice.DataSource = Dep.Department_CombAuthority_Office(idAthuontic);
                Employee_CombOffice.DisplayMember = "Office_Name";
                Employee_CombOffice.ValueMember = "Office_ID";

            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void Employee_CombOffice_SelectedValueChanged(object sender, EventArgs e)
        {

            try
            {
                int idOffice = Convert.ToInt32(Employee_CombOffice.SelectedValue);
                Employee_Description_Comb_Department.DataSource = Dep.Loans_Comb_Department(idOffice);
                Employee_Description_Comb_Department.DisplayMember = "Department_Name";
                Employee_Description_Comb_Department.ValueMember = "Department_ID";

            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}
