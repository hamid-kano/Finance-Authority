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
    public partial class EX_Order_FORM : MetroFramework.Forms.MetroForm
    { BL.CLS_Exchange_Order order = new BL.CLS_Exchange_Order();
        CLS_Exchange_Orders_Category cat = new CLS_Exchange_Orders_Category();
        BL.CLS_LOGS LOG = new BL.CLS_LOGS();
        public EX_Order_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            this.EX_Orders_dataGrid.DataSource = order.Exchange_Order_view();
            EX_Orders_CombCategorise.DataSource = order.EX_Orders_CombCategorise();
            EX_Orders_CombCategorise.DisplayMember = "Exchange_Order_Type";
            EX_Orders_CombCategorise.ValueMember = "Category_id";
            this.EX_Orders_dataGrid.Columns[0].Visible = false;
        }

        
        private void EX_Orders_add_Click(object sender, EventArgs e)
        {
            if (EX_Orders_order.Text == String.Empty)
            {

                MessageBox.Show("أضف رقم الطلب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (EX_Orders_tosorce.Text == String.Empty)
            {

                MessageBox.Show("أضف الجهة المسستلمة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable Dt = new DataTable();
            Dt = order.Exchange_Order_Cheack(EX_Orders_order.Text);
            if (Dt.Rows.Count == 0)
            {
                order.Exchange_Order_add(EX_Orders_order.Text, EX_Orders_DateTime.Value, EX_Orders_tosorce.Text, EX_Orders_Body_order.Text, EX_Orders_Notes.Text, Convert.ToInt32(EX_Orders_CombCategorise.SelectedValue));
                /// اضافة ملحقات لهذا الطلب
                if (MessageBox.Show("هل تريد اضافة ملحقات لهذا الطلب؟", "ملحقات", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    int MAX_Exchange_Order_ID =Convert.ToInt32(order.Exchange_Order_Max_ID().Rows[0][0]);
                    Document_FORM FRM = new Document_FORM(MAX_Exchange_Order_ID, "طلب صرف مبلغ");
                    FRM.ShowDialog();
                }
                ////
                this.EX_Orders_dataGrid.DataSource = order.Exchange_Order_view();
                this.EX_Orders_dataGrid.Columns[0].Visible = false;
                Program.Add_Message();
                LOG.LOGS_add(Program.USER_ID, "اضافة", "اضافة طلب صرف مبلغ", DateTime.Now);
                EX_Orders_order.Text = "";
                EX_Orders_tosorce.Text = "";
                EX_Orders_Body_order.Text = "";
                EX_Orders_Notes.Text = "";
                EX_Orders_CombCategorise.Text = "";
                EX_Orders_add.Enabled = false;
            }
            else
            {
                MessageBox.Show("رقم الطلب موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
                return;
            }
            
        }

        private void EX_Orders_new_Click(object sender, EventArgs e)
        {
            EX_Orders_add.Enabled = true;
            EX_Orders_update.Enabled = false;
            EX_Orders_delete.Enabled = false;
            EX_Orders_Brows_Docs.Enabled = false;
            EX_Orders_order.Text = "";
            EX_Orders_tosorce.Text = "";
            EX_Orders_Body_order.Text = "";
            EX_Orders_Notes.Text = "";
            
        }

        private void EX_Orders_dataGrid_Click(object sender, EventArgs e)
        {
            if (EX_Orders_dataGrid.CurrentRow != null)
            {
                Program.Exchange_Order_id = Convert.ToInt32(this.EX_Orders_dataGrid.CurrentRow.Cells[0].Value.ToString());
                EX_Orders_order.Text = this.EX_Orders_dataGrid.CurrentRow.Cells[1].Value.ToString();
                EX_Orders_DateTime.Text = this.EX_Orders_dataGrid.CurrentRow.Cells[2].Value.ToString();
                EX_Orders_tosorce.Text = this.EX_Orders_dataGrid.CurrentRow.Cells[3].Value.ToString();
                EX_Orders_Body_order.Text = this.EX_Orders_dataGrid.CurrentRow.Cells[4].Value.ToString();
                EX_Orders_Notes.Text = this.EX_Orders_dataGrid.CurrentRow.Cells[5].Value.ToString();
                EX_Orders_CombCategorise.Text = this.EX_Orders_dataGrid.CurrentRow.Cells[6].Value.ToString();
                EX_Orders_update.Enabled = true;
                EX_Orders_delete.Enabled = true;
                EX_Orders_Brows_Docs.Enabled = true;
                EX_Orders_add.Enabled = false;
            }
        }

        private void EX_Orders_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EX_Orders_update_Click(object sender, EventArgs e)
        {
            if (EX_Orders_order.Text == String.Empty)
            {

                MessageBox.Show("أضف رقم الطلب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (EX_Orders_tosorce.Text == String.Empty)
            {

                MessageBox.Show("أضف الجهة المسستلمة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable Dt = new DataTable();
            Dt = order.Exchange_Order_Cheack(EX_Orders_order.Text);
            if (Dt.Rows.Count == 0 || EX_Orders_order.Text== this.EX_Orders_dataGrid.CurrentRow.Cells[1].Value.ToString())
            {
               
               
               order.Exchange_Order_update(Program.Exchange_Order_id, EX_Orders_order.Text, EX_Orders_DateTime.Value, EX_Orders_tosorce.Text, EX_Orders_Body_order.Text, EX_Orders_Notes.Text, Convert.ToInt32(EX_Orders_CombCategorise.SelectedValue));
                this.EX_Orders_dataGrid.DataSource = order.Exchange_Order_view();
                this.EX_Orders_dataGrid.Columns[0].Visible = false;
                Program.Update_Message();
                LOG.LOGS_add(Program.USER_ID, "تعديل", "تعديل طلب صرف مبلغ", DateTime.Now);
                EX_Orders_order.Text = "";
                EX_Orders_tosorce.Text = "";
                EX_Orders_Body_order.Text = "";
                EX_Orders_Notes.Text = "";
              
                EX_Orders_update.Enabled = false;
                EX_Orders_delete.Enabled = false;
                EX_Orders_Brows_Docs.Enabled = false;

            }
            else
            {
                MessageBox.Show("رقم الطلب موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                EX_Orders_update.Enabled = false;
                EX_Orders_delete.Enabled = false;
                return;
            }
            
        }

        private void EX_Orders_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف طلب صرف مبلغ .اذا تم الحذف فسيتم حذف كافة تفاصيلها من البرنامج؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                order.Exchange_Order_Delete(Program.Exchange_Order_id);
                this.EX_Orders_dataGrid.DataSource = order.Exchange_Order_view();
                this.EX_Orders_dataGrid.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LOG.LOGS_add(Program.USER_ID, "حذف", "حذف طلب صرف مبلغ", DateTime.Now);
                EX_Orders_order.Text = "";
                EX_Orders_tosorce.Text = "";
                EX_Orders_Body_order.Text = "";
                EX_Orders_Notes.Text = "";
                EX_Orders_update.Enabled = false;
                EX_Orders_delete.Enabled = false;
                EX_Orders_Brows_Docs.Enabled = false;

            }
        }

      

       
        private void EX_Orders_first_ValueChanged(object sender, EventArgs e)
        {
            this.EX_Orders_dataGrid.DataSource = order.Exchange_Order_Search_Between_Date(EX_Orders_first.Value, EX_Orders_last.Value);
            this.EX_Orders_dataGrid.Columns[0].Visible = false;
        }

        private void EX_Orders_last_ValueChanged(object sender, EventArgs e)
        {
            this.EX_Orders_dataGrid.DataSource = order.Exchange_Order_Search_Between_Date(EX_Orders_first.Value, EX_Orders_last.Value);
            this.EX_Orders_dataGrid.Columns[0].Visible = false;
        }

        private void EX_Order_Print_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            DataTable DT_REPORT = new DataTable();

            DT_REPORT.Columns.Add("رقم الطلب", typeof(string));
            DT_REPORT.Columns.Add("التاريخ", typeof(string));
            DT_REPORT.Columns.Add("الى الجهة", typeof(string));
            DT_REPORT.Columns.Add("المضمون", typeof(string));
            DT_REPORT.Columns.Add("الملاحظات", typeof(string));
            DT_REPORT.Columns.Add("نوع الطلب", typeof(string));
            foreach (DataGridViewRow dgv in EX_Orders_dataGrid.Rows)
            {
                DT_REPORT.Rows.Add(dgv.Cells[1].Value, Convert.ToDateTime(dgv.Cells[2].Value).ToShortDateString(),dgv.Cells[3].Value
                   ,dgv.Cells[4].Value, dgv.Cells[5].Value, dgv.Cells[6].Value);
            }
            DS.Tables.Add(DT_REPORT);
            DS.WriteXmlSchema("C:\\AraratProgramFiles\\EX_Orders.xml");

            REPT.FRM_Report frm = new REPT.FRM_Report();
            REPT.Crystal_EX_Order report = new REPT.Crystal_EX_Order();

            report.Refresh();
            report.SetDataSource(DS);

            frm.crystalReportViewer1.ReportSource = report;


            frm.ShowDialog();
            LOG.LOGS_add(Program.USER_ID, "طباعة", "طباعة طبات صرف مبلغ المعروضة", DateTime.Now);
            //REPT.Crystal_EX_Orderrpt Art = new REPT.Crystal_EX_Orderrpt();

            //REPT.FRM_Report FRPT = new REPT.FRM_Report();

            //if (EX_Orders_dataGrid.Rows.Count != 0)
            //{
            //    // DataTable dt = dataGrid_Ringall.DataSource;
            //    Art.SetDataSource(EX_Orders_dataGrid.DataSource);

            //    FRPT.crystalReportViewer1.ReportSource = Art;
            //    FRPT.ShowDialog();
            //}
        }

        
        private void EX_Orders_search_TextChanged_1(object sender, EventArgs e)
        {
            this.EX_Orders_dataGrid.DataSource = order.Exchange_Order_Search_NO_Order(EX_Orders_search.Text);
            this.EX_Orders_dataGrid.Columns[0].Visible = false;
        }

        private void EX_Orders_search_All_TextChanged_1(object sender, EventArgs e)
        {

            this.EX_Orders_dataGrid.DataSource = order.Exchange_Order_Search_All(EX_Orders_search_All.Text);
            this.EX_Orders_dataGrid.Columns[0].Visible = false;
        }

        private void EX_Orders_order_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }


        private void update_Click(object sender, EventArgs e)
        {
            this.EX_Orders_dataGrid.DataSource = order.Exchange_Order_view();
            EX_Orders_CombCategorise.DataSource = order.EX_Orders_CombCategorise();
            EX_Orders_first.Value = DateTime.Now.Date;
            EX_Orders_last.Value = DateTime.Now.Date;
        }

        private void EX_Orders_Brows_Docs_Click(object sender, EventArgs e)
        {
            Document_FORM FRM = new Document_FORM(Program.Exchange_Order_id, "طلب صرف مبلغ");
            FRM.ShowDialog();
        }

        private void EX_Orders_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }
    }
}
