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
        BL.Office Offic = new BL.Office();
        BL.CLS_LOGS LOG = new BL.CLS_LOGS();
        public Employee_Description_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            Employee_Description_Comb_Search.DataSource = Offic.Office_View();
            Employee_Description_Comb_Search.DisplayMember = "اسم المكتب";
            Employee_Description_Comb_Search.ValueMember = "Office_ID";
            this.Employee_Description_dataGrid.DataSource = Empl_Des.Employee_Description_View();
            Employee_Description_dataGrid.Columns[0].Visible = false;
            Employee_Description_dataGrid.Columns[12].Visible = false;
            Employee_Description_Comb_Employee.SelectedIndex = 0;
        }
        private void Employee_Description_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Employee_Description_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف صفة الموظف .اذا تم الحذف فسيتم حذف كافة تفاصيلها من البرنامج؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Empl_Des.Employee_Description_Delete(Program.Employee_Description_id);
                this.Employee_Description_dataGrid.DataSource = Empl_Des.Employee_Description_View_Spical_three();
                Employee_Description_dataGrid.Columns[0].Visible = false;
                Employee_Description_dataGrid.Columns[12].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LOG.LOGS_add(Program.USER_ID, "حذف", "حذف وصف وظيفي للعاملين", DateTime.Now);
                Employee_Description_delete.Enabled = false;
            }
        }

        private void Employee_Description_dataGrid_Click(object sender, EventArgs e)
        {
            if (Employee_Description_dataGrid.CurrentRow != null)
            {
                Program.Employee_Description_id = Convert.ToInt32(this.Employee_Description_dataGrid.CurrentRow.Cells[0].Value.ToString());
                Program.Employee_id= Convert.ToInt32(this.Employee_Description_dataGrid.CurrentRow.Cells[12].Value.ToString());
                Employee_Description_delete.Enabled = true;
                Employee_Description_Edit.Enabled = true;
                Employee_Edit_Pers_Info.Enabled = true;
                Employee_Description_History.Enabled = true;
            }
        }

        private void Employee_Description_Comb_Search_SelectedValueChanged(object sender, EventArgs e)
        {
            this.Employee_Description_dataGrid.DataSource = Empl_Des.Employee_Description_Search_Office(Employee_Description_Comb_Search.Text);
            Employee_Description_dataGrid.Columns[0].Visible = false;
            Employee_Description_dataGrid.Columns[12].Visible = false;
        }

        private void Employee_Description_Search_all_TextChanged(object sender, EventArgs e)
        {
            this.Employee_Description_dataGrid.DataSource = Empl_Des.Employee_Description_Search_All(Employee_Description_Search_all.Text);
            Employee_Description_dataGrid.Columns[0].Visible = false;
            Employee_Description_dataGrid.Columns[12].Visible = false;
        }

        private void Employee_Description_Print_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            DataTable DT_REPORT = new DataTable();

            DT_REPORT.Columns.Add("الموظف", typeof(string));
            DT_REPORT.Columns.Add("اسم الام", typeof(string));
            DT_REPORT.Columns.Add("الهيئة", typeof(string));
            DT_REPORT.Columns.Add("المكتب", typeof(string));
            DT_REPORT.Columns.Add("القسم", typeof(string));
            DT_REPORT.Columns.Add("الدور الوظيفي", typeof(string));
            DT_REPORT.Columns.Add("حالة الدور الوظيفي", typeof(string));
            DT_REPORT.Columns.Add("رقم الكتاب", typeof(string));
            DT_REPORT.Columns.Add("الراتب", typeof(string));
            DT_REPORT.Columns.Add("الحالة الوظيفية", typeof(string));
            DT_REPORT.Columns.Add("التاريخ", typeof(string));
            foreach (DataGridViewRow dgv in Employee_Description_dataGrid.Rows)
            {
                DT_REPORT.Rows.Add(dgv.Cells[1].Value.ToString(), dgv.Cells[2].Value.ToString(), dgv.Cells[3].Value.ToString()
                   , dgv.Cells[4].Value.ToString(), dgv.Cells[5].Value.ToString(), dgv.Cells[6].Value.ToString(), dgv.Cells[7].Value.ToString(),
                   dgv.Cells[8].Value.ToString(), dgv.Cells[9].Value.ToString(), dgv.Cells[10].Value.ToString(), dgv.Cells[11].Value.ToString());
            }
            DS.Tables.Add(DT_REPORT);
            DS.WriteXmlSchema("C:\\AraratProgramFiles\\Employee_Description.xml");
            REPT.FRM_Report frm = new REPT.FRM_Report();
            REPT.Crystal_Employee_Description report = new REPT.Crystal_Employee_Description();
            report.Refresh();
            report.SetDataSource(DS);
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
            LOG.LOGS_add(Program.USER_ID, "طباعة", "طباعة الوصف وظيفي المعروض", DateTime.Now);
        }

        private void Employee_Description_N0_Book_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Employee_Description_Salery_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

       

        private void update_Click(object sender, EventArgs e)
        {
            this.Employee_Description_dataGrid.DataSource = Empl_Des.Employee_Description_View_Spical_three();
            Employee_Description_dataGrid.Columns[0].Visible = false;
            Employee_Description_dataGrid.Columns[12].Visible = false;
        }

        private void Employee_Description_Comb_Employee_SelectedValueChanged(object sender, EventArgs e)
        {
            this.Employee_Description_dataGrid.DataSource =
                Employee_Description_Comb_Employee.Text == "الكل" ? Empl_Des.Employee_Description_View()
                : Employee_Description_Comb_Employee.Text == "قيد العمل" ? Empl_Des.Employee_Description_View_Spical_three()
                : Empl_Des.Employee_Description_View_without_Spical_three();
            Employee_Description_dataGrid.Columns[0].Visible = false;
            Employee_Description_dataGrid.Columns[12].Visible = false;
        }

        private void Employee_Edit_Pers_Info_Click(object sender, EventArgs e)
        {
            Employee_Edit_Pers_Info_FORM FRM = new Employee_Edit_Pers_Info_FORM(Program.Employee_Description_id);
            FRM.ShowDialog();
            this.Employee_Description_dataGrid.DataSource =
                 Employee_Description_Comb_Employee.Text == "الكل" ? Empl_Des.Employee_Description_View()
                 : Employee_Description_Comb_Employee.Text == "قيد العمل" ? Empl_Des.Employee_Description_View_Spical_three()
                 : Empl_Des.Employee_Description_View_without_Spical_three();
            Employee_Description_dataGrid.Columns[0].Visible = false;
            Employee_Description_dataGrid.Columns[12].Visible = false;
        }

        private void Employee_add_Click(object sender, EventArgs e)
        {
            Employee_FORM FRM = new Employee_FORM(-1);
            FRM.ShowDialog();
        }

        private void Employee_Description_Edit_Click(object sender, EventArgs e)
        {
            Employee_FORM FRM = new Employee_FORM(Program.Employee_Description_id);
            FRM.ShowDialog();
            this.Employee_Description_dataGrid.DataSource = Empl_Des.Employee_Description_View_Spical_three();
            Employee_Description_dataGrid.Columns[0].Visible = false;
            Employee_Description_dataGrid.Columns[12].Visible = false;
        }

        private void Employee_Description_History_Click(object sender, EventArgs e)
        {
            Employee_History_FORM FRM = new Employee_History_FORM(Program.Employee_id);
            FRM.ShowDialog();
        }
    }
}
