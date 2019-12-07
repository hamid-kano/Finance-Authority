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
    public partial class Employee_Salaries_FORM :MetroFramework.Forms.MetroForm
    {
        BL.CLS_Contracts cont = new BL.CLS_Contracts();
        BL.CLS_Employee_Description Empl_Des = new BL.CLS_Employee_Description();
        BL.CLS_Employee_Salaries Empl_Sala = new BL.CLS_Employee_Salaries();
        public Employee_Salaries_FORM()
        {
            InitializeComponent();
            this.Employee_Salaries_dataGrid.DataSource = Empl_Sala.Employee_Salaries_View();
            Employee_Salaries_dataGrid.Columns[0].Visible = false;
            Empl_Sala_Comb_Department.DataSource = Empl_Des.Employee_Description_Comb_Department();
            Empl_Sala_Comb_Department.DisplayMember = "Department_Name";
            Empl_Sala_Comb_Department.ValueMember = "Department_ID";
            Empl_Sala_Comb_Date_Emiss.DataSource = Empl_Sala.Employee_Salaries_Comb_Date_Emiss();
            Empl_Sala_Comb_Date_Emiss.DisplayMember = "Date";
            Empl_Sala_Comb_Date_Emiss.ValueMember = "Emission_Salaries_id";
        }

        private void Empl_Sala_Comb_Department_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idDepartment = Convert.ToInt32(Empl_Sala_Comb_Department.SelectedValue);
                //MessageBox.Show(Contracts_Comb_Department.SelectedValue.GetType().ToString());
                Empl_Sala_Comb_Emplyment.DataSource = cont.Contracts_Comb_Employee(idDepartment);
                Empl_Sala_Comb_Emplyment.DisplayMember = "fullName";
                Empl_Sala_Comb_Emplyment.ValueMember = "Emp_id";

            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void Employee_Salaries_add_Click(object sender, EventArgs e)
        {
            int idDepartment = Convert.ToInt32(Empl_Sala_Comb_Department.SelectedValue);
            int idemployee = Convert.ToInt32(Empl_Sala_Comb_Emplyment.SelectedValue);
            DataTable DT = cont.Contracts_by_Departmentid_Employeeid(idDepartment, idemployee);
            if (DT.Rows.Count > 0)
            {
                DataRow row = DT.Rows[0];
                int id_EmployeeDES = Convert.ToInt32(row["Employee_Des_ID"]);
                Empl_Sala.Employee_Salaries_add(Empl_Sala_Dayes.Text, Empl_Sala_Rem_cons.Text, Empl_Sala_Absences.Text, Empl_Sala_va_out_sal.Text
                    , Empl_Sala_Exam.Text, Empl_Sala_Punishments.Text, Empl_Sala_Loans.Text, Empl_Sala_Taskes.Text, Empl_Sala_Reparations.Text
                    , Empl_Sala_Years_Seniority.Text, Empl_Sala_Total.Text, Empl_Sala_after_Reb.Text, Empl_Sala_Notes.Text
                    , Empl_Sala_Insurances.Text , Empl_Sala_Files1.Text, Empl_Sala_Files2.Text,Convert.ToInt32(Empl_Sala_Comb_Date_Emiss.SelectedValue), id_EmployeeDES);
                Program.Add_Message();
                this.Employee_Salaries_dataGrid.DataSource = Empl_Sala.Employee_Salaries_View();
                Employee_Salaries_dataGrid.Columns[0].Visible = false;
                Employee_Salaries_add.Enabled = false;

            }
            
        }

        private void Employee_Salaries_new_Click(object sender, EventArgs e)
        {
            Employee_Salaries_add.Enabled = true;
        }

        private void Employee_Salaries_update_Click(object sender, EventArgs e)
        {
            int idDepartment = Convert.ToInt32(Empl_Sala_Comb_Department.SelectedValue);
            int idemployee = Convert.ToInt32(Empl_Sala_Comb_Emplyment.SelectedValue);
            DataTable DT = cont.Contracts_by_Departmentid_Employeeid(idDepartment, idemployee);
            if (DT.Rows.Count > 0)
            {
                DataRow row = DT.Rows[0];
                int id_EmployeeDES = Convert.ToInt32(row["Employee_Des_ID"]);
                Empl_Sala.Employee_Salaries_update(Empl_Sala_Dayes.Text, Empl_Sala_Rem_cons.Text, Empl_Sala_Absences.Text, Empl_Sala_va_out_sal.Text
                    , Empl_Sala_Exam.Text, Empl_Sala_Punishments.Text, Empl_Sala_Loans.Text, Empl_Sala_Taskes.Text, Empl_Sala_Reparations.Text
                    , Empl_Sala_Years_Seniority.Text, Empl_Sala_Total.Text, Empl_Sala_after_Reb.Text, Empl_Sala_Notes.Text
                    , Empl_Sala_Insurances.Text, Empl_Sala_Files1.Text, Empl_Sala_Files2.Text, Convert.ToInt32(Empl_Sala_Comb_Date_Emiss.SelectedValue), id_EmployeeDES, Program.Employee_Salaries_id);
                Program.Add_Message();
                this.Employee_Salaries_dataGrid.DataSource = Empl_Sala.Employee_Salaries_View();
                Employee_Salaries_dataGrid.Columns[0].Visible = false;
                Employee_Salaries_add.Enabled = false;
                Employee_Salaries_update.Enabled = false;
                Employee_Salaries_delete.Enabled = false;

            }
        }

        private void Employee_Salaries_dataGrid_Click(object sender, EventArgs e)
        {
            if (Employee_Salaries_dataGrid.CurrentRow != null)
            {
                Program.Employee_Salaries_id = Convert.ToInt32(this.Employee_Salaries_dataGrid.CurrentRow.Cells[0].Value.ToString());
                Empl_Sala_Dayes.Text = this.Employee_Salaries_dataGrid.CurrentRow.Cells[1].Value.ToString();
                Empl_Sala_Rem_cons.Text = this.Employee_Salaries_dataGrid.CurrentRow.Cells[2].Value.ToString();
                Empl_Sala_Absences.Text = this.Employee_Salaries_dataGrid.CurrentRow.Cells[3].Value.ToString();
                Empl_Sala_va_out_sal.Text = this.Employee_Salaries_dataGrid.CurrentRow.Cells[4].Value.ToString();
                Empl_Sala_Exam.Text = this.Employee_Salaries_dataGrid.CurrentRow.Cells[5].Value.ToString();
                Empl_Sala_Punishments.Text = this.Employee_Salaries_dataGrid.CurrentRow.Cells[6].Value.ToString();
                Empl_Sala_Loans.Text = this.Employee_Salaries_dataGrid.CurrentRow.Cells[7].Value.ToString();
                Empl_Sala_Taskes.Text = this.Employee_Salaries_dataGrid.CurrentRow.Cells[8].Value.ToString();
                Empl_Sala_Reparations.Text = this.Employee_Salaries_dataGrid.CurrentRow.Cells[9].Value.ToString();
                Empl_Sala_Years_Seniority.Text = this.Employee_Salaries_dataGrid.CurrentRow.Cells[10].Value.ToString();
                Empl_Sala_Total.Text = this.Employee_Salaries_dataGrid.CurrentRow.Cells[11].Value.ToString();
                Empl_Sala_after_Reb.Text = this.Employee_Salaries_dataGrid.CurrentRow.Cells[12].Value.ToString();
                Empl_Sala_Notes.Text = this.Employee_Salaries_dataGrid.CurrentRow.Cells[13].Value.ToString();
                Empl_Sala_Insurances.Text = this.Employee_Salaries_dataGrid.CurrentRow.Cells[14].Value.ToString();
                Empl_Sala_Files1.Text = this.Employee_Salaries_dataGrid.CurrentRow.Cells[15].Value.ToString();
                Empl_Sala_Files2.Text = this.Employee_Salaries_dataGrid.CurrentRow.Cells[16].Value.ToString();
                Empl_Sala_Comb_Department.Text = this.Employee_Salaries_dataGrid.CurrentRow.Cells[19].Value.ToString();
                Empl_Sala_Comb_Emplyment.Text = this.Employee_Salaries_dataGrid.CurrentRow.Cells[18].Value.ToString();
                Employee_Salaries_update.Enabled = true;
                Employee_Salaries_delete.Enabled = true;
            }
        }

        private void Employee_Salaries_delete_Click(object sender, EventArgs e)
        {
            Empl_Sala.Employee_Salaries_Delete(Program.Employee_Salaries_id);
            this.Employee_Salaries_dataGrid.DataSource = Empl_Sala.Employee_Salaries_View();
            Employee_Salaries_dataGrid.Columns[0].Visible = false;
            Employee_Salaries_update.Enabled = false;
            Employee_Salaries_delete.Enabled = false;
        }
    }
}
