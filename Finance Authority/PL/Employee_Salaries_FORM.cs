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

        private void Employee_Salaries_new_Click(object sender, EventArgs e)
        {

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
            try
            {

            if (Employee_Salaries_dataGrid.CurrentRow != null)
            {
                Program.Employee_Salaries_id = Convert.ToInt32(this.Employee_Salaries_dataGrid.CurrentRow.Cells[0].Value.ToString());
                Employee_Salaries_update.Enabled = true;
            }
            }
            catch (Exception)
            {

               // throw;
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
                Employee_Salaries_update.Enabled = false;
            }
        }

        private void Employee_Salaries_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void Employee_Salaries_Saliery_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idDepartment = Convert.ToInt32(Employee_Salaries_Saliery.SelectedValue);
                this.Employee_Salaries_dataGrid.DataSource = Empl_Sala.Employee_Salaries_Search_Emission_Salaries(idDepartment);
                Employee_Salaries_dataGrid.Columns[0].Visible = false;
                this.Employee_Salaries_dataGrid.Columns[1].ReadOnly = true;
                this.Employee_Salaries_dataGrid.Columns[2].ReadOnly = true;
                this.Employee_Salaries_dataGrid.Columns[4].ReadOnly = true;
                this.Employee_Salaries_dataGrid.Columns[19].ReadOnly = true;
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
                this.Employee_Salaries_dataGrid.Columns[1].ReadOnly = true;
                this.Employee_Salaries_dataGrid.Columns[2].ReadOnly = true;
                this.Employee_Salaries_dataGrid.Columns[4].ReadOnly = true;
                this.Employee_Salaries_dataGrid.Columns[19].ReadOnly = true;


            }
            catch { }
        }

        private void Employee_Salaries_Print_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            DataTable DT_REPORT = new DataTable();
            DT_REPORT.Columns.Add("ايام العمل", typeof(string));
            DT_REPORT.Columns.Add("ايام العقد", typeof(string));
            DT_REPORT.Columns.Add("الغيابات", typeof(string));
            DT_REPORT.Columns.Add("اجازة بدون راتب", typeof(string));
            DT_REPORT.Columns.Add("اجازة امتحان ", typeof(string));
            DT_REPORT.Columns.Add("العقوبات", typeof(string));
            DT_REPORT.Columns.Add("القروض", typeof(string));
            DT_REPORT.Columns.Add("المهمات", typeof(string));
            DT_REPORT.Columns.Add("المكافات", typeof(string));
            DT_REPORT.Columns.Add("سنوات الخدمة", typeof(string));
            DT_REPORT.Columns.Add("الاجمالي", typeof(string));
            DT_REPORT.Columns.Add("الراتب", typeof(string));
            DT_REPORT.Columns.Add("الملاحظات", typeof(string));
            DT_REPORT.Columns.Add("التامينات", typeof(string));
            DT_REPORT.Columns.Add("حقل1", typeof(string));
            DT_REPORT.Columns.Add("حقل2", typeof(string));
            DT_REPORT.Columns.Add("التاريخ", typeof(string));
            DT_REPORT.Columns.Add("الموظف", typeof(string));
            DT_REPORT.Columns.Add("القسم", typeof(string));
            foreach (DataGridViewRow dgv in Employee_Salaries_dataGrid.Rows)
            {
                DT_REPORT.Rows.Add(dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value
                   , dgv.Cells[4].Value, dgv.Cells[5].Value, dgv.Cells[6].Value, dgv.Cells[7].Value, dgv.Cells[8].Value
                  , dgv.Cells[9].Value, dgv.Cells[10].Value, dgv.Cells[11].Value, dgv.Cells[12].Value
                  , dgv.Cells[13].Value, dgv.Cells[14].Value, dgv.Cells[15].Value, dgv.Cells[16].Value, Convert.ToDateTime(dgv.Cells[17].Value).ToShortDateString()
                  , dgv.Cells[18].Value, dgv.Cells[19].Value);
            }
            DS.Tables.Add(DT_REPORT);
            DS.WriteXmlSchema("C:\\AraratProgramFiles\\Employee_Salaries.xml");
            REPT.FRM_Report frm = new REPT.FRM_Report();
            REPT.Crystal_Employee_Salaries report = new REPT.Crystal_Employee_Salaries();
            report.Refresh();
            report.SetDataSource(DS);
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
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
            this.Employee_Salaries_dataGrid.Columns[1].ReadOnly = true;
            this.Employee_Salaries_dataGrid.Columns[2].ReadOnly = true;
            this.Employee_Salaries_dataGrid.Columns[4].ReadOnly = true;
            this.Employee_Salaries_dataGrid.Columns[19].ReadOnly = true;

        }

        private void Empl_Sala_Dayes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Empl_Sala_Rem_cons_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = Program.DenyChar(e);
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
                this.Employee_Salaries_dataGrid.Columns[1].ReadOnly = true;
                this.Employee_Salaries_dataGrid.Columns[2].ReadOnly = true;
                this.Employee_Salaries_dataGrid.Columns[4].ReadOnly = true;
                this.Employee_Salaries_dataGrid.Columns[19].ReadOnly = true;

            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void Employee_Salaries_dataGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            var cell = Employee_Salaries_dataGrid.CurrentCell;
            if (cell.ColumnIndex == 3 || cell.ColumnIndex == 5 || cell.ColumnIndex == 6 || cell.ColumnIndex == 7 
                || cell.ColumnIndex == 8 || cell.ColumnIndex == 9 || cell.ColumnIndex == 10 || cell.ColumnIndex == 11 ||
                cell.ColumnIndex == 12 || cell.ColumnIndex == 13 || cell.ColumnIndex == 14 || cell.ColumnIndex == 16)
            {
              
            }
        }
    }
}
