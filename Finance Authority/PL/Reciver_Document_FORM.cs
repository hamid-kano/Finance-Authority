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
    public partial class Reciver_Document_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Coin_Exchange Coin = new BL.CLS_Coin_Exchange();
        BL.CLS_Reciver_Document Reciv = new BL.CLS_Reciver_Document();
        Finance_Authority frm = Finance_Authority.getMainForm;
        int indexRowDeleted_or_Updated;
        BL.CLS_Budget Bud = new BL.CLS_Budget();
        BL.CLS_LOGS LOG = new BL.CLS_LOGS();
        public Reciver_Document_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            this.Reciver_Document_dataGrid.DataSource= Reciv.Reciver_Document_View();
            this.Reciver_Document_dataGrid.Columns[0].Visible = false;
            Reciver_Document_Comb_Date.DataSource = Bud.Budget_combo_Last_Budget();
            Reciver_Document_Comb_Date.DisplayMember = "Date";
            Reciver_Document_Comb_Date.ValueMember = "Budget_Id";
            Reciver_Document_Comb_Cate.DataSource = Reciv.Reciver_Document_Comb_Cate();
            Reciver_Document_Comb_Cate.DisplayMember = "Document_Type";
            Reciver_Document_Comb_Cate.ValueMember = "Category_id";
        }

        private void Reciver_Document_new_Click(object sender, EventArgs e)
        {
            Reciver_Document_add.Enabled = true;
            Reciver_Document_sy.Text = "";
            Reciver_Document_Dollar.Text = "";
            Reciver_Document_rate.Text = "";
            Reciver_Document_no.Text = "";
            Reciver_Document_Reason.Text = "";
            Reciver_Document_Receve.Text = "";
            Reciver_Document_Notes.Text = "";
            Reciver_Document_update.Enabled = false;
            Reciver_Document_delete.Enabled = false;
            Reciver_Document_Brows_Docs.Enabled = false;
        }
        private void Reciver_Document_xit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Reciver_Document_add_Click(object sender, EventArgs e)
        {
            if (Reciver_Document_sy.Text == String.Empty && Reciver_Document_Dollar.Text == String.Empty)
            {

                MessageBox.Show("يجب ادخال المبلغ السوري او الدولار", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Reciver_Document_Dollar.Text != String.Empty && Reciver_Document_rate.Text == String.Empty)
            {

                MessageBox.Show("يجب ادخال قيمة التحويل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Reciver_Document_Receve.Text == String.Empty)
            {

                MessageBox.Show("أضف المستلم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Reciver_Document_no.Text == String.Empty)
            {

                MessageBox.Show("أضف رقم السند", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable Dt = new DataTable();
            Dt = Reciv.Reciver_Document_Cheack(Reciver_Document_no.Text);
            if (Dt.Rows.Count == 0)
            {
                Reciv.Reciver_Document_add(Reciver_Document_sy.Text == string.Empty ? "0" : Reciver_Document_sy.Text,
                                         Reciver_Document_Dollar.Text == string.Empty ? "0" : Reciver_Document_Dollar.Text,
                                         Reciver_Document_rate.Text == string.Empty ? "1" : Reciver_Document_rate.Text,
                    Reciver_Document_no.Text, Reciver_Document_Reason.Text, Reciver_Document_Receve.Text, Reciver_Document_DateTime.Value, Reciver_Document_Notes.Text, Convert.ToInt32(Reciver_Document_Comb_Date.SelectedValue), Convert.ToInt32(Reciver_Document_Comb_Cate.SelectedValue));
                this.Reciver_Document_dataGrid.DataSource = Reciv.Reciver_Document_View();
                this.Reciver_Document_dataGrid.Columns[0].Visible = false;
                // تحديث الميزانية
                Program.Budget_update_after_Payment_Reciver("add", "r", Reciver_Document_sy.Text, Reciver_Document_Dollar.Text);
                frm.Update_label_finance_Box();
                //
                /// اضافة ملحقات لسند القبض
                int id_Reciver_Doc_new_add = Convert.ToInt32(Reciv.Reciver_Document_Max_ID().Rows[0][0]);
                if (MessageBox.Show("هل تريد اضافة ملحقات لهذا السند؟", "ملحقات", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Document_FORM FRM = new Document_FORM(id_Reciver_Doc_new_add, "سند قبض");
                    FRM.ShowDialog();
                }
                ////
                Program.Add_Message();
                LOG.LOGS_add(Program.USER_ID, "اضافة", "اضافة سند استلام", DateTime.Now);
                Reciver_Document_sy.Text = "";
                Reciver_Document_Dollar.Text = "";
                Reciver_Document_rate.Text = "";
                Reciver_Document_no.Text = "";
                Reciver_Document_Reason.Text = "";
                Reciver_Document_Receve.Text = "";
                Reciver_Document_Notes.Text = "";
                Reciver_Document_add.Enabled = false;
            }
            else
            {
                MessageBox.Show("موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            } 
        }

        private void Reciver_Document_update_Click(object sender, EventArgs e)
        {
            if (Reciver_Document_sy.Text == String.Empty && Reciver_Document_Dollar.Text == String.Empty)
            {

                MessageBox.Show("يجب ادخال المبلغ السوري او الدولار", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Reciver_Document_Dollar.Text != String.Empty && Reciver_Document_rate.Text == String.Empty)
            {

                MessageBox.Show("يجب ادخال قيمة التحويل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Reciver_Document_Receve.Text == String.Empty)
            {

                MessageBox.Show("أضف المستلم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Reciver_Document_no.Text == String.Empty)
            {

                MessageBox.Show("أضف رقم السند", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable Dt = new DataTable();
            Dt = Reciv.Reciver_Document_Cheack(Reciver_Document_no.Text);
            if (Dt.Rows.Count == 0 || Reciver_Document_no.Text== this.Reciver_Document_dataGrid.CurrentRow.Cells[4].Value.ToString())
            {
                Reciv.Reciver_Document_update(Reciver_Document_sy.Text == string.Empty ? "0" : Reciver_Document_sy.Text,
                                         Reciver_Document_Dollar.Text == string.Empty ? "0" : Reciver_Document_Dollar.Text,
                                         Reciver_Document_rate.Text == string.Empty ? "1" : Reciver_Document_rate.Text,
                    Reciver_Document_no.Text, Reciver_Document_Reason.Text, Reciver_Document_Receve.Text, Reciver_Document_DateTime.Value, Reciver_Document_Notes.Text, Convert.ToInt32(Reciver_Document_Comb_Date.SelectedValue), Convert.ToInt32(Reciver_Document_Comb_Cate.SelectedValue), Program.Reciver_Document_id);
                this.Reciver_Document_dataGrid.DataSource = Reciv.Reciver_Document_View();
                this.Reciver_Document_dataGrid.Columns[0].Visible = false;
                // تحديث الميزانية
                int Sy_After_Updat = Convert.ToInt32(Reciver_Document_sy.Text == string.Empty ? "0" : Reciver_Document_sy.Text) - Convert.ToInt32(this.Reciver_Document_dataGrid.Rows[indexRowDeleted_or_Updated].Cells[1].Value);
                int Dollar_After_Updat = Convert.ToInt32(Reciver_Document_Dollar.Text == string.Empty ? "0" : Reciver_Document_Dollar.Text) - Convert.ToInt32(this.Reciver_Document_dataGrid.Rows[indexRowDeleted_or_Updated].Cells[2].Value);
                Program.Budget_update_after_Payment_Reciver("update", "r", Sy_After_Updat.ToString(), Dollar_After_Updat.ToString());
                frm.Update_label_finance_Box();
                //
                Program.Update_Message();
                LOG.LOGS_add(Program.USER_ID, "تعديل", "تعديل سند استلام", DateTime.Now);
                Reciver_Document_sy.Text = "";
                Reciver_Document_Dollar.Text = "";
                Reciver_Document_rate.Text = "";
                Reciver_Document_no.Text = "";
                Reciver_Document_Reason.Text = "";
                Reciver_Document_Receve.Text = "";
                Reciver_Document_Notes.Text = "";
                Reciver_Document_update.Enabled = false;
                Reciver_Document_delete.Enabled = false;
                Reciver_Document_Brows_Docs.Enabled = false;

            }
            else
            {
                MessageBox.Show("موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            } 
        }

        private void Reciver_Document_dataGrid_Click(object sender, EventArgs e)
        {
            if (Reciver_Document_dataGrid.CurrentRow != null)
            {
                indexRowDeleted_or_Updated = Convert.ToInt32(this.Reciver_Document_dataGrid.CurrentRow.Index);
                Program.Reciver_Document_id= Convert.ToInt32(this.Reciver_Document_dataGrid.CurrentRow.Cells[0].Value.ToString());
                Reciver_Document_sy.Text = this.Reciver_Document_dataGrid.CurrentRow.Cells[1].Value.ToString();
                Reciver_Document_Dollar.Text = this.Reciver_Document_dataGrid.CurrentRow.Cells[2].Value.ToString();
                Reciver_Document_rate.Text = this.Reciver_Document_dataGrid.CurrentRow.Cells[3].Value.ToString();
                Reciver_Document_no.Text = this.Reciver_Document_dataGrid.CurrentRow.Cells[4].Value.ToString();
                Reciver_Document_Reason.Text = this.Reciver_Document_dataGrid.CurrentRow.Cells[5].Value.ToString();
                Reciver_Document_Receve.Text = this.Reciver_Document_dataGrid.CurrentRow.Cells[6].Value.ToString();
                Reciver_Document_DateTime.Text = this.Reciver_Document_dataGrid.CurrentRow.Cells[7].Value.ToString();
                Reciver_Document_Notes.Text = this.Reciver_Document_dataGrid.CurrentRow.Cells[8].Value.ToString();
                Reciver_Document_Comb_Date.Text = this.Reciver_Document_dataGrid.CurrentRow.Cells[9].Value.ToString();
                Reciver_Document_Comb_Cate.Text= this.Reciver_Document_dataGrid.CurrentRow.Cells[10].Value.ToString();
                Reciver_Document_update.Enabled = true;
                Reciver_Document_delete.Enabled = true;
                Reciver_Document_Brows_Docs.Enabled = true;
                Reciver_Document_add.Enabled = false;
            }
        }

        private void Reciver_Document_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف سند الاستلام .اذا تم الحذف فسيتم حذف كافة تفاصيلها من البرنامج؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // تحديث الميزانية
                Program.Budget_update_after_Payment_Reciver("delete","r", Reciver_Document_dataGrid.Rows[indexRowDeleted_or_Updated].Cells[1].Value.ToString(), Reciver_Document_dataGrid.Rows[indexRowDeleted_or_Updated].Cells[2].Value.ToString());
                frm.Update_label_finance_Box();
                //
                Reciv.Reciver_Document_Delete(Program.Reciver_Document_id);
                this.Reciver_Document_dataGrid.DataSource = Reciv.Reciver_Document_View();
                this.Reciver_Document_dataGrid.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LOG.LOGS_add(Program.USER_ID, "حذف", "حذف سند استلام", DateTime.Now);
                Reciver_Document_sy.Text = "";
                Reciver_Document_Dollar.Text = "";
                Reciver_Document_rate.Text = "";
                Reciver_Document_no.Text = "";
                Reciver_Document_Reason.Text = "";
                Reciver_Document_Receve.Text = "";
                Reciver_Document_Notes.Text = "";
                Reciver_Document_update.Enabled = false;
                Reciver_Document_delete.Enabled = false;
                Reciver_Document_Brows_Docs.Enabled = false;

            }
        }

        private void Reciver_Document_Date_first_ValueChanged(object sender, EventArgs e)
        {
            this.Reciver_Document_dataGrid.DataSource = Reciv.Reciver_Document_Date_Butween(Reciver_Document_Date_first.Value, Reciver_Document_Date_last.Value);
            this.Reciver_Document_dataGrid.Columns[0].Visible = false;
        }

        private void Reciver_Document_Date_last_ValueChanged(object sender, EventArgs e)
        {
            this.Reciver_Document_dataGrid.DataSource = Reciv.Reciver_Document_Date_Butween(Reciver_Document_Date_first.Value, Reciver_Document_Date_last.Value);
            this.Reciver_Document_dataGrid.Columns[0].Visible = false;
        }

        private void Reciver_Document_Print_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            DataTable DT_REPORT = new DataTable();

            DT_REPORT.Columns.Add("المبلغ بالسوري", typeof(string));
            DT_REPORT.Columns.Add("المبلغ بالدولار", typeof(string));
            DT_REPORT.Columns.Add("قيمة التحويل", typeof(string));
            DT_REPORT.Columns.Add("رقم سند الاستلام", typeof(string));
            DT_REPORT.Columns.Add("السبب ", typeof(string));
            DT_REPORT.Columns.Add("من قبل", typeof(string));
            DT_REPORT.Columns.Add("التاريخ", typeof(string));
            DT_REPORT.Columns.Add("الملاحظات", typeof(string));
            DT_REPORT.Columns.Add("الميزانية", typeof(string));
            DT_REPORT.Columns.Add("نوع السند", typeof(string));
            foreach (DataGridViewRow dgv in Reciver_Document_dataGrid.Rows)
            {
                DT_REPORT.Rows.Add(dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value
                   , dgv.Cells[4].Value,
                  dgv.Cells[5].Value, dgv.Cells[6].Value, Convert.ToDateTime(dgv.Cells[7].Value).ToShortDateString(), dgv.Cells[8].Value
                  , Convert.ToDateTime(dgv.Cells[9].Value).ToShortDateString(),dgv.Cells[10].Value);
            }
            DS.Tables.Add(DT_REPORT);
            DS.WriteXmlSchema("C:\\AraratProgramFiles\\Reciver_Document.xml");

            REPT.FRM_Report frm = new REPT.FRM_Report();
            REPT.Crystal_Reciver_Documents report = new REPT.Crystal_Reciver_Documents();
            report.Refresh();
            report.SetDataSource(DS);
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
        }
        private void Reciver_Document_Search_TextChanged(object sender, EventArgs e)
        {
            this.Reciver_Document_dataGrid.DataSource = Reciv.Reciver_Document_Search(Reciver_Document_Search.Text);
            this.Reciver_Document_dataGrid.Columns[0].Visible = false;
        }

        private void Reciver_Document_sy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Reciver_Document_Dollar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Reciver_Document_rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Reciver_Document_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void update_Click(object sender, EventArgs e)
        {
            this.Reciver_Document_dataGrid.DataSource = Reciv.Reciver_Document_View();
            this.Reciver_Document_dataGrid.Columns[0].Visible = false;
            Reciver_Document_Date_first.Value = DateTime.Now.Date;
            Reciver_Document_Date_last.Value = DateTime.Now.Date;
        }

        private void Reciver_Document_Brows_Docs_Click(object sender, EventArgs e)
        {
            Document_FORM FRM = new Document_FORM(Program.Payment_Document_id, "سند قبض");
            FRM.ShowDialog();
        }
    }
}
