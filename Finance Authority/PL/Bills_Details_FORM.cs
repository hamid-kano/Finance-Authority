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
    public partial class Bills_Details_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Bills obj = new BL.CLS_Bills();
        BL.CLS_Bills_Details Bill = new BL.CLS_Bills_Details();
        BL.CLS_Employee_Description Empl_Des = new BL.CLS_Employee_Description();
        BL.CLS_Emission_Salaries Emiss = new BL.CLS_Emission_Salaries();
        BL.CLS_Budget budget = new BL.CLS_Budget();
        int _Bill_ID=-1; // update Status ;
        bool StatePaied;
        public Bills_Details_FORM(int Bills_ID)
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            Bills_Comb_Department.DataSource = Empl_Des.Employee_Description_Comb_Department();
            Bills_Comb_Department.DisplayMember = "Department_Name";
            Bills_Comb_Department.ValueMember = "Department_ID";
            Bills_Comb_Budget.DataSource =budget.Budget_combo_Last_Budget();
            Bills_Comb_Budget.DisplayMember = "Date";
            Bills_Comb_Budget.ValueMember = "Budget_Id";
            if (Bills_ID != -1)
            {
                _Bill_ID = Bills_ID;
                DataTable dt = new DataTable();
                dt = Bill.Bill_View__ByID(Bills_ID);
                Bills_NO_Bill.Text = dt.Rows[0][1].ToString();
                Bills_Buyer_Name.Text = dt.Rows[0][2].ToString();
                Bills_Coin_Type.Text = dt.Rows[0][3].ToString();
                Bills_Exchange_rate.Text = dt.Rows[0][4].ToString();
                Bill_Type.Text = dt.Rows[0][5].ToString();
                Bill_Total.Text = dt.Rows[0][6].ToString();
                Bills_Date.Text = dt.Rows[0][7].ToString();
                Bills_Notes.Text = dt.Rows[0][9].ToString();
                Bills_Paid.Checked = Convert.ToBoolean(dt.Rows[0][8]) ? true : false;
                StatePaied = Bills_Paid.Checked;// الاحتفاظ بحالة الدفع قبل التحديث من في حال اصبحت مدفوعة يعرض رسالة لاضافة سند دفع 
                Bills_Not.Checked = Convert.ToBoolean(dt.Rows[0][8]) ? false : true;
                Bills_Comb_Department.Text = dt.Rows[0][11].ToString();
                Bills_Comb_Budget.Text = dt.Rows[0][10].ToString();
                this.Bill_Objects_dataGrid.DataSource = Bill.Objects_View_By_Bill_ID(Bills_ID);
                this.Bill_Objects_dataGrid.Columns[0].Visible = false;
                this.Bill_Objects_dataGrid.Columns[5].Visible = false;
                Bills_Brows_Docs.Enabled = true;
                Bills_update.Enabled = true;

            }
            else 
            {
               this.Bill_Objects_dataGrid.DataSource = Bill.Objects_View_By_Bill_ID(-1);
               this.Bill_Objects_dataGrid.Columns[0].Visible = false;
               this.Bill_Objects_dataGrid.Columns[5].Visible = false;
               Bills_add.Enabled = true;
               Bills_update.Enabled = false;

            }
            this.Bill_Objects_dataGrid.Columns[4].ReadOnly = true;
        }

        private void Bills_new_Click(object sender, EventArgs e)
        {
            Bills_add.Enabled = true;
            Bills_Brows_Docs.Enabled = false;
            Bills_Buyer_Name.Text = "";
            Bills_Coin_Type.Text = "";
            Bills_Exchange_rate.Text = "";
            Bill_Type.Text = "";
            Bill_Total.Text = "";
            Bills_Notes.Text = "";
            Bills_NO_Bill.Text = "";
            this.Bill_Objects_dataGrid.DataSource = Bill.Objects_View_By_Bill_ID(-1);
            this.Bill_Objects_dataGrid.Columns[0].Visible = false;
            this.Bill_Objects_dataGrid.Columns[5].Visible = false;
        }

        private void Bills_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bills_dataGrid_Click(object sender, EventArgs e)
        {
            if (Bill_Objects_dataGrid.CurrentRow != null)
            {
                Bills_update.Enabled = false;
                Bills_delete.Enabled = false;
                Bills_add.Enabled = true;
            }
        }

        private void Bills_add_Click(object sender, EventArgs e)
        {
            if (Bills_NO_Bill.Text=="")
            {
                Program.Special_Message("يجب اضافة رقم الفاتورة");return;
            }
            if (Bills_Buyer_Name.Text == "")
            {
                Program.Special_Message("يجب اضافة اسم البائع"); return;
            }
            if (Bills_Coin_Type.Text == "")
            {
                Program.Special_Message("يجب اختيار نوع العملة"); return;
            }
            if (Bills_Coin_Type.Text == "دولار" && Bills_Exchange_rate.Text=="")
            {
                Program.Special_Message("يجب اضافة قيمة التحويل"); return;
            }
            if (!(Bill_Objects_dataGrid.Rows.Count-1  >0))
            {
                MessageBox.Show("لا يمكنك اضافة فاتورة دون مواد","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            Bill.Bills_Details_add(Convert.ToInt32(Bills_NO_Bill.Text), Bills_Buyer_Name.Text, Bills_Coin_Type.Text, Bills_Exchange_rate.Text, Bill_Type.Text,
            Bill_Total.Text, Bills_Date.Value, Bills_Paid.Checked, Bills_Notes.Text, Convert.ToInt32(Bills_Comb_Budget.SelectedValue), Convert.ToInt32(Bills_Comb_Department.SelectedValue));
            _Bill_ID = Convert.ToInt32(obj.Bill_Max_ID().Rows[0][0]);
            for (int i = 0; i < Bill_Objects_dataGrid.RowCount-1; i++)
            {
                obj.Bills_Object_add(Bill_Objects_dataGrid.Rows[i].Cells[1].Value.ToString(), Bill_Objects_dataGrid.Rows[i].Cells[2].Value.ToString(),
                    Bill_Objects_dataGrid.Rows[i].Cells[3].Value.ToString(), Bill_Objects_dataGrid.Rows[i].Cells[4].Value.ToString(),
                    _Bill_ID);
            }
            Bills_FORM frm= Bills_FORM.getMainForm;
            frm.Bills_dataGrid.DataSource = obj.Bills_View();
            this.Bill_Objects_dataGrid.DataSource = Bill.Objects_View_By_Bill_ID(-1);
            this.Bill_Objects_dataGrid.Columns[0].Visible = false;
            this.Bill_Objects_dataGrid.Columns[5].Visible = false;

            if (MessageBox.Show("هل تريد اضافة ملحقات لهذه الفاتورة؟","ملحقات",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                Document_FORM FRM = new Document_FORM(_Bill_ID, "فاتورة");
                FRM.ShowDialog();
            }
            Program.Add_Message();

            if (Bills_Paid.Checked)
            {
                if (MessageBox.Show("هل تريد اضافة سند دفع لهذه الفاتورة بما أن قيمتها مدفوعة ؟؟","سند دفع",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    Payment_Document_FORM FRM = new Payment_Document_FORM();
                    FRM.ShowDialog();
                } 
            }
            Bills_add.Enabled = false;
            Bills_Brows_Docs.Enabled = false;
            Bills_Buyer_Name.Text = "";
            Bills_Coin_Type.Text = "";
            Bills_Exchange_rate.Text = "";
            Bill_Type.Text = "";
            Bill_Total.Text = "";
            Bills_Notes.Text = "";
            Bills_NO_Bill.Text = "";
        }

        private void Bills_update_Click(object sender, EventArgs e)
        {
            if (!(Bill_Objects_dataGrid.Rows.Count-1 > 1))
            {
                MessageBox.Show("لا يمكنك حذف جميع مواد الفاتورة وتعديلها", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Bill.Bills_Details_update(Convert.ToInt32(Bills_NO_Bill.Text), Bills_Buyer_Name.Text, Bills_Coin_Type.Text, Bills_Exchange_rate.Text, Bill_Type.Text,
             Bill_Total.Text, Bills_Date.Value, Bills_Paid.Checked, Bills_Notes.Text, Convert.ToInt32(Bills_Comb_Budget.SelectedValue), Convert.ToInt32(Bills_Comb_Department.SelectedValue) , _Bill_ID);
             obj.Bills_Object_Delete_ByBill_Id(_Bill_ID);
            for (int i = 0; i < Bill_Objects_dataGrid.RowCount - 1; i++)
            {
                obj.Bills_Object_add(Bill_Objects_dataGrid.Rows[i].Cells[1].Value.ToString(), Bill_Objects_dataGrid.Rows[i].Cells[2].Value.ToString(),
                    Bill_Objects_dataGrid.Rows[i].Cells[3].Value.ToString(), Bill_Objects_dataGrid.Rows[i].Cells[4].Value.ToString(),
                    _Bill_ID);
            }
            Bills_FORM frm = Bills_FORM.getMainForm;
            frm.Bills_dataGrid.DataSource = obj.Bills_View();
            this.Bill_Objects_dataGrid.DataSource = Bill.Objects_View_By_Bill_ID(_Bill_ID);
            if (!StatePaied && Bills_Paid.Checked)
            {
                if (MessageBox.Show("هل تريد اضافة سند دفع لهذه الفاتورة بما أن قيمتها اصبحت مدفوعة ؟؟", "سند دفع", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Payment_Document_FORM FRM = new Payment_Document_FORM();
                    FRM.ShowDialog();
                }
            }
            this.Bill_Objects_dataGrid.Columns[0].Visible = false;
            this.Bill_Objects_dataGrid.Columns[5].Visible = false;
            Program.Update_Message();

        }

        private void Bills_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف تفاصيل الفاتورة .اذا تم الحذف فسيتم حذف كافة تفاصيلها من البرنامج؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Bill.Bills_Details_Delete(_Bill_ID);
                this.Bill_Objects_dataGrid.DataSource = Bill.Objects_View_By_Bill_ID(_Bill_ID);
                this.Bill_Objects_dataGrid.Columns[0].Visible = false;
                this.Bill_Objects_dataGrid.Columns[5].Visible = false;

                Bills_FORM frm = Bills_FORM.getMainForm;
                frm.Bills_dataGrid.DataSource = obj.Bills_View();
                Program.Delete_Message();
                if (_Bill_ID==-1)
                {
                    Bills_update.Enabled = false;
                    Bills_delete.Enabled = false;
                }
                Bills_Brows_Docs.Enabled = false;
                Bills_Buyer_Name.Text = "";
                Bills_Coin_Type.Text = "";
                Bills_Exchange_rate.Text = "";
                Bill_Type.Text = "";
                Bill_Total.Text = "";
                Bills_Notes.Text = "";
                Bills_NO_Bill.Text = "";
            }
        }

        private void Bills_Details_Print_Click(object sender, EventArgs e)
        {
            REPT.Crystal_Bills_Details Report = new REPT.Crystal_Bills_Details();
            REPT.FRM_Report myfprm = new REPT.FRM_Report();
            Report.SetParameterValue("@Bill_iid", Program.Bill_Id);
            // Report.Refresh();
            myfprm.crystalReportViewer1.ReportSource = Report;
            myfprm.ShowDialog();
        }

        private void Bills_NO_Bill_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Bills_Coin_Type_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Bills_Exchange_rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Bill_Type_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Bill_Total_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Bills_Add_Doc_Click(object sender, EventArgs e)
        {
            if (_Bill_ID != -1)
            {
                _Bill_ID = Convert.ToInt32(obj.Bill_Max_ID().Rows[0][0]);
                Document_FORM FRM = new Document_FORM(_Bill_ID, "فاتورة");
                FRM.ShowDialog();
            }
            else
            {
                Document_FORM FRM = new Document_FORM(_Bill_ID, "فاتورة");
                FRM.ShowDialog();
            }
        }


        private void Bill_Objects_dataGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (Bill_Objects_dataGrid.CurrentCell.ColumnIndex == 2|| Bill_Objects_dataGrid.CurrentCell.ColumnIndex==3)
            {
                if (!(Bill_Objects_dataGrid.Rows[Bill_Objects_dataGrid.CurrentCell.RowIndex].Cells[1].Value is DBNull))
                {
                        Bill_Objects_dataGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
                else
                {
                    MessageBox.Show("يجب اضافة اسم المادة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bill_Objects_dataGrid.CurrentCell.Value = 1;
                }
            }

        }

        private void Bill_Objects_dataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex ==3)
            {
                double test;
                if (!double.TryParse(Bill_Objects_dataGrid.CurrentCell.Value.ToString(), out test))
                {
                    MessageBox.Show("يجب ان تكون الكمية والالسعر الافرادي قيمة رقمية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bill_Objects_dataGrid.CurrentCell.Value = 1;
                    return;
                }
                double cellPrice = Bill_Objects_dataGrid.Rows[e.RowIndex].Cells[2].Value is DBNull ? 1 : Convert.ToDouble(Bill_Objects_dataGrid.Rows[e.RowIndex].Cells[2].Value);
                double cellQty = Bill_Objects_dataGrid.Rows[e.RowIndex].Cells[3].Value is DBNull ? 1 : Convert.ToDouble(Bill_Objects_dataGrid.Rows[e.RowIndex].Cells[3].Value);
                Bill_Objects_dataGrid.Rows[e.RowIndex].Cells[4].Value = cellQty * cellPrice;
            }
            if (e.ColumnIndex == 3)
            {
                for (int i = 0; i < Bill_Objects_dataGrid.Rows.Count; i++)
                {
                    Bill_Total.Text = (double.TryParse(Bill_Total.Text, out double temp) ? 0 : temp + Convert.ToDouble(Bill_Objects_dataGrid.Rows[i].Cells[4].Value)).ToString();
                }
            }
        }

        private void Bills_Brows_Docs_Click(object sender, EventArgs e)
        {
            Document_FORM FRM = new Document_FORM(_Bill_ID, "فاتورة");
            FRM.ShowDialog();
        }
    }
}
