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
    public partial class Employee_Description_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Employee_Description Empl_Des = new BL.CLS_Employee_Description();
        public Employee_Description_FORM()
        {
            InitializeComponent();
            this.Employee_Description_dataGrid.DataSource = Empl_Des.Employee_Description_View();
            Employee_Description_dataGrid.Columns[0].Visible = false;
            Employee_Description_dataGrid.Columns[8].Visible = false;
            Employee_Description_Comb_employ.DataSource = Empl_Des.Employee_Description_Comb_employ();
            Employee_Description_Comb_employ.DisplayMember = "fullName";
            Employee_Description_Comb_employ.ValueMember = "Employee_id";
            Employee_Description_Comb_Role.DataSource = Empl_Des.Employee_Description_Comb_Role();
            Employee_Description_Comb_Role.DisplayMember = "Role_Name";
            Employee_Description_Comb_Role.ValueMember = "Role_Functional_id";
            Employee_Description_Comb_Department.DataSource = Empl_Des.Employee_Description_Comb_Department();
            Employee_Description_Comb_Department.DisplayMember = "Department_Name";
            Employee_Description_Comb_Department.ValueMember = "Department_ID";
        }

        private void Employee_Description_new_Click(object sender, EventArgs e)
        {
            Employee_Description_N0_Book.Text = "";
            Employee_Description_Salery.Text = "";
            Employee_Description_add.Enabled = true;
            Employee_Description_update.Enabled = false;
            Employee_Description_delete.Enabled = false;
        }

        private void Employee_Description_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employee_Description_add_Click(object sender, EventArgs e)
        {
            bool Functunal_status = Employee_Description_Allowes.Checked ? true : false;
            bool Role_status = Employee_Description_Now.Checked ? true : false;
            Empl_Des.Employee_Description_add(Functunal_status , Role_status , Employee_Description_DateTime.Value , Employee_Description_N0_Book.Text , Employee_Description_Salery.Text, Convert.ToInt32(Employee_Description_Comb_Department.SelectedValue), Convert.ToInt32(Employee_Description_Comb_Role.SelectedValue) , Convert.ToInt32(Employee_Description_Comb_employ.SelectedValue));
            MessageBox.Show("تم الأضافة بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Employee_Description_dataGrid.DataSource = Empl_Des.Employee_Description_View();
            Employee_Description_dataGrid.Columns[0].Visible = false;
            Employee_Description_dataGrid.Columns[8].Visible = false;
            Employee_Description_N0_Book.Text = "";
            Employee_Description_Salery.Text = "";
            Employee_Description_add.Enabled = false;
        }

        private void Employee_Description_update_Click(object sender, EventArgs e)
        {
           // Empl_Des.Employee_Description_update();
        }
    }
}
