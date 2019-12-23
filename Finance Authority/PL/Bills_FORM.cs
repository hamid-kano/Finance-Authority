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
    public partial class Bills_FORM : MetroFramework.Forms.MetroForm 
    { 
        BL.CLS_Bills bill = new BL.CLS_Bills();
        BL.CLS_Bills_Details bill_details = new BL.CLS_Bills_Details();
        BL.CLS_Payment_Document Pay = new BL.CLS_Payment_Document();
        BL.CLS_Operations ope = new BL.CLS_Operations();
        private static Bills_FORM frm;
        BL.CLS_LOGS LOG = new BL.CLS_LOGS();
        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static Bills_FORM getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Bills_FORM();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
                }
                return frm;
            }
        }
        public Bills_FORM()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            Bills_dataGrid.DataSource = bill.Bills_View();
            this.Bills_dataGrid.Columns[0].Visible = false;

        }

        private void Bills_dataGrid_Click(object sender, EventArgs e)
        {
            if(Bills_dataGrid.CurrentRow!=null)
            {
                Bills_Details.Enabled = true;
                Bills_delete.Enabled = true;
                Program.Bill_Id = Convert.ToInt32(Bills_dataGrid.CurrentRow.Cells[0].Value);
            }
        }

        private void Bills_add_Click(object sender, EventArgs e)
        {
            PL.Bills_Details_FORM FRM = new Bills_Details_FORM(-1);
            FRM.ShowDialog();
        }

        private void Bills_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bills_Details_Click(object sender, EventArgs e)
        {
            if (Bills_dataGrid.CurrentRow != null)
            {
                int Bill_Id =Convert.ToInt32(Bills_dataGrid.CurrentRow.Cells[0].Value);
                PL.Bills_Details_FORM FRM = new Bills_Details_FORM(Bill_Id);
                FRM.ShowDialog();
            }
        }
        private void Bills_delete_Click(object sender, EventArgs e)
        {
            if (Bills_dataGrid.CurrentRow != null)
                if (MessageBox.Show("هل تريد حذف الفاتورة .اذا تم الحذف فسيتم حذف كافة تفاصيلها من البرنامج؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                bill_details.Bills_Details_Delete(Convert.ToInt32(Bills_dataGrid.CurrentRow.Cells[0].Value));
                    // حذف سند الدفع المرتبط بهذه الفاتورة
                    if (ope.Operations_Bill_Salary_LoanPay_Viewby_towID(Program.Bill_Id, true).Rows.Count != 0)
                    {
                        int Payement_id_for_this_Bill = Convert.ToInt32(ope.Operations_Bill_Salary_LoanPay_Viewby_towID(Program.Bill_Id, true).Rows[0][0]);
                        // تحديث الميزانية
                        Program.Budget_update_after_Payment_Reciver("delete", "p", Pay.Payment_Document_Search_by_id(Payement_id_for_this_Bill).Rows[0][1].ToString(), Pay.Payment_Document_Search_by_id(Payement_id_for_this_Bill).Rows[0][2].ToString());
                        //
                        Pay.Payment_Document_Delete(Payement_id_for_this_Bill);
                        ope.Operations_Bill_Salary_LoanPay_Delete(Payement_id_for_this_Bill, Program.Bill_Id, true);
                    }
                    Program.Delete_Message();
                    LOG.LOGS_add(Program.USER_ID, "حذف", "حذف فاتورة مع محتوياتها", DateTime.Now);
                    Bills_dataGrid.DataSource = bill.Bills_View();
                this.Bills_dataGrid.Columns[0].Visible = false;

                }
        }

        private void Bills_Search_All_TextChanged(object sender, EventArgs e)
        {
            Bills_dataGrid.DataSource = bill.Bills_Search_All(Bills_Search_All.Text);
            this.Bills_dataGrid.Columns[0].Visible = false;
        }

        private void Bills_Date_first_ValueChanged(object sender, EventArgs e)
        {
            Bills_dataGrid.DataSource = bill.Bills_Search_Between_Date(Bills_Date_first.Value , Bills_Date_last.Value);
            this.Bills_dataGrid.Columns[0].Visible = false;
        }

        private void Bills_Date_last_ValueChanged(object sender, EventArgs e)
        {
            Bills_dataGrid.DataSource = bill.Bills_Search_Between_Date(Bills_Date_first.Value, Bills_Date_last.Value);
            this.Bills_dataGrid.Columns[0].Visible = false;
        }

        private void Bills_Print_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            DataTable DT_REPORT = new DataTable();

            DT_REPORT.Columns.Add("رقم الفاتورة", typeof(string));
            DT_REPORT.Columns.Add("البائع", typeof(string));
            DT_REPORT.Columns.Add("العملة", typeof(string));
            DT_REPORT.Columns.Add("قيمة التحويل", typeof(string));
            DT_REPORT.Columns.Add("نوع الفاتورة", typeof(string));
            DT_REPORT.Columns.Add("الاجمالي", typeof(string));
            DT_REPORT.Columns.Add("تاريخ الفاتورة", typeof(string));
            DT_REPORT.Columns.Add("حالة الدفع", typeof(string));
            DT_REPORT.Columns.Add("الملاحظات", typeof(string));
            DT_REPORT.Columns.Add("الميزانية", typeof(string));
            DT_REPORT.Columns.Add("القسم", typeof(string));
            foreach (DataGridViewRow dgv in Bills_dataGrid.Rows)
            {
                DT_REPORT.Rows.Add(dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value
                   , dgv.Cells[4].Value,dgv.Cells[5].Value, dgv.Cells[6].Value, Convert.ToDateTime(dgv.Cells[7].Value).ToShortDateString(),
                  dgv.Cells[8].Value
                  , dgv.Cells[9].Value, Convert.ToDateTime(dgv.Cells[10].Value).ToShortDateString(), dgv.Cells[11].Value);
            }
            DS.Tables.Add(DT_REPORT);
            DS.WriteXmlSchema("C:\\AraratProgramFiles\\Bills.xml");

            REPT.FRM_Report frm = new REPT.FRM_Report();
            REPT.Crystal_Bills report = new REPT.Crystal_Bills();
            report.Refresh();
            report.SetDataSource(DS);
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
            LOG.LOGS_add(Program.USER_ID, "طباعة", "طباعة فواتير", DateTime.Now);
        }

        private void update_Click(object sender, EventArgs e)
        {
            Bills_dataGrid.DataSource = bill.Bills_View();
            this.Bills_dataGrid.Columns[0].Visible = false;
            Bills_Date_first.Value = DateTime.Now.Date;
            Bills_Date_last.Value = DateTime.Now.Date;
        }
    }
}
