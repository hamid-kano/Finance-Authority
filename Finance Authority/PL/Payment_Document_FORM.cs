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
    public partial class Payment_Document_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Coin_Exchange Coin = new BL.CLS_Coin_Exchange();
        BL.CLS_Reciver_Document Reciv = new BL.CLS_Reciver_Document();
        BL.CLS_Payment_Document pay = new BL.CLS_Payment_Document();
        Finance_Authority frm = Finance_Authority.getMainForm;
        BL.CLS_Budget Bud = new BL.CLS_Budget();
        DataTable Dt = new DataTable();
        BL.CLS_Operations ope = new BL.CLS_Operations();
        BL.CLS_LOGS LOG = new BL.CLS_LOGS();
        BL.CLS_Bills_Details bill_details = new BL.CLS_Bills_Details();
        BL.CLS_Employee_Salaries emp_Sal = new BL.CLS_Employee_Salaries();
        BL.CLS_Emission_Salaries emission = new BL.CLS_Emission_Salaries();
        BL.CLS_Loan loan = new BL.CLS_Loan();
        BL.CLS_Leoan_Payments leoan_Payments = new BL.CLS_Leoan_Payments();
        BL.CLS_Reciver_Document reciver_Document = new BL.CLS_Reciver_Document();
        int indexRowDeleted_or_Updated;
        public Payment_Document_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            this.Payment_Document_dataGrid.DataSource = pay.Payment_Document_View();
            this.Payment_Document_dataGrid.Columns[0].Visible = false;
            Payment_Document_Comb_Date.DataSource = Bud.Budget_combo_Last_Budget();
            Payment_Document_Comb_Date.DisplayMember = "Date";
            Payment_Document_Comb_Date.ValueMember = "Budget_Id";
            
            Payment_Document_Comb_Cate.DataSource = Reciv.Reciver_Document_Comb_Cate();
            Payment_Document_Comb_Cate.DisplayMember = "Document_Type";
            Payment_Document_Comb_Cate.ValueMember = "Category_id";
        }

        private void Payment_Document_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Payment_Document_new_Click(object sender, EventArgs e)
        {
            Payment_Document_add.Enabled = true;
            Payment_Document_sy.Text = "";
            Payment_Document_Dollar.Text = "";
            Payment_Document_rate.Text = "";
            Payment_Document_no.Text = "";
            Payment_Document_No_Order.Text = "";
            Payment_Document_Reason.Text = "";
            Payment_Document_Receve.Text = "";
            Payment_Document_Notes.Text = "";
            Payment_Document_update.Enabled = false;
            Payment_Document_delete.Enabled = false;
            Payment_Document_Brows_Docs.Enabled = false;
        }

        private void Payment_Document_dataGrid_Click(object sender, EventArgs e)
        {
            if (Payment_Document_dataGrid.CurrentRow != null)
            {
                indexRowDeleted_or_Updated = Convert.ToInt32(this.Payment_Document_dataGrid.CurrentRow.Index);
                Program.Payment_Document_id = Convert.ToInt32(this.Payment_Document_dataGrid.CurrentRow.Cells[0].Value.ToString());
                Payment_Document_sy.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[1].Value.ToString();
                Payment_Document_Dollar.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[2].Value.ToString();
                Payment_Document_rate.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[3].Value.ToString();
                Payment_Document_no.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[4].Value.ToString();
                Payment_Document_No_Order.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[5].Value.ToString();
                Payment_Document_Reason.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[6].Value.ToString();
                Payment_Document_Receve.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[7].Value.ToString();
                Payment_Document_DateTime.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[8].Value.ToString();
                Payment_Document_Notes.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[9].Value.ToString();
                Payment_Document_Comb_Date.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[10].Value.ToString();
                Payment_Document_Comb_Cate.Text = this.Payment_Document_dataGrid.CurrentRow.Cells[11].Value.ToString();
                Payment_Document_update.Enabled = true;
                Payment_Document_delete.Enabled = true;
                Payment_Document_add.Enabled = false;
                Payment_Document_Brows_Docs.Enabled = true;

            }
        }

        private void Payment_Document_add_Click(object sender, EventArgs e)
        {
            if (Payment_Document_Comb_Cate.Text == "رواتب")
            {
                Program.Special_Message("لا يمكن اضافة سند من نوع رواتب عليك تثبيت الرواتب ليتم توليد سند بشكل تلقائي");
                return;
            }
            if (Payment_Document_Comb_Cate.Text == "فاتورة")
            {
                Program.Special_Message("لا يمكن اضافة سند من نوع فاتورة عليك اضافة فاتورة ليتم توليد سند بشكل تلقائي");
                return;
            }
            if (Payment_Document_Comb_Cate.Text == "قرض")
            {
                Program.Special_Message("لا يمكن اضافة سند من نوع قرض عليك اضافة قرض ليتم توليد سند بشكل تلقائي");
                return;
            }
            if (Payment_Document_Comb_Cate.Text == "دفعة قرض")
            {
                Program.Special_Message("لا يمكن اضافة سند دفع من نوع دفعة قرض لانه من انواع سندات الاستلام");
                return;
            }

            if (Payment_Document_sy.Text == String.Empty && Payment_Document_Dollar.Text == String.Empty)
            {

                MessageBox.Show("يجب ادخال المبلغ السوري او الدولار", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Payment_Document_Dollar.Text != String.Empty && Payment_Document_rate.Text == String.Empty)
            {

                MessageBox.Show("يجب ادخال قيمة التحويل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Payment_Document_Receve.Text == String.Empty)
            {

                MessageBox.Show("أضف المستلم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Payment_Document_no.Text == String.Empty)
            {

                MessageBox.Show("أضف رقم السند", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Payment_Document_No_Order.Text == String.Empty)
            {

                MessageBox.Show("أضف رقم امر الصرف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Dt = pay.Payment_Document_View();
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
                pay.Payment_Document_add(Payment_Document_sy.Text==string.Empty?"0": Payment_Document_sy.Text,
                                         Payment_Document_Dollar.Text == string.Empty ? "0" : Payment_Document_Dollar.Text,
                                         Payment_Document_rate.Text == string.Empty ? "1" : Payment_Document_rate.Text,
                Payment_Document_no.Text, Payment_Document_No_Order.Text, Payment_Document_Reason.Text,
                Payment_Document_Receve.Text, Payment_Document_DateTime.Value, Payment_Document_Notes.Text,
                Convert.ToInt32(Payment_Document_Comb_Date.SelectedValue), Convert.ToInt32(Payment_Document_Comb_Cate.SelectedValue));
                this.Payment_Document_dataGrid.DataSource = pay.Payment_Document_View();
                this.Payment_Document_dataGrid.Columns[0].Visible = false;
                // تحديث الميزانية
                Program.Budget_update_after_Payment_Reciver("P", Payment_Document_sy.Text, Payment_Document_Dollar.Text);
                frm.Update_label_finance_Box();
            //

            /// اضافة ملحقات لسند الدفع
            int id_Paymetn_Doc_new_add =Convert.ToInt32(pay.Payment_Document_Max_ID().Rows[0][0]) ;
            if (MessageBox.Show("هل تريد اضافة ملحقات لهذا السند؟", "ملحقات", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Document_FORM FRM = new Document_FORM(id_Paymetn_Doc_new_add, "سند دفع");
                FRM.ShowDialog();
            }
            ////
            Program.Add_Message();
            LOG.LOGS_add(Program.USER_ID, "اضافة", "اضافة سند دفع", DateTime.Now);
            Payment_Document_sy.Text = "";
                Payment_Document_Dollar.Text = "";
                Payment_Document_rate.Text = "";
                Payment_Document_no.Text = "";
                Payment_Document_No_Order.Text = "";
                Payment_Document_Reason.Text = "";
                Payment_Document_Receve.Text = "";
                Payment_Document_Notes.Text = "";
                Payment_Document_add.Enabled = false;
        }

        private void Payment_Document_update_Click(object sender, EventArgs e)
        {
            if (this.Payment_Document_dataGrid.CurrentRow.Cells[11].Value.ToString() == "رواتب")
            {
                Program.Special_Message("لا يمكن تعديل سند من نوع رواتب عليك تعديل الرواتب المرتبطة به");
                return;
            }
            if (this.Payment_Document_dataGrid.CurrentRow.Cells[11].Value.ToString() == "فاتورة")
            {
                Program.Special_Message("لا يمكن تعديل سند من نوع فاتورة عليك تعديل الفاتورة المرتبطة به");
                return;
            }
            if (this.Payment_Document_dataGrid.CurrentRow.Cells[11].Value.ToString() == "قرض")
            {
                Program.Special_Message("لا يمكن تعديل سند من نوع قرض عليك تعديل القرض المرتبطة به");
                return;
            }
            if (Payment_Document_Comb_Cate.Text == "قرض")
            {
                Program.Special_Message("لا يمكن تعديل سند دفع الى انواع سندات الاستلام");
                return;
            }
            if (Payment_Document_sy.Text == String.Empty && Payment_Document_Dollar.Text == String.Empty)
            {

                MessageBox.Show("يجب ادخال المبلغ السوري او الدولار", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Payment_Document_Dollar.Text != String.Empty && Payment_Document_rate.Text == String.Empty)
            {

                MessageBox.Show("يجب ادخال قيمة التحويل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Payment_Document_Receve.Text == String.Empty)
            {
                MessageBox.Show("أضف المستلم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Payment_Document_no.Text == String.Empty)
            {
                MessageBox.Show("أضف رقم السند", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Payment_Document_No_Order.Text == String.Empty)
            {
                MessageBox.Show("أضف رقم امر الصرف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // تحديث الميزانية
            Dt = pay.Payment_Document_View();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                if ((int)Dt.Rows[i][0] != Program.Payment_Document_id)
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
            Program.Budget_update_after_Payment_Reciver("R", Payment_Document_dataGrid.Rows[indexRowDeleted_or_Updated].Cells[1].Value.ToString(),
                                                                    Payment_Document_dataGrid.Rows[indexRowDeleted_or_Updated].Cells[2].Value.ToString());
            Program.Budget_update_after_Payment_Reciver("P", Payment_Document_sy.Text == string.Empty ? "0" : Payment_Document_sy.Text,
                                                                    Payment_Document_Dollar.Text == string.Empty ? "0" : Payment_Document_Dollar.Text);
                //
                pay.Payment_Document_update(Payment_Document_sy.Text == string.Empty ? "0" : Payment_Document_sy.Text,
                                         Payment_Document_Dollar.Text == string.Empty ? "0" : Payment_Document_Dollar.Text,
                                         Payment_Document_rate.Text == string.Empty ? "1" : Payment_Document_rate.Text,
                   Payment_Document_no.Text, Payment_Document_No_Order.Text, Payment_Document_Reason.Text,
                   Payment_Document_Receve.Text, Payment_Document_DateTime.Value, Payment_Document_Notes.Text,
                   Convert.ToInt32(Payment_Document_Comb_Date.SelectedValue), Convert.ToInt32(Payment_Document_Comb_Cate.SelectedValue), Program.Payment_Document_id);
                this.Payment_Document_dataGrid.DataSource = pay.Payment_Document_View();
                this.Payment_Document_dataGrid.Columns[0].Visible = false;
                Program.Update_Message();
            LOG.LOGS_add(Program.USER_ID, "تعديل", "تعديل سند دفع", DateTime.Now);
            Payment_Document_sy.Text = "";
                Payment_Document_Dollar.Text = "";
                Payment_Document_rate.Text = "";
                Payment_Document_no.Text = "";
                Payment_Document_No_Order.Text = "";
                Payment_Document_Reason.Text = "";
                Payment_Document_Receve.Text = "";
                Payment_Document_Notes.Text = "";
                Payment_Document_update.Enabled = false;
                Payment_Document_delete.Enabled = false;
                Payment_Document_Brows_Docs.Enabled = false;


        }

        private void Payment_Document_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف سند الدفع .اذا تم الحذف فسيتم حذف كافة تفاصيلها من البرنامج؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string type_Doc = this.Payment_Document_dataGrid.CurrentRow.Cells[11].Value.ToString();

                if (this.Payment_Document_dataGrid.CurrentRow.Cells[11].Value.ToString()=="فاتورة")
                {

                    // حذف الفاتورة التابعة لهذا السند في حال كانت من نوع فاتورة
                    if (MessageBox.Show("هذا السند مرتبط بفاتورة اذا تم حذفه سيتم حذف الفاتورة المرتبطه به .. هل تريد الحذف بالتاكيد ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataTable dt;
                        if ((dt= ope.Operations_Bill_Salary_LoanPay_Viewby_IdPayRec_Statue(Program.Payment_Document_id, "فاتورة")).Rows.Count!=0)
                        {
                            int bill_id = Convert.ToInt32(dt.Rows[0][0]);
                            bill_details.Bills_Details_Delete(bill_id);
                            ope.Operations_Bill_Salary_LoanPay_Delete(Program.Payment_Document_id, bill_id, "فاتورة");
                        }
                    }
                    else
                    {
                        return;
                    }
                    //

                }
                if (this.Payment_Document_dataGrid.CurrentRow.Cells[11].Value.ToString() == "رواتب")
                {

                    // حذف الاصدار التابعة لهذا السند في حال كانت من نوع فاتورة
                    if (MessageBox.Show("هذا السند مرتبط برواتب العاملين اذا تم حذفه سيتم حذف الرواتب المرتبطه به .. هل تريد الحذف بالتاكيد ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataTable dt;
                        if ((dt= ope.Operations_Bill_Salary_LoanPay_Viewby_IdPayRec_Statue(Program.Payment_Document_id, "رواتب")).Rows.Count!=0)
                        {
                            int Emission_ID = Convert.ToInt32(dt.Rows[0][0]);
                            emp_Sal.Employee_Salaries_Delete_by_Emission_ID(Emission_ID); // delete salaries for this emission
                            emission.Emission_Salaries_Delete(Emission_ID); // delete emission
                            ope.Operations_Bill_Salary_LoanPay_Delete(Program.Payment_Document_id, Emission_ID, "رواتب");// delete operations

                        }   
                    }
                    else
                    {
                        return;
                    }
                    //

                }
                if (this.Payment_Document_dataGrid.CurrentRow.Cells[11].Value.ToString() == "قرض")
                {

                    // حذف القرض التابعة لهذا السند في حال كانت من نوع قرض
                    if (MessageBox.Show("هذا السند مرتبط بقرض اذا تم حذفه سيتم حذف قرض المرتبطه به .. هل تريد الحذف بالتاكيد ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // حذف القرض وتحديث الميزانية
                        DataTable dt;
                        if ((dt = ope.Operations_Bill_Salary_LoanPay_Viewby_IdPayRec_Statue(Program.Payment_Document_id, "قرض")).Rows.Count != 0)
                        {
                            int ID_Loan = Convert.ToInt32(dt.Rows[0][0]);
                            loan.Loans_Delete(ID_Loan); // delete Loan
                            ope.Operations_Bill_Salary_LoanPay_Delete(Program.Payment_Document_id, ID_Loan, "قرض");// delete operations

                            // يحذف سندات الاستلام الخاصة بدفعات القروض الخاصة بهذا القرض اذا كان لها سندات استلام
                            DataTable dt_Payments_Loan;
                            if ((dt_Payments_Loan = leoan_Payments.Leoan_Payments_View_Loans_ID(ID_Loan)).Rows.Count != 0)
                            {
                                DataTable one_Loan_Payment;
                                foreach (DataRow item in dt_Payments_Loan.Rows)
                                {
                                    if ((one_Loan_Payment = ope.Operations_Bill_Salary_LoanPay_Viewby_towID(Convert.ToInt32(item[0]), "دفعة قرض")).Rows.Count != 0)
                                    {
                                        int Reciver_id_for_this_Leoan_Payments = Convert.ToInt32(one_Loan_Payment.Rows[0][0]);
                                        // تحديث الميزانية
                                        DataTable Reciver_ID;
                                        if ((Reciver_ID = reciver_Document.Reciver_Document_Search_by_id(Reciver_id_for_this_Leoan_Payments)).Rows.Count != 0)
                                        {
                                            Program.Budget_update_after_Payment_Reciver("P", Reciver_ID.Rows[0][1].ToString(), Reciver_ID.Rows[0][2].ToString());
                                            //
                                        }
                                        leoan_Payments.Leoan_Payments_Delete(Convert.ToInt32(item[0]));
                                        reciver_Document.Reciver_Document_Delete(Reciver_id_for_this_Leoan_Payments);
                                        ope.Operations_Bill_Salary_LoanPay_Delete(Reciver_id_for_this_Leoan_Payments, Convert.ToInt32(item[0]), "دفعة قرض");
                                        //
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        return;
                    }
                    //

                }

                // تحديث الميزانية
                Program.Budget_update_after_Payment_Reciver("R", Payment_Document_dataGrid.Rows[indexRowDeleted_or_Updated].Cells[1].Value.ToString(), Payment_Document_dataGrid.Rows[indexRowDeleted_or_Updated].Cells[2].Value.ToString());
                frm.Update_label_finance_Box();
                //
                pay.Payment_Document_Delete(Program.Payment_Document_id);
                this.Payment_Document_dataGrid.DataSource = pay.Payment_Document_View();
                this.Payment_Document_dataGrid.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LOG.LOGS_add(Program.USER_ID, "حذف", "حذف سند دفع", DateTime.Now);
                Payment_Document_sy.Text = "";
                Payment_Document_Dollar.Text = "";
                Payment_Document_rate.Text = "";
                Payment_Document_no.Text = "";
                Payment_Document_No_Order.Text = "";
                Payment_Document_Reason.Text = "";
                Payment_Document_Receve.Text = "";
                Payment_Document_Notes.Text = "";
                Payment_Document_update.Enabled = false;
                Payment_Document_delete.Enabled = false;
                Payment_Document_Brows_Docs.Enabled = false;
            }
        }

      
        private void Payment_Document_Date_first_ValueChanged(object sender, EventArgs e)
        {
            this.Payment_Document_dataGrid.DataSource = pay.Payment_Document_Date_between(Payment_Document_Date_first.Value , Payment_Document_Date_last.Value);
            this.Payment_Document_dataGrid.Columns[0].Visible = false;
        }

        private void Payment_Document_Date_last_ValueChanged(object sender, EventArgs e)
        {
            this.Payment_Document_dataGrid.DataSource = pay.Payment_Document_Date_between(Payment_Document_Date_first.Value, Payment_Document_Date_last.Value);
            this.Payment_Document_dataGrid.Columns[0].Visible = false;
        }

        private void Payment_Document_Print_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            DataTable DT_REPORT = new DataTable();

            DT_REPORT.Columns.Add("المبلغ بالسوري", typeof(string));
            DT_REPORT.Columns.Add("المبلغ بالدولار", typeof(string));
            DT_REPORT.Columns.Add("قيمة التحويل", typeof(string));
            DT_REPORT.Columns.Add("رقم سند الدفع", typeof(string));
            DT_REPORT.Columns.Add("رقم امر الصرف", typeof(string));
            DT_REPORT.Columns.Add("سبب الدفع", typeof(string));
            DT_REPORT.Columns.Add("المستلم", typeof(string));
            DT_REPORT.Columns.Add("التاريخ", typeof(string));
            DT_REPORT.Columns.Add("الملاحظات", typeof(string));
            DT_REPORT.Columns.Add("الميزانية", typeof(string));
            DT_REPORT.Columns.Add("نوع السند", typeof(string));
            foreach (DataGridViewRow dgv in Payment_Document_dataGrid.Rows)
            {
                DT_REPORT.Rows.Add(dgv.Cells[1].Value, dgv.Cells[2].Value,dgv.Cells[3].Value
                   , dgv.Cells[4].Value,
                  dgv.Cells[5].Value, dgv.Cells[6].Value, dgv.Cells[7].Value, Convert.ToDateTime(dgv.Cells[8].Value).ToShortDateString()
                  , dgv.Cells[9].Value,  Convert.ToDateTime(dgv.Cells[10].Value).ToShortDateString(), dgv.Cells[11].Value);
            }
            DS.Tables.Add(DT_REPORT);
            DS.WriteXmlSchema("C:\\AraratProgramFiles\\Payment_Document.xml");

            REPT.FRM_Report frm = new REPT.FRM_Report();
            REPT.Crystal_Payment_Document report = new REPT.Crystal_Payment_Document();
            report.Refresh();
            report.SetDataSource(DS);
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
            LOG.LOGS_add(Program.USER_ID, "طباعة", "طباعة سند دفع", DateTime.Now);
        }

        private void Payment_Document_Search_TextChanged(object sender, EventArgs e)
        {
            this.Payment_Document_dataGrid.DataSource = pay.Payment_Document_Search(Payment_Document_Search.Text);
            this.Payment_Document_dataGrid.Columns[0].Visible = false;
        }

        private void Payment_Document_sy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Payment_Document_Dollar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Payment_Document_rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Payment_Document_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Payment_Document_No_Order_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void update_Click(object sender, EventArgs e)
        {
            this.Payment_Document_dataGrid.DataSource = pay.Payment_Document_View();
            this.Payment_Document_dataGrid.Columns[0].Visible = false;
            Payment_Document_Date_first.Value = DateTime.Now.Date;
            Payment_Document_Date_last.Value = DateTime.Now.Date;
        }

        private void Payment_Document_Brows_Docs_Click(object sender, EventArgs e)
        {
            Document_FORM FRM = new Document_FORM(Program.Payment_Document_id, "سند دفع");
            FRM.ShowDialog();

        }
    }
}
