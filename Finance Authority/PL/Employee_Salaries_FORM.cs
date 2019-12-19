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
        BL.Department Dep = new BL.Department();
        public Employee_Salaries_FORM()
        {
            InitializeComponent();
            Employee_Salaries_Saliery.DataSource = Empl_Sala.Employee_Salaries_Comb_Date_Emiss();
            Employee_Salaries_Saliery.DisplayMember = "Date";
            Employee_Salaries_Saliery.ValueMember = "Emission_Salaries_id";
            Employee_Salaries_Office.DataSource = Dep.Department_CombOffice();
            Employee_Salaries_Office.DisplayMember = "Office_Name";
            Employee_Salaries_Office.ValueMember = "Office_ID";
            this.StyleManager = Program.theme_style(this);
            //this.Employee_Salaries_dataGrid.DataSource = Empl_Sala.Employee_Salaries_View();
            //Employee_Salaries_dataGrid.Columns[0].Visible = false;
        }

       

        private void Employee_Salaries_add_Click(object sender, EventArgs e)
        {
                //Empl_Sala.Employee_Salaries_add(Empl_Sala_Dayes.Text, Empl_Sala_Rem_cons.Text, Empl_Sala_Absences.Text, Empl_Sala_va_out_sal.Text
                //    , Empl_Sala_Exam.Text, Empl_Sala_Punishments.Text, Empl_Sala_Loans.Text, Empl_Sala_Taskes.Text, Empl_Sala_Reparations.Text
                //    , Empl_Sala_Years_Seniority.Text, Empl_Sala_Total.Text, Empl_Sala_after_Reb.Text, Empl_Sala_Notes.Text
                //    , Empl_Sala_Insurances.Text , Empl_Sala_Files1.Text, Empl_Sala_Files2.Text,Convert.ToInt32(Employee_Salaries_Saliery.SelectedValue));
                //this.Employee_Salaries_dataGrid.DataSource = Empl_Sala.Employee_Salaries_View();
                //Employee_Salaries_dataGrid.Columns[0].Visible = false;
                //Program.Add_Message();
                //Empl_Sala_Dayes.Text = "";
                //Empl_Sala_Rem_cons.Text = "";
                //Empl_Sala_Absences.Text = "";
                //Empl_Sala_va_out_sal.Text = "";
                //Empl_Sala_Exam.Text = "";
                //Empl_Sala_Punishments.Text = "";
                //Empl_Sala_Loans.Text = "";
                //Empl_Sala_Taskes.Text = "";
                //Empl_Sala_Reparations.Text = "";
                //Empl_Sala_Years_Seniority.Text = "";
                //Empl_Sala_Total.Text = "";
                //Empl_Sala_after_Reb.Text = "";
                //Empl_Sala_Notes.Text = "";
                //Empl_Sala_Insurances.Text = "";
                //Empl_Sala_Files1.Text = "";
                //Empl_Sala_Files2.Text = "";
                //Employee_Salaries_add.Enabled = false;         
        }

        private void Employee_Salaries_new_Click(object sender, EventArgs e)
        {
            Employee_Salaries_add.Enabled = true;
            Empl_Sala_Dayes.Text = "";
            Empl_Sala_Rem_cons.Text = "";
            Empl_Sala_Absences.Text = "";
            Empl_Sala_va_out_sal.Text = "";
            Empl_Sala_Exam.Text = "";
            Empl_Sala_Punishments.Text = "";
            Empl_Sala_Loans.Text = "";
            Empl_Sala_Taskes.Text = "";
            Empl_Sala_Reparations.Text = "";
            Empl_Sala_Years_Seniority.Text = "";
            Empl_Sala_Total.Text = "";
            Empl_Sala_after_Reb.Text = "";
            Empl_Sala_Notes.Text = "";
            Empl_Sala_Insurances.Text = "";
            Empl_Sala_Files1.Text = "";
            Empl_Sala_Files2.Text = "";
        }

        private void Employee_Salaries_update_Click(object sender, EventArgs e)
        {
            //int idDepartment = Convert.ToInt32(Empl_Sala_Comb_Department.SelectedValue);
            //int idemployee = Convert.ToInt32(Empl_Sala_Comb_Emplyment.SelectedValue);
            //DataTable DT = cont.Contracts_by_Departmentid_Employeeid(idDepartment, idemployee);
            //if (DT.Rows.Count > 0)
            //{
            //    DataRow row = DT.Rows[0];
            //    int id_EmployeeDES = Convert.ToInt32(row["Employee_Des_ID"]);
            //    Empl_Sala.Employee_Salaries_update(Empl_Sala_Dayes.Text, Empl_Sala_Rem_cons.Text, Empl_Sala_Absences.Text, Empl_Sala_va_out_sal.Text
            //        , Empl_Sala_Exam.Text, Empl_Sala_Punishments.Text, Empl_Sala_Loans.Text, Empl_Sala_Taskes.Text, Empl_Sala_Reparations.Text
            //        , Empl_Sala_Years_Seniority.Text, Empl_Sala_Total.Text, Empl_Sala_after_Reb.Text, Empl_Sala_Notes.Text
            //        , Empl_Sala_Insurances.Text, Empl_Sala_Files1.Text, Empl_Sala_Files2.Text, Convert.ToInt32(Empl_Sala_Comb_Date_Emiss.SelectedValue), id_EmployeeDES, Program.Employee_Salaries_id);
            //    this.Employee_Salaries_dataGrid.DataSource = Empl_Sala.Employee_Salaries_View();
            //    Employee_Salaries_dataGrid.Columns[0].Visible = false;
            //    Program.Update_Message();
            //    Empl_Sala_Dayes.Text = "";
            //    Empl_Sala_Rem_cons.Text = "";
            //    Empl_Sala_Absences.Text = "";
            //    Empl_Sala_va_out_sal.Text = "";
            //    Empl_Sala_Exam.Text = "";
            //    Empl_Sala_Punishments.Text = "";
            //    Empl_Sala_Loans.Text = "";
            //    Empl_Sala_Taskes.Text = "";
            //    Empl_Sala_Reparations.Text = "";
            //    Empl_Sala_Years_Seniority.Text = "";
            //    Empl_Sala_Total.Text = "";
            //    Empl_Sala_after_Reb.Text = "";
            //    Empl_Sala_Notes.Text = "";
            //    Empl_Sala_Insurances.Text = "";
            //    Empl_Sala_Files1.Text = "";
            //    Empl_Sala_Files2.Text = "";
            //    Employee_Salaries_add.Enabled = false;
            //    Employee_Salaries_update.Enabled = false;
            //    Employee_Salaries_delete.Enabled = false;

            //}
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
                Employee_Salaries_update.Enabled = true;
                Employee_Salaries_delete.Enabled = true;
                Employee_Salaries_add.Enabled = false;
            }
        }

        private void Employee_Salaries_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف راتب الموظف .اذا تم الحذف فسيتم حذف كافة تفاصيلها من البرنامج؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Empl_Sala.Employee_Salaries_Delete(Program.Employee_Salaries_id);
                //this.Employee_Salaries_dataGrid.DataSource = Empl_Sala.Employee_Salaries_View();
                //Employee_Salaries_dataGrid.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Empl_Sala_Dayes.Text = "";
                Empl_Sala_Rem_cons.Text = "";
                Empl_Sala_Absences.Text = "";
                Empl_Sala_va_out_sal.Text = "";
                Empl_Sala_Exam.Text = "";
                Empl_Sala_Punishments.Text = "";
                Empl_Sala_Loans.Text = "";
                Empl_Sala_Taskes.Text = "";
                Empl_Sala_Reparations.Text = "";
                Empl_Sala_Years_Seniority.Text = "";
                Empl_Sala_Total.Text = "";
                Empl_Sala_after_Reb.Text = "";
                Empl_Sala_Notes.Text = "";
                Empl_Sala_Insurances.Text = "";
                Empl_Sala_Files1.Text = "";
                Empl_Sala_Files2.Text = "";
                Employee_Salaries_update.Enabled = false;
                Employee_Salaries_delete.Enabled = false;
            }
        }

        private void Employee_Salaries_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void Employee_Salaries_Department_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int idDepartment = Convert.ToInt32(Employee_Salaries_Office.SelectedValue);
        //        Employee_Salaries_Employment.DataSource = cont.Contracts_Comb_Employee(idDepartment);
        //        Employee_Salaries_Employment.DisplayMember = "fullName";
        //        Employee_Salaries_Employment.ValueMember = "Emp_id";
        //        this.Employee_Salaries_dataGrid.DataSource = Empl_Sala.Employee_Salaries_Search_Department(idDepartment);
        //        Employee_Salaries_dataGrid.Columns[0].Visible = false;
        //    }
        //    catch (Exception)
        //    {

        //        //throw;
        //    }
        //}

        private void Employee_Salaries_Saliery_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idDepartment = Convert.ToInt32(Employee_Salaries_Saliery.SelectedValue);
                this.Employee_Salaries_dataGrid.DataSource = Empl_Sala.Employee_Salaries_Search_Emission_Salaries(idDepartment);
                Employee_Salaries_dataGrid.Columns[0].Visible = false;
            }
            catch (Exception)
            {

                //throw;
            }
            
        }

       
        private void Employee_Salaries_Employment_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            { 
                int idemployee = Convert.ToInt32(Employee_Salaries_Employment.SelectedValue);
                this.Employee_Salaries_dataGrid.DataSource = Empl_Sala.Employee_Salaries_Search_Employee_Offiice(idemployee);
                Employee_Salaries_dataGrid.Columns[0].Visible = false;
                
            }
            catch { }
        }

        private void Employee_Salaries_Print_Click(object sender, EventArgs e)
        {
            REPT.Crystal_Employee_Salaries Art = new REPT.Crystal_Employee_Salaries();

            REPT.FRM_Report FRPT = new REPT.FRM_Report();

            if (Employee_Salaries_dataGrid.Rows.Count != 0)
            {
                // DataTable dt = dataGrid_Ringall.DataSource;
                Art.SetDataSource(Employee_Salaries_dataGrid.DataSource);

                FRPT.crystalReportViewer1.ReportSource = Art;
                FRPT.ShowDialog();
            }
        }

        private void Empl_Sala_after_Reb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Empl_Sala_Total_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void update_Click(object sender, EventArgs e)
        {
            this.Employee_Salaries_dataGrid.DataSource = Empl_Sala.Employee_Salaries_View();
            Employee_Salaries_dataGrid.Columns[0].Visible = false;
        }

        private void Empl_Sala_Dayes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Empl_Sala_Rem_cons_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Empl_Sala_Absences_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Empl_Sala_va_out_sal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Empl_Sala_Exam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Empl_Sala_Punishments_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Empl_Sala_Loans_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Empl_Sala_Taskes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Empl_Sala_Reparations_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Empl_Sala_Years_Seniority_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Empl_Sala_after_Reb_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Empl_Sala_Insurances_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Employee_Salaries_Office_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int Office = Convert.ToInt32(Employee_Salaries_Office.SelectedValue);
                Employee_Salaries_Employment.DataSource = cont.Contracts_Comb_Employee(Office);
                Employee_Salaries_Employment.DisplayMember = "fullName";
                Employee_Salaries_Employment.ValueMember = "Emp_id";
                this.Employee_Salaries_dataGrid.DataSource = Empl_Sala.Employee_Salaries_Search_Office(Office);
                Employee_Salaries_dataGrid.Columns[0].Visible = false;
            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}
