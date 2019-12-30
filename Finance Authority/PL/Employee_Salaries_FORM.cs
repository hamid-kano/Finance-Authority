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
        BL.CLS_Payment_Document Pay = new BL.CLS_Payment_Document();
        BL.CLS_Operations ope = new BL.CLS_Operations();
        BL.CLS_Budget budget = new BL.CLS_Budget();
        BL.CLS_Employee_Description des = new BL.CLS_Employee_Description();
        BL.CLS_Employee_Salaries emp_Sal = new BL.CLS_Employee_Salaries();
        BL.CLS_Employee emp = new BL.CLS_Employee();
        public Employee_Salaries_FORM()
        {
            InitializeComponent();
            Employee_Salaries_Saliery.DataSource = Empl_Sala.Employee_Salaries_Comb_Date_Emiss();
            Employee_Salaries_Saliery.DisplayMember = "Date";
            Employee_Salaries_Saliery.ValueMember = "Emission_Salaries_id";
            this.StyleManager = Program.theme_style(this);
            //this.Employee_Salaries_dataGrid.DataSource = Empl_Sala.Employee_Salaries_View();
            //Employee_Salaries_dataGrid.Columns[0].Visible = false;
            Employee_Salaries_dataGrid.Columns[20].Visible = false;
        }

        private void Employee_Salaries_dataGrid_Click(object sender, EventArgs e)
        {
            try
            {

            if (Employee_Salaries_dataGrid.CurrentRow != null)
            {
                Program.Employee_Salaries_id = Convert.ToInt32(this.Employee_Salaries_dataGrid.CurrentRow.Cells[0].Value.ToString());
                Employee_Salaries_commit.Enabled = true;
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
                Employee_Salaries_commit.Enabled = false;
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
                Program.Emission_Salaries_id = Convert.ToInt32(Employee_Salaries_Saliery.SelectedValue);
                this.Employee_Salaries_dataGrid.DataSource = Empl_Sala.Employee_Salaries_Search_Emission_Salaries(Program.Emission_Salaries_id);
                Employee_Salaries_dataGrid.Columns[0].Visible = false;
                this.Employee_Salaries_dataGrid.Columns[1].ReadOnly = true;
                this.Employee_Salaries_dataGrid.Columns[2].ReadOnly = true;
                Employee_Salaries_Office_txt.Text= Empl_Sala.Employee_Salaries_Search_Emission_Salaries(Program.Emission_Salaries_id).Rows[0][2].ToString();
                this.Employee_Salaries_dataGrid.Columns[4].ReadOnly = true;
                this.Employee_Salaries_dataGrid.Columns[19].ReadOnly = true;
                Employee_Salaries_dataGrid.Columns[20].Visible = false;

                ///// عرض رقم السند وامر الصرف و المجموع الكلي في حال كان مثبت من قبل 
                DataTable dt2;
                if ((dt2=ope.Operations_Bill_Salary_LoanPay_Viewby_towID(Program.Emission_Salaries_id, "رواتب")).Rows.Count != 0)
                {
                    int Payement_id_for_this_Emp_Salaries = Convert.ToInt32(dt2.Rows[0][0]);
                    DataTable dt;
                    if ((dt=Pay.Payment_Document_Search_by_id(Payement_id_for_this_Emp_Salaries)).Rows.Count!=0)
                    {
                        Salary_Total.Text = dt.Rows[0][1].ToString();
                        Payment_Document_no.Text = dt.Rows[0][4].ToString();
                        Payment_Document_No_Order.Text = dt.Rows[0][5].ToString();
                    } 
                    Employee_Salaries_commit.Text = "اعادة تثبيت التسليم";
                }
                else
                {
                    Salary_Total.Text = "";
                    Payment_Document_no.Text = "";
                    Payment_Document_No_Order.Text = "";
                    Employee_Salaries_commit.Text = "تثبيت التسليم";
                }
                ///
            }
            catch (Exception)
            {

                //throw;
            }
            
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
            DT_REPORT.Columns.Add("المكتب", typeof(string));

            foreach (DataGridViewRow dgv in Employee_Salaries_dataGrid.Rows)
            {
                DT_REPORT.Rows.Add(dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value
                   , dgv.Cells[6].Value, dgv.Cells[7].Value, dgv.Cells[8].Value, dgv.Cells[9].Value, dgv.Cells[10].Value
                  , dgv.Cells[11].Value, dgv.Cells[12].Value, dgv.Cells[13].Value, dgv.Cells[14].Value
                  , dgv.Cells[15].Value, dgv.Cells[16].Value, dgv.Cells[17].Value, dgv.Cells[18].Value, Convert.ToDateTime(dgv.Cells[19].Value).ToShortDateString()
                  , dgv.Cells[1].Value, dgv.Cells[2].Value);
            }
            DS.Tables.Add(DT_REPORT);
            DS.WriteXmlSchema("C:\\AraratProgramFiles\\Employee_Salaries.xml");
            REPT.FRM_Report frm = new REPT.FRM_Report();
            REPT.Employee_Salarie report = new REPT.Employee_Salarie();
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
            this.Employee_Salaries_dataGrid.Columns[20].Visible = false;

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

        private void Employee_Salaries_dataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var cell = Employee_Salaries_dataGrid.CurrentCell;
            if (cell.ColumnIndex == 3 || cell.ColumnIndex == 5 || cell.ColumnIndex == 6 || cell.ColumnIndex == 7
                || cell.ColumnIndex == 8 || cell.ColumnIndex == 9 || cell.ColumnIndex == 10 || cell.ColumnIndex == 11 ||
                cell.ColumnIndex == 12 || cell.ColumnIndex == 13 || cell.ColumnIndex == 14 || cell.ColumnIndex == 16)
            {
                if (!double.TryParse(cell.Value.ToString() == "" ? "0" : cell.Value.ToString(), out double temp))
                {
                    Program.Special_Message("لايمكن كتابة المحارف النصية في هذه الخلية");
                    cell.Value = 0;
                }
            }

            try
            {
                double sum = 0;
                Salary_Total.Text = sum.ToString();
                double tempSum;
                for (int i = 0; i < Employee_Salaries_dataGrid.Rows.Count; ++i)
                {
                    tempSum=  double.TryParse(Convert.ToDouble(Employee_Salaries_dataGrid.Rows[i].Cells[14].Value).ToString(), out double temp)? temp:0;
                    sum += tempSum;// Convert.ToDouble(Employee_Salaries_dataGrid.Rows[i].Cells[14].Value);
                    Salary_Total.Text = sum.ToString();
                }
                Salary_Total.Text = sum.ToString();
            }
            catch (Exception)
            {

                // throw;
            }


        }

        private void Employee_Salaries_commit_Click(object sender, EventArgs e)
        {
            if (!(Employee_Salaries_dataGrid.RowCount>0))
            {
                Program.Special_Message("ليس هناك عاملين لتثبيت بيانات الراتب");
                return;
            }
            if (Payment_Document_no.Text == "")
            {
                MessageBox.Show("يجب ادخال رقم السند", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Payment_Document_No_Order.Text == "")
            {
                MessageBox.Show("يجب ادخال رقم امر الصرف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            if (ope.Operations_Bill_Salary_LoanPay_Viewby_towID(Program.Emission_Salaries_id, "رواتب").Rows.Count ==0)
            {
                // اضافة
                DataTable Dt = Pay.Payment_Document_View();
                for (int i = 0; i < Dt.Rows.Count; i++)
                {
                   
                        if (Payment_Document_no.Text == Dt.Rows[i][4].ToString())
                        {
                            MessageBox.Show("رقم السند موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        if (Payment_Document_No_Order.Text == Dt.Rows[i][5].ToString())
                        {
                            MessageBox.Show("رقم امر الصرف موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                  
                }
                ///////
                Pay.Payment_Document_add(Salary_Total.Text==string.Empty?"0": Salary_Total.Text, "0","0", Payment_Document_no.Text,
                            Payment_Document_No_Order.Text,"رواتب","العاملين",DateTime.Now
                            ,"لايوجد",Convert.ToInt32(budget.Budget_Last_Budget().Rows[0][0]),1011);
                ope.Operations_Bill_Salary_LoanPay_add(Convert.ToInt32(Pay.Payment_Document_Max_ID().Rows[0][0]), Program.Emission_Salaries_id, "رواتب");
                // تحديث الميزانية
                Program.Budget_update_after_Payment_Reciver("P", Salary_Total.Text, "0" );
            }
            else
            {
                DataTable dt;
                if ((dt= ope.Operations_Bill_Salary_LoanPay_Viewby_towID(Program.Emission_Salaries_id, "رواتب")).Rows.Count!=0)
                {
                    // تعديل
                    int Payement_id_for_this_Emp_Salaries = Convert.ToInt32(dt.Rows[0][0]);
                    DataTable Dt = Pay.Payment_Document_View();
                    for (int i = 0; i < Dt.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(Dt.Rows[i][0]) != Payement_id_for_this_Emp_Salaries)
                        {

                            if (Payment_Document_no.Text == Dt.Rows[i][4].ToString())
                            {
                                MessageBox.Show("رقم السند موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            if (Payment_Document_No_Order.Text == Dt.Rows[i][5].ToString())
                            {
                                MessageBox.Show("رقم امر الصرف موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }

                        }
                    }
                    //
                    DataTable dt2;
                    if ((dt2= Pay.Payment_Document_Search_by_id(Payement_id_for_this_Emp_Salaries)).Rows.Count!=0)
                    {
                        double PrivSy = Convert.ToDouble(dt2.Rows[0][1]);
                        double PrivDo = Convert.ToDouble(dt2.Rows[0][2]);
                        // تحديث الميزانية
                        Program.Budget_update_after_Payment_Reciver("R", PrivSy.ToString(), PrivDo.ToString());
                    }
                    Program.Budget_update_after_Payment_Reciver("P", Salary_Total.Text, "0");
                    //
                    Pay.Payment_Document_update(Salary_Total.Text == string.Empty ? "0" : Salary_Total.Text, "0", "0", Payment_Document_no.Text,
                         Payment_Document_No_Order.Text, "رواتب", "العاملين", DateTime.Now
                       , "لايوجد", Convert.ToInt32(budget.Budget_Last_Budget().Rows[0][0]), 1011, Payement_id_for_this_Emp_Salaries);

                }      
            }
            // تعديل بيانات العاملين ----- في كلا الحالتين اول مرة تثبيت او في التثبيت اكثر من مرة
            DataTable dt_DS =(DataTable)Employee_Salaries_dataGrid.DataSource;
            for (int i = 0; i < Employee_Salaries_dataGrid.RowCount; i++)
            {
               emp_Sal.Employee_Salaries_update(dt_DS.Rows[i][3].ToString() 
                   , dt_DS.Rows[i][4].ToString(), dt_DS.Rows[i][5].ToString(), dt_DS.Rows[i][6].ToString(),
                   dt_DS.Rows[i][7].ToString(), dt_DS.Rows[i][8].ToString(), dt_DS.Rows[i][9].ToString(),
                   dt_DS.Rows[i][10].ToString(), dt_DS.Rows[i][11].ToString(), dt_DS.Rows[i][12].ToString(),
                   dt_DS.Rows[i][13].ToString(), dt_DS.Rows[i][14].ToString(), dt_DS.Rows[i][15].ToString(),
                   dt_DS.Rows[i][16].ToString(), dt_DS.Rows[i][17].ToString(), dt_DS.Rows[i][18].ToString(),
                   Program.Emission_Salaries_id, Convert.ToInt32(dt_DS.Rows[i][20]), Convert.ToInt32(dt_DS.Rows[i][0]));
            }
            Program.Special_Message("تم التثبيت بنجاح");
            this.Employee_Salaries_dataGrid.DataSource = Empl_Sala.Employee_Salaries_Search_Emission_Salaries(-1);
            Employee_Salaries_dataGrid.Columns[0].Visible = false;
            this.Employee_Salaries_dataGrid.Columns[1].ReadOnly = true;
            this.Employee_Salaries_dataGrid.Columns[2].ReadOnly = true;
            this.Employee_Salaries_dataGrid.Columns[4].ReadOnly = true;
            this.Employee_Salaries_dataGrid.Columns[19].ReadOnly = true;
            Employee_Salaries_dataGrid.Columns[20].Visible = false;

        }

        private void Payment_Document_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Payment_Document_No_Order_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }
    }
}
