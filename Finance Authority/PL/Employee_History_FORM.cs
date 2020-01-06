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
    public partial class Employee_History_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Employee_Description Empl_Des = new BL.CLS_Employee_Description();
        BL.CLS_LOGS LOG = new BL.CLS_LOGS();

        int _Employee_ID;
        int _Last_Description;
        public Employee_History_FORM(int Employee_ID)
        {
            InitializeComponent();
            _Employee_ID = Employee_ID;
            this.StyleManager = Program.theme_style(this);
            DataTable dt = Empl_Des.Employee_Description_View_History_Emp(_Employee_ID);
            this.Employee_History_DGV.DataSource = dt;
            Employee_History_DGV.Columns[0].Visible = false;
            Employee_History_DGV.Columns[12].Visible = false;
            _Last_Description =Convert.ToInt32(dt.Rows[0][0]);
        }

        private void Employee_Edit_Last_Description_Click(object sender, EventArgs e)
        {
            Employee_Last_Desc_FORM FRM = new Employee_Last_Desc_FORM(_Last_Description);
            FRM.ShowDialog();
            this.Employee_History_DGV.DataSource = Empl_Des.Employee_Description_View_History_Emp(_Employee_ID);
            Employee_History_DGV.Columns[0].Visible = false;
            Employee_History_DGV.Columns[12].Visible = false;
        }

        private void Employee_History_Print_Click(object sender, EventArgs e)
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
            foreach (DataGridViewRow dgv in Employee_History_DGV.Rows)
            {
                DT_REPORT.Rows.Add(dgv.Cells[1].Value.ToString(), dgv.Cells[2].Value.ToString(),dgv.Cells[3].Value.ToString()
                   , dgv.Cells[4].Value.ToString(), dgv.Cells[5].Value.ToString(), dgv.Cells[6].Value.ToString(), dgv.Cells[7].Value.ToString(),
                   dgv.Cells[8].Value.ToString(), dgv.Cells[9].Value.ToString(), dgv.Cells[10].Value.ToString(), dgv.Cells[11].Value.ToString());
            }
            DS.Tables.Add(DT_REPORT);
            DS.WriteXmlSchema("C:\\AraratProgramFiles\\Employee_History.xml");
            REPT.FRM_Report frm = new REPT.FRM_Report();
            REPT.Crystal_Employee_History report = new REPT.Crystal_Employee_History();
            report.Refresh();
            report.SetDataSource(DS);
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
            LOG.LOGS_add(Program.USER_ID, "طباعة", "طباعة الحركة الوظيفية لعامل", DateTime.Now);
        }

        private void Employee_Description_Return_Click(object sender, EventArgs e)
        {
            Employee_Return_Job FRM = new Employee_Return_Job(Program.Employee_Description_id);
            FRM.ShowDialog();
        }

        private void Employee_History_DGV_Click(object sender, EventArgs e)
        {
            if (Employee_History_DGV.CurrentRow != null)
            {
                string Role = Employee_History_DGV.CurrentRow.Cells[10].Value.ToString();
                if (Role != "عقد" && Role != "مثبت" && Role != "مندوب" && (bool)Employee_History_DGV.CurrentRow.Cells[7].Value == true)
                { // يتفعل في حال كان اخر تسجيلة للعامل خارج العمل
                    Program.Employee_Description_id = Convert.ToInt32(this.Employee_History_DGV.CurrentRow.Cells[0].Value.ToString());
                    Employee_Description_Return.Enabled = true;
                }
                else { Employee_Description_Return.Enabled = false; }
            }
        }
    }
}
