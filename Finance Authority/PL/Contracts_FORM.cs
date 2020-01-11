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
    public partial class Contracts_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Employee_Description Empl_Des = new BL.CLS_Employee_Description();
        BL.CLS_Contracts cont = new BL.CLS_Contracts();
        BL.CLS_LOGS LOG = new BL.CLS_LOGS();
        int _Contract_id;
        public Contracts_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            this.Contracts_Gridview.DataSource = cont.Contracts_View();
            Contracts_Gridview.Columns[0].Visible = false;
            Contracts_Gridview.Columns[7].Visible = false;
        }
        private void Contracts_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Contracts_Gridview_Click(object sender, EventArgs e)
        {
            if (Contracts_Gridview.CurrentRow != null)
            {
                Program.Employee_Description_id= Convert.ToInt32(this.Contracts_Gridview.CurrentRow.Cells[7].Value.ToString());
                _Contract_id= Convert.ToInt32(this.Contracts_Gridview.CurrentRow.Cells[0].Value.ToString());
                Contracts_Type.Text = this.Contracts_Gridview.CurrentRow.Cells[1].Value.ToString();
                Contracts_Date_Start.Text = this.Contracts_Gridview.CurrentRow.Cells[2].Value.ToString();
                Contracts_Date_end.Text = this.Contracts_Gridview.CurrentRow.Cells[3].Value.ToString();
                Contracts_Employee.Text = this.Contracts_Gridview.CurrentRow.Cells[6].Value.ToString();
                Contracts_Notes.Text = this.Contracts_Gridview.CurrentRow.Cells[5].Value.ToString();
                Contracts_Comb_Contract_statue.Text= this.Contracts_Gridview.CurrentRow.Cells[4].Value.ToString();
                //Contracts_end.Checked = Convert.ToBoolean(this.Contracts_Gridview.CurrentRow.Cells[4].Value) ? true : false;
                //Contracts_Not_end.Checked = Contracts_end.Checked ? false : true;
                Contracts_Details.Enabled = true;
                Contracts_Brows_Docs.Enabled = true;
            }
        }
        private void Contracts_Search_All_TextChanged(object sender, EventArgs e)
        {
            this.Contracts_Gridview.DataSource = cont.Contracts_Search_All(Contracts_Search_All.Text);
            Contracts_Gridview.Columns[0].Visible = false;
            Contracts_Gridview.Columns[7].Visible = false;
        }

        private void Contracts_Date_first_ValueChanged(object sender, EventArgs e)
        {
            this.Contracts_Gridview.DataSource = cont.Contracts_Search_Between_Date(Contracts_Date_first.Value , Contracts_Date_last.Value);
            Contracts_Gridview.Columns[0].Visible = false;
            Contracts_Gridview.Columns[7].Visible = false;
        }
        private void Contracts_Date_last_ValueChanged(object sender, EventArgs e)
        {
            this.Contracts_Gridview.DataSource = cont.Contracts_Search_Between_Date(Contracts_Date_first.Value, Contracts_Date_last.Value);
            Contracts_Gridview.Columns[0].Visible = false;
            Contracts_Gridview.Columns[7].Visible = false;
        }
        private void Contracts_Print_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            DataTable DT_REPORT = new DataTable();
            DT_REPORT.Columns.Add("نوع العقد", typeof(string));
            DT_REPORT.Columns.Add("بداية العقد", typeof(string));
            DT_REPORT.Columns.Add("نهاية العقد", typeof(string));
            DT_REPORT.Columns.Add("حالة العقد", typeof(string));
            DT_REPORT.Columns.Add("الملاحظات", typeof(string));
            DT_REPORT.Columns.Add("الموظف", typeof(string));
            foreach (DataGridViewRow dgv in Contracts_Gridview.Rows)
            {
                DT_REPORT.Rows.Add(dgv.Cells[1].Value, Convert.ToDateTime(dgv.Cells[2].Value).ToShortDateString(), Convert.ToDateTime(dgv.Cells[3].Value).ToShortDateString()
                   , dgv.Cells[4].Value, dgv.Cells[5].Value, dgv.Cells[6].Value);
            }
            DS.Tables.Add(DT_REPORT);
            DS.WriteXmlSchema("C:\\AraratProgramFiles\\Contract.xml");
            REPT.FRM_Report frm = new REPT.FRM_Report();
            REPT.Crystal_Contract report = new REPT.Crystal_Contract();
            report.Refresh();
            report.SetDataSource(DS);
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
            LOG.LOGS_add(Program.USER_ID, "طباعة", "طباعة العقود", DateTime.Now);
            //REPT.Crystal_Contracts Art = new REPT.Crystal_Contracts();
            //REPT.FRM_Report FRPT = new REPT.FRM_Report();
            //if (Contracts_Gridview.Rows.Count != 0)
            //{
            //    // DataTable dt = dataGrid_Ringall.DataSource;
            //    Art.SetDataSource(Contracts_Gridview.DataSource);
            //    FRPT.crystalReportViewer1.ReportSource = Art;
            //    FRPT.ShowDialog();
            //}
        }
        private void Contracts_Details_Click(object sender, EventArgs e)
        {
            if (Contracts_Gridview.CurrentRow == null)
            {
                Contracts_Details.Enabled = false;
            }
            else
            {
                Employee_FORM FRM = new Employee_FORM(Program.Employee_Description_id);
                FRM.ShowDialog();
            }
        }
        private void Contracts_Brows_Docs_Click(object sender, EventArgs e)
        {
            Document_FORM FRM = new Document_FORM(Program.Employee_Description_id, "عقد");
            FRM.ShowDialog();
        }

        private void Contracts_update_Click(object sender, EventArgs e)
        {
            if (Contracts_Type.SelectedIndex==-1)
            {
                MessageBox.Show("يجب اختيار نوع العقد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // لاداعي له كون غير مسموح تغيير حالة العقد 
            //if (Contracts_Type.SelectedIndex == -1)
            //{
            //    MessageBox.Show("يجب اختيار حالة العقد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}
            cont.Contracts_update(Contracts_Type.Text, Contracts_Date_Start.Value, Contracts_Date_end.Value, Contracts_Comb_Contract_statue.Text
                     , Contracts_Notes.Text, Program.Employee_Description_id, _Contract_id);
                this.Contracts_Gridview.DataSource = cont.Contracts_View();
                Contracts_Gridview.Columns[0].Visible = false;
                Program.Update_Message();
                Contracts_Type.Text = "";
                Contracts_Notes.Text = "";
           
        }
    }
}
