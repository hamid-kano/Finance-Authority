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
    public partial class Employee_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Employee Emp = new BL.CLS_Employee();
        public Employee_FORM()
        {
            InitializeComponent();
            this.Employee_dataGrid.DataSource = Emp.Employee_View();
            Employee_dataGrid.Columns[0].Visible = false;
        }

        private void Employee_new_Click(object sender, EventArgs e)
        {
            Employee_add.Enabled = true;
            Employee_First_Name.Text = "";
            Employee_Father_Name.Text = "";
            Employee_Last_Name.Text = "";
            Employee_Mother_Name.Text = "";
            Employee_Mobail.Text = "";
            Employee_Scie_Level.Text = "";
            Employee_Scie_Specialization.Text = "";
            Employee_No_Financial.Text = "";
            Employee_No_Affairs.Text = "";
            Employee_No_File.Text = "";
            Employee_No_Card.Text = "";
            Employee_Gender.Text = "";
            Employee_Marital_status.Text = "";
            Employee_Pr_Service_Years.Text = "";
            Employee_update.Enabled = false;
            Employee_delete.Enabled = false;
        }

        private void Employee_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employee_add_Click(object sender, EventArgs e)
        {
            Emp.Employee_add(Employee_First_Name.Text, Employee_Father_Name.Text, Employee_Last_Name.Text, Employee_Mother_Name.Text
                , Employee_Mobail.Text, Employee_Scie_Level.Text, Employee_Scie_Specialization.Text, Employee_Brith_Date.Value
                , Employee_No_Financial.Text, Employee_No_Affairs.Text , Employee_No_File.Text, Employee_No_Card.Text, Employee_Gender.Text
                , Employee_Marital_status.Text, Employee_Pr_Service_Years.Text);
            MessageBox.Show("تم الأضافة بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Employee_dataGrid.DataSource = Emp.Employee_View();
            Employee_dataGrid.Columns[0].Visible = false;
            Employee_First_Name.Text = "";
            Employee_Father_Name.Text = "";
            Employee_Last_Name.Text = "";
            Employee_Mother_Name.Text = "";
            Employee_Mobail.Text = "";
            Employee_Scie_Level.Text = "";
            Employee_Scie_Specialization.Text = "";
            Employee_No_Financial.Text = "";
            Employee_No_Affairs.Text = "";
            Employee_No_File.Text = "";
            Employee_No_Card.Text = "";
            Employee_Gender.Text = "";
            Employee_Marital_status.Text = "";
            Employee_Pr_Service_Years.Text = "";
            Employee_add.Enabled = false;
        }

        private void Employee_update_Click(object sender, EventArgs e)
        {
            Emp.Employee_update(Employee_First_Name.Text, Employee_Father_Name.Text, Employee_Last_Name.Text, Employee_Mother_Name.Text
               , Employee_Mobail.Text, Employee_Scie_Level.Text, Employee_Scie_Specialization.Text, Employee_Brith_Date.Value
               , Employee_No_Financial.Text, Employee_No_Affairs.Text, Employee_No_File.Text, Employee_No_Card.Text, Employee_Gender.Text
               , Employee_Marital_status.Text, Employee_Pr_Service_Years.Text, Program.Employee_id);
            MessageBox.Show("تم التعديل بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Employee_dataGrid.DataSource = Emp.Employee_View();
            Employee_dataGrid.Columns[0].Visible = false;
            Employee_First_Name.Text = "";
            Employee_Father_Name.Text = "";
            Employee_Last_Name.Text = "";
            Employee_Mother_Name.Text = "";
            Employee_Mobail.Text = "";
            Employee_Scie_Level.Text = "";
            Employee_Scie_Specialization.Text = "";
            Employee_No_Financial.Text = "";
            Employee_No_Affairs.Text = "";
            Employee_No_File.Text = "";
            Employee_No_Card.Text = "";
            Employee_Gender.Text = "";
            Employee_Marital_status.Text = "";
            Employee_Pr_Service_Years.Text = "";
            Employee_update.Enabled = false;
            Employee_delete.Enabled = false;
        }

        private void Employee_dataGrid_Click(object sender, EventArgs e)
        {
            if (Employee_dataGrid.CurrentRow != null)
            {
                Program.Employee_id= Convert.ToInt32(this.Employee_dataGrid.CurrentRow.Cells[0].Value.ToString());
                Employee_First_Name.Text = this.Employee_dataGrid.CurrentRow.Cells[1].Value.ToString();
                Employee_Father_Name.Text = this.Employee_dataGrid.CurrentRow.Cells[2].Value.ToString();
                Employee_Last_Name.Text = this.Employee_dataGrid.CurrentRow.Cells[3].Value.ToString();
                Employee_Mother_Name.Text = this.Employee_dataGrid.CurrentRow.Cells[4].Value.ToString();
                Employee_Brith_Date.Text = this.Employee_dataGrid.CurrentRow.Cells[5].Value.ToString();
                Employee_Mobail.Text = this.Employee_dataGrid.CurrentRow.Cells[6].Value.ToString();
                Employee_Scie_Level.Text = this.Employee_dataGrid.CurrentRow.Cells[7].Value.ToString();
                Employee_Scie_Specialization.Text = this.Employee_dataGrid.CurrentRow.Cells[8].Value.ToString();
                Employee_No_Financial.Text = this.Employee_dataGrid.CurrentRow.Cells[9].Value.ToString();
                Employee_No_Affairs.Text = this.Employee_dataGrid.CurrentRow.Cells[10].Value.ToString();
                Employee_No_File.Text = this.Employee_dataGrid.CurrentRow.Cells[11].Value.ToString();
                Employee_No_Card.Text = this.Employee_dataGrid.CurrentRow.Cells[12].Value.ToString();
                Employee_Gender.Text = this.Employee_dataGrid.CurrentRow.Cells[13].Value.ToString();
                Employee_Marital_status.Text = this.Employee_dataGrid.CurrentRow.Cells[14].Value.ToString();
                Employee_Pr_Service_Years.Text = this.Employee_dataGrid.CurrentRow.Cells[15].Value.ToString();
                Employee_update.Enabled = true;
                Employee_delete.Enabled = true;
            }
        }

        private void Employee_delete_Click(object sender, EventArgs e)
        {
            Emp.Employee_Delete(Program.Employee_id);
            this.Employee_dataGrid.DataSource = Emp.Employee_View();
            Employee_dataGrid.Columns[0].Visible = false;
            Employee_First_Name.Text = "";
            Employee_Father_Name.Text = "";
            Employee_Last_Name.Text = "";
            Employee_Mother_Name.Text = "";
            Employee_Mobail.Text = "";
            Employee_Scie_Level.Text = "";
            Employee_Scie_Specialization.Text = "";
            Employee_No_Financial.Text = "";
            Employee_No_Affairs.Text = "";
            Employee_No_File.Text = "";
            Employee_No_Card.Text = "";
            Employee_Gender.Text = "";
            Employee_Marital_status.Text = "";
            Employee_Pr_Service_Years.Text = "";
            Employee_update.Enabled = false;
            Employee_delete.Enabled = false;
        }

        private void Employee_Search_Name_TextChanged(object sender, EventArgs e)
        {
            this.Employee_dataGrid.DataSource = Emp.Employee_Search_Name(Employee_Search_Name.Text);
            Employee_dataGrid.Columns[0].Visible = false;
        }

        private void Employee_Search_Mony_TextChanged(object sender, EventArgs e)
        {
            this.Employee_dataGrid.DataSource = Emp.Employee_Search_Mony(Employee_Search_Mony.Text);
            Employee_dataGrid.Columns[0].Visible = false;
        }
    }
}
