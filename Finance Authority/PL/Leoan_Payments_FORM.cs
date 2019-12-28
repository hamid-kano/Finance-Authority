using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Finance_Authority.PL
{
    public partial class Leoan_Payments_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Loan Loa = new BL.CLS_Loan();
        BL.CLS_Employee_Description Empl_Des = new BL.CLS_Employee_Description();
        BL.CLS_Coin_Exchange Coin = new BL.CLS_Coin_Exchange();
        BL.CLS_Contracts cont = new BL.CLS_Contracts();
        BL.CLS_Leoan_Payments pay_Leo = new BL.CLS_Leoan_Payments();
        BL.CLS_Budget Bud = new BL.CLS_Budget();
        BL.Authority Auth = new BL.Authority();
        BL.Department Dep = new BL.Department();
        BL.CLS_Reciver_Document reciver_Document = new BL.CLS_Reciver_Document();
        BL.CLS_Budget budget = new BL.CLS_Budget();
        BL.CLS_Operations ope = new BL.CLS_Operations();
        DataTable Dt = new DataTable();
        double sum;
        double sumtotal;
        BL.CLS_LOGS LOG = new BL.CLS_LOGS();
        int _Loan_id;
        public Leoan_Payments_FORM(int Loan_id)
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            Leoan_Payments_CombSerach.DataSource = Coin.Coin_Exchange_CombBudg();
            Leoan_Payments_CombSerach.DisplayMember = "Date";
            Leoan_Payments_CombSerach.ValueMember = "Budget_Id";
            Leoan_Payments_Comb_Budget.DataSource = Bud.Budget_combo_Last_Budget();
            Leoan_Payments_Comb_Budget.DisplayMember = "Date";
            Leoan_Payments_Comb_Budget.ValueMember = "Budget_Id";
            _Loan_id = Loan_id;
            if (_Loan_id == -1)
            {
                this.Leoan_Payments_Gridview.DataSource = pay_Leo.Leoan_Payments_View_all();
                Leoan_Payments_Gridview.Columns[0].Visible = false;
                Leoan_Payments_add.Enabled = false;
                Leoan_Payments_new.Enabled = false;
            }
            else
            {
                this.Leoan_Payments_Gridview.DataSource = pay_Leo.Leoan_Payments_View(Program.Loan_id);
                Leoan_Payments_Gridview.Columns[0].Visible = false;
                Dt = pay_Leo.Leoan_Payments_View(Program.Loan_id);
                for (int i = 0; i < Dt.Rows.Count; i++)
                {
                    sum = sum + Convert.ToDouble(Dt.Rows[i][1]);
                }
            }
        }
       private void Leoan_Payments_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Leoan_Payments_new_Click(object sender, EventArgs e)
        {
            Leoan_Payments_add.Enabled = true;
            Leoan_Payments_Amont.Text = "";
            Leoan_Payments_Notes.Text = "";
            Reciver_Document_no.Text = "";
            Leoan_Payments_update.Enabled = false;
            Leoan_Payments_delete.Enabled = false;
            Loans_Payments_Brows_Docs.Enabled = false;
        }

       

        private void Leoan_Payments_add_Click(object sender, EventArgs e)
        {
            if (Leoan_Payments_Amont.Text == String.Empty)
            {

                MessageBox.Show("ادخل المبلغ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Reciver_Document_no.Text == String.Empty)
            {
                MessageBox.Show("أضف رقم السند", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable dt3;
            if ((dt3 = reciver_Document.Reciver_Document_Cheack(Reciver_Document_no.Text)).Rows.Count != 0)
            {
                    MessageBox.Show("رقم سند القبض موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }
            if (Convert.ToInt32( Leoan_Payments_Amont.Text )> Convert.ToInt32(Leoan_Payments_Total.Text))
            {
                MessageBox.Show("مبلغ الدفعة هو اكبر من مبلغ القرض المتبقي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            pay_Leo.Leoan_Payments_add(Program.Loan_id,Leoan_Payments_Amont.Text, Leoan_Payments_Notes.Text , Leoan_Payments_Date.Value , Convert.ToInt32(Leoan_Payments_Comb_Budget.SelectedValue));
                this.Leoan_Payments_Gridview.DataSource = pay_Leo.Leoan_Payments_View(Program.Loan_id);
                Leoan_Payments_Gridview.Columns[0].Visible = false;
                int Max_loan_Payment_id =Convert.ToInt32(pay_Leo.Leoan_Payments_MAX_id().Rows[0][0]);
                /// اضافة ملحقات لدفعة القرض
                if (MessageBox.Show("هل تريد اضافة ملحقات لدفعة القرض هذا؟", "ملحقات", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Document_FORM FRM = new Document_FORM(Max_loan_Payment_id, "دفعة قرض");
                    FRM.ShowDialog();
                }
            ////
            //// اضافة سند استلام وضع العملية في جدول العمليات وتحيث الميزانية
            int Loan_MAX_ID =Convert.ToInt16(pay_Leo.Leoan_Payments_MAX_id().Rows[0][0]);
            reciver_Document.Reciver_Document_add(Leoan_Payments_Amont.Text, "0", "0", Reciver_Document_no.Text,
                             "دفعة قرض", "العاملين", DateTime.Now, "لايوجد", Convert.ToInt32(budget.Budget_Last_Budget().Rows[0][0]), 1010);
            ope.Operations_Bill_Salary_LoanPay_add(Convert.ToInt32(reciver_Document.Reciver_Document_Max_ID().Rows[0][0]), Loan_MAX_ID, "دفعة قرض");
            // تحديث الميزانية
            Program.Budget_update_after_Payment_Reciver("R", Leoan_Payments_Amont.Text, "0");
            //
            Program.Add_Message();
            LOG.LOGS_add(Program.USER_ID, "اضافة", "اضافة دفعة قرض جديدة", DateTime.Now);
            Leoan_Payments_Amont.Text = "";
                Leoan_Payments_Notes.Text = "";
            Reciver_Document_no.Text = "";
            Leoan_Payments_update.Enabled = false;
                Leoan_Payments_delete.Enabled = false;
                Loans_Payments_Brows_Docs.Enabled = false;

            //}
            update_loean_pay();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Leoan_Payments_update_Click(object sender, EventArgs e)
        {
            if (Leoan_Payments_Amont.Text == String.Empty)
            {

                MessageBox.Show("ادخل المبلغ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Reciver_Document_no.Text == String.Empty)
            {
                MessageBox.Show("اضف رقم السند", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable dt3;
            if ((dt3=reciver_Document.Reciver_Document_Cheack(Reciver_Document_no.Text)).Rows.Count!=0)
            {
                if (Convert.ToInt32(dt3.Rows[0][0])!= Program.Reciver_Document_id)
                {
                    MessageBox.Show("رقم سند القبض موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (Convert.ToInt32(Leoan_Payments_Amont.Text) > Convert.ToInt32(Leoan_Payments_Total.Text))
            {
                MessageBox.Show("مبلغ الدفعة هو اكبر من مبلغ القرض المتبقي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            pay_Leo.Leoan_Payments_update(Program.Loan_id, Leoan_Payments_Amont.Text, Leoan_Payments_Notes.Text, Leoan_Payments_Date.Value, Convert.ToInt32(Leoan_Payments_Comb_Budget.SelectedValue), Program.Leoan_Payments_id);
            DataTable dt;
            if ((dt= ope.Operations_Bill_Salary_LoanPay_Viewby_towID(Program.Leoan_Payments_id, "دفعة قرض")).Rows.Count!=0)
            {
                ////  
                int id_Pay = Convert.ToInt32(dt.Rows[0][0]);
                DataTable dt2;
                if ((dt2= reciver_Document.Reciver_Document_Search_by_id(id_Pay)).Rows.Count!=0)
                {
                    double PrivSy = Convert.ToDouble(dt2.Rows[0][1]);
                    double PrivDo = Convert.ToDouble(dt2.Rows[0][2]);
                    // تحديث الميزانية
                    Program.Budget_update_after_Payment_Reciver("P", PrivSy.ToString(), PrivDo.ToString());
                }   
                Program.Budget_update_after_Payment_Reciver("R", Leoan_Payments_Amont.Text == string.Empty ? "0" : Leoan_Payments_Amont.Text, "0");
                //
                reciver_Document.Reciver_Document_update(Leoan_Payments_Amont.Text, "0", "0", Reciver_Document_no.Text
                    , "دفعة قرض", "العاملين", DateTime.Now, "لايوجد", Convert.ToInt32(budget.Budget_Last_Budget().Rows[0][0]), 1010, id_Pay);
                ///
            }     
            this.Leoan_Payments_Gridview.DataSource = pay_Leo.Leoan_Payments_View(Program.Loan_id);
                Leoan_Payments_Gridview.Columns[0].Visible = false;
                Program.Update_Message();
            LOG.LOGS_add(Program.USER_ID, "تعديل", "تعديل دفعة قرض", DateTime.Now);
            Leoan_Payments_Amont.Text = "";
                Leoan_Payments_Notes.Text = "";
            Reciver_Document_no.Text = "";
            Leoan_Payments_update.Enabled = false;
                Leoan_Payments_delete.Enabled = false;
                Loans_Payments_Brows_Docs.Enabled = false;
            update_loean_pay();
        }

        private void Leoan_Payments_Gridview_Click(object sender, EventArgs e)
        {
            if (Leoan_Payments_Gridview.CurrentRow != null)
            {
                Program.Leoan_Payments_id = Convert.ToInt32(this.Leoan_Payments_Gridview.CurrentRow.Cells[0].Value.ToString());
               
                    DataTable Dt2;
                    if ((Dt2 = ope.Operations_Bill_Salary_LoanPay_Viewby_towID(Program.Leoan_Payments_id, "دفعة قرض")).Rows.Count!=0)
                    {
                        int id_Rec_Doc = (int)Dt2.Rows[0][0];
                       Program.Reciver_Document_id = id_Rec_Doc;
                       DataTable Dt = new DataTable();
                        if ((Dt = reciver_Document.Reciver_Document_Search_by_id(id_Rec_Doc)).Rows.Count != 0)
                        {
                            Reciver_Document_no.Text = Dt.Rows[0][4].ToString();
                        }

                    }      
            
                Leoan_Payments_Amont.Text = this.Leoan_Payments_Gridview.CurrentRow.Cells[1].Value.ToString();
                Leoan_Payments_Notes.Text = this.Leoan_Payments_Gridview.CurrentRow.Cells[2].Value.ToString();
                Leoan_Payments_Date.Text = this.Leoan_Payments_Gridview.CurrentRow.Cells[3].Value.ToString();
                Leoan_Payments_Comb_Budget.Text = this.Leoan_Payments_Gridview.CurrentRow.Cells[4].Value.ToString();

                if (Leoan_Payments_new.Enabled)
                {
                    Leoan_Payments_update.Enabled = true;
                    Leoan_Payments_delete.Enabled = true;
                    Leoan_Payments_add.Enabled = false;
                }
                Loans_Payments_Brows_Docs.Enabled = true;
            }
        }

        private void Leoan_Payments_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف دفعة القرض .اذا تم الحذف فسيتم حذف كافة تفاصيلها من البرنامج؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pay_Leo.Leoan_Payments_Delete(Program.Leoan_Payments_id);
                //delete Payment Doc -- Delete row Operation -- update Budget
                // يحذف سند القبض الخاص بها اذا كان لها سند قبض
                DataTable dt;
                if ((dt= ope.Operations_Bill_Salary_LoanPay_Viewby_towID(Program.Leoan_Payments_id, "دفعة قرض")).Rows.Count!=0)
                {
                    int Reciver_id_for_this_Leoan_Payments = Convert.ToInt32(dt.Rows[0][0]);
                    // تحديث الميزانية
                    DataTable Dt2;
                    if ((Dt2= reciver_Document.Reciver_Document_Search_by_id(Reciver_id_for_this_Leoan_Payments)).Rows.Count!=0)
                    {
                        Program.Budget_update_after_Payment_Reciver("P", Dt2.Rows[0][1].ToString(), Dt2.Rows[0][2].ToString());
                        //
                    }
                    reciver_Document.Reciver_Document_Delete(Reciver_id_for_this_Leoan_Payments);
                    ope.Operations_Bill_Salary_LoanPay_Delete(Reciver_id_for_this_Leoan_Payments, Program.Leoan_Payments_id, "دفعة قرض");
                        //
                }
                this.Leoan_Payments_Gridview.DataSource = pay_Leo.Leoan_Payments_View(Program.Loan_id);
                Leoan_Payments_Gridview.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LOG.LOGS_add(Program.USER_ID, "حذف", "حذف دفعة قرض", DateTime.Now);
                Leoan_Payments_Amont.Text = "";
                Reciver_Document_no.Text = "";
                Leoan_Payments_Notes.Text = "";
                Leoan_Payments_update.Enabled = false;
                Leoan_Payments_delete.Enabled = false;
                Loans_Payments_Brows_Docs.Enabled = false;
                update_loean_pay();
            }
        }

        private void Leoan_Payments_Search_All_TextChanged(object sender, EventArgs e)
        {
            this.Leoan_Payments_Gridview.DataSource = pay_Leo.Leoan_Payments_Search_All(Leoan_Payments_Search_All.Text);
            Leoan_Payments_Gridview.Columns[0].Visible = false;
        }

        private void Leoan_Payments_CombSerach_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_Loan_id!=-1)
                {
                    this.Leoan_Payments_Gridview.DataSource = pay_Leo.Leoan_Payments_Budget_Date(Convert.ToInt32(Leoan_Payments_CombSerach.SelectedValue), _Loan_id);
                    Leoan_Payments_Gridview.Columns[0].Visible = false;
                }
                else
                {
                    this.Leoan_Payments_Gridview.DataSource = pay_Leo.Leoan_Payments_Budget_Date_All_Loans(Convert.ToInt32(Leoan_Payments_CombSerach.SelectedValue));
                    Leoan_Payments_Gridview.Columns[0].Visible = false;
                }
            }
            catch { return; }
        }

        private void Leoan_Payments_Print_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            DataTable DT_REPORT = new DataTable();

            DT_REPORT.Columns.Add("المبلغ", typeof(string));
            DT_REPORT.Columns.Add("الملاحظات", typeof(string));
            DT_REPORT.Columns.Add("تاريخ الدفع", typeof(string));
            DT_REPORT.Columns.Add("الميزانية", typeof(string));
            DT_REPORT.Columns.Add("الموظف", typeof(string));
            DT_REPORT.Columns.Add("القسم", typeof(string));
            DT_REPORT.Columns.Add("تاريخ القرض", typeof(string));

            foreach (DataGridViewRow dgv in Leoan_Payments_Gridview.Rows)
            {
                DT_REPORT.Rows.Add(dgv.Cells[1].Value, dgv.Cells[2].Value, Convert.ToDateTime(dgv.Cells[3].Value).ToShortDateString()
                   , Convert.ToDateTime(dgv.Cells[4].Value).ToShortDateString(),
                  dgv.Cells[5].Value, dgv.Cells[6].Value,  Convert.ToDateTime(dgv.Cells[7].Value).ToShortDateString());
            }
            DS.Tables.Add(DT_REPORT);
            DS.WriteXmlSchema("C:\\AraratProgramFiles\\Leoan_Payments.xml");

            REPT.FRM_Report frm = new REPT.FRM_Report();
            REPT.Crystal_Leoan_Payments report = new REPT.Crystal_Leoan_Payments();
            report.Refresh();
            report.SetDataSource(DS);
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
            LOG.LOGS_add(Program.USER_ID, "طباعة", "طباعة دفعات القروض المعروضة", DateTime.Now);
        }

        private void Leoan_Payments_Amont_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void update_Click(object sender, EventArgs e)
        {
            this.Leoan_Payments_Gridview.DataSource = pay_Leo.Leoan_Payments_View(Program.Loan_id);
            Leoan_Payments_Gridview.Columns[0].Visible = false;
        }

        private void Leoan_Payments_FORM_Load(object sender, EventArgs e)
        {
            if (_Loan_id!=-1)
            {
                Leoan_Payments_Total_Payment_Amount.Text = sum.ToString();
                sumtotal = Convert.ToDouble(Leoan_Payments_Total.Text);
                sumtotal = sumtotal - sum;
                Leoan_Payments_Remind_Amont.Text = sumtotal.ToString();
            }   
        }

        private void Loans_Payments_Brows_Docs_Click(object sender, EventArgs e)
        {
            Document_FORM FRM = new Document_FORM(Program.Leoan_Payments_id, "دفعة قرض");
            FRM.ShowDialog();
        }

        private void Reciver_Document_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }
        private void update_loean_pay()
        {

            if (_Loan_id != -1)
            {
                Dt = pay_Leo.Leoan_Payments_View(Program.Loan_id);
                for (int i = 0; i < Dt.Rows.Count; i++)
                {
                    sum = sum + Convert.ToDouble(Dt.Rows[i][1]);
                }
                Leoan_Payments_Total_Payment_Amount.Text = sum.ToString();
                sumtotal = Convert.ToDouble(Leoan_Payments_Total.Text);
                sumtotal = sumtotal - sum;
                Leoan_Payments_Remind_Amont.Text = sumtotal.ToString();
            }
        }
    }
}
