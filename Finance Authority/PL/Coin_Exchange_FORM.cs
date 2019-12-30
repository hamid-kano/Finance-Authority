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
    public partial class Coin_Exchange_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Coin_Exchange Coin = new BL.CLS_Coin_Exchange();
        BL.CLS_Budget Bud = new BL.CLS_Budget();
        BL.CLS_LOGS LOG = new BL.CLS_LOGS();
        public Coin_Exchange_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            Coin_Exchange_CombSerach.DataSource = Coin.Coin_Exchange_CombBudg();
            Coin_Exchange_CombSerach.DisplayMember = "Date";
            Coin_Exchange_CombSerach.ValueMember = "Budget_Id";
            this.Coin_Exchange_Gridview.DataSource = Coin.Coin_Exchange_View();
            Coin_Exchange_Gridview.Columns[0].Visible = false;
            Coin_Exchange_CombBudge.DataSource = Bud.Budget_combo_Last_Budget();
            Coin_Exchange_CombBudge.DisplayMember = "Date";
            Coin_Exchange_CombBudge.ValueMember = "Budget_Id";


        }

        private void Coin_Exchange_new_Click(object sender, EventArgs e)
        {
            Coin_Exchange_add.Enabled = true;
            Coin_Exchange_update.Enabled = false;
            Coin_Exchange_delete.Enabled = false;
            Coin_Exchange_Sy.Text = "";
            Coin_Exchange_Dollar.Text = "";
            Coin_Exchange_rate.Text = "";
            Coin_Exchange_Notes.Text = "";

        }

        private void Coin_Exchange_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Coin_Exchange_Gridview_Click(object sender, EventArgs e)
        {
            if (Coin_Exchange_Gridview.CurrentRow != null)
            {
                Program.Coin_Exchange_id = Convert.ToInt32(this.Coin_Exchange_Gridview.CurrentRow.Cells[0].Value.ToString());
                Coin_Exchange_Sy.Text = this.Coin_Exchange_Gridview.CurrentRow.Cells[1].Value.ToString();
                Coin_Exchange_Dollar.Text = this.Coin_Exchange_Gridview.CurrentRow.Cells[2].Value.ToString();
                Coin_Exchange_rate.Text = this.Coin_Exchange_Gridview.CurrentRow.Cells[3].Value.ToString();
                Coin_Exchange_Date.Text = this.Coin_Exchange_Gridview.CurrentRow.Cells[4].Value.ToString();
                Coin_Exchange_Notes.Text = this.Coin_Exchange_Gridview.CurrentRow.Cells[5].Value.ToString();
                Coin_Exchange_CombBudge.Text = this.Coin_Exchange_Gridview.CurrentRow.Cells[6].Value.ToString();
                Coin_EX_RB_DtoS.Checked = Convert.ToBoolean(this.Coin_Exchange_Gridview.CurrentRow.Cells[7].Value) ? true : false;
                Coin_EX_RB_StoD.Checked = Convert.ToBoolean(this.Coin_Exchange_Gridview.CurrentRow.Cells[7].Value) ? false : true;
                Coin_Exchange_update.Enabled = true;
                Coin_Exchange_delete.Enabled = true;
                Coin_Exchange_add.Enabled = false;
            }
        }

        private void Coin_Exchange_add_Click(object sender, EventArgs e)
        {
            if (Coin_Exchange_Sy.Text == String.Empty)
            {

                MessageBox.Show("ادخل المبلغ بالسوري", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Coin_Exchange_Dollar.Text == String.Empty)
            {

                MessageBox.Show("ادخل المبلغ بالدولار", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Coin_Exchange_rate.Text == String.Empty)
            {

                MessageBox.Show("ادخل قيمة التحويل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Coin_Exchange_CombBudge.SelectedIndex == -1)
            {

                MessageBox.Show("يجب اختيار الميزانية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Coin.Coin_Exchange_add(Coin_Exchange_Sy.Text, Coin_Exchange_Dollar.Text, Coin_Exchange_rate.Text, Coin_Exchange_Date.Value, Coin_Exchange_Notes.Text, Convert.ToInt32(Coin_Exchange_CombBudge.SelectedValue),Coin_EX_RB_DtoS.Checked);
            //// تحديث الميزانية
            if (Coin_EX_RB_StoD.Checked)
            {
                // اذا كان التحويل من سوري الى دولار يتم انقاص المبلغ السوري من الميزانية وزيادة مبلغ الدولار
                Program.Budget_update_after_Payment_Reciver("P", Coin_Exchange_Sy.Text, "0");
                Program.Budget_update_after_Payment_Reciver("R", "0", Coin_Exchange_Dollar.Text);
            }
            else
            {
                // اذا كان التحويل من دولار الى سوري يتم انقاص المبلغ بالدولار من الميزانية وزيادة مبلغ السوري
                Program.Budget_update_after_Payment_Reciver("P","0", Coin_Exchange_Dollar.Text);
                Program.Budget_update_after_Payment_Reciver("R", Coin_Exchange_Sy.Text, "0");
            }
            ///            
            this.Coin_Exchange_Gridview.DataSource = Coin.Coin_Exchange_View();
            Coin_Exchange_Gridview.Columns[0].Visible = false;
            Program.Add_Message();
            LOG.LOGS_add(Program.USER_ID, "اضافة", "اضافة تحويل عملة جديدة", DateTime.Now);
            Coin_Exchange_Sy.Text = "";
            Coin_Exchange_Dollar.Text = "";
            Coin_Exchange_rate.Text = "";
            Coin_Exchange_Notes.Text = "";
            Coin_Exchange_add.Enabled = false;
        }

        private void Coin_Exchange_update_Click(object sender, EventArgs e)
        {
            if (Coin_Exchange_Sy.Text == String.Empty)
            {

                MessageBox.Show("ادخل المبلغ بالسوري", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Coin_Exchange_Dollar.Text == String.Empty)
            {

                MessageBox.Show("ادخل المبلغ بالدولار", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Coin_Exchange_rate.Text == String.Empty)
            {

                MessageBox.Show("ادخل قيمة التحويل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // كانت من دولار الى سوري واصبحت من سوري الى دولار
            if (Convert.ToBoolean(this.Coin_Exchange_Gridview.CurrentRow.Cells[7].Value)&& Coin_EX_RB_StoD.Checked)
            {
                // ارجاع مبلغ الدولار الى الميزانية ومن ثم انقاص المبلغ السوري من الميزانية
                Program.Budget_update_after_Payment_Reciver("R", "0", this.Coin_Exchange_Gridview.CurrentRow.Cells[2].Value.ToString());
                Program.Budget_update_after_Payment_Reciver("P", this.Coin_Exchange_Gridview.CurrentRow.Cells[1].Value.ToString(), "0");
            }
            // كانت من سوري الى دولار واصبحت من دولار الى سوري
            else if(!Convert.ToBoolean(this.Coin_Exchange_Gridview.CurrentRow.Cells[7].Value) && Coin_EX_RB_DtoS.Checked)
            {
                // يتم ارجاع مبلغ السوري الى الميزانية ويتم انقاص مبلغ الدولار من الميزانية
                Program.Budget_update_after_Payment_Reciver("R", this.Coin_Exchange_Gridview.CurrentRow.Cells[1].Value.ToString(),"0");
                Program.Budget_update_after_Payment_Reciver("P", "0", this.Coin_Exchange_Gridview.CurrentRow.Cells[2].Value.ToString());
            }
            /// معالجة التحديث في حال بقيت دون عكس التحويل
            if (Coin_EX_RB_StoD.Checked)
            {
                // اذا كان التحويل من سوري الى دولار يتم انقاص المبلغ السوري من الميزانية وزيادة مبلغ الدولار
                Program.Budget_update_after_Payment_Reciver("P", Coin_Exchange_Sy.Text, "0");
                Program.Budget_update_after_Payment_Reciver("R", "0", Coin_Exchange_Dollar.Text);
            }
            else
            {
                // اذا كان التحويل من دولار الى سوري يتم انقاص المبلغ بالدولار من الميزانية وزيادة مبلغ السوري
                Program.Budget_update_after_Payment_Reciver("P", "0", Coin_Exchange_Dollar.Text);
                Program.Budget_update_after_Payment_Reciver("R", Coin_Exchange_Sy.Text, "0");
            }
            Coin.Coin_Exchange_update(Coin_Exchange_Sy.Text, Coin_Exchange_Dollar.Text, Coin_Exchange_rate.Text, Coin_Exchange_Date.Value, Coin_Exchange_Notes.Text, Convert.ToInt32(Coin_Exchange_CombBudge.SelectedValue), Coin_EX_RB_DtoS.Checked, Program.Coin_Exchange_id);
            this.Coin_Exchange_Gridview.DataSource = Coin.Coin_Exchange_View();
            Coin_Exchange_Gridview.Columns[0].Visible = false;
            Program.Update_Message();
            LOG.LOGS_add(Program.USER_ID, "تعديل", "تعديل تحويل عملة", DateTime.Now);
            Coin_Exchange_Sy.Text = "";
            Coin_Exchange_Dollar.Text = "";
            Coin_Exchange_rate.Text = "";
            Coin_Exchange_Notes.Text = "";
            Coin_Exchange_update.Enabled = false;
            Coin_Exchange_delete.Enabled = false;
        }

        private void Coin_Exchange_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف تحويل العملة .اذا تم الحذف فسيتم حذف كافة تفاصيلها من البرنامج؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                /// معالجة الحذف 
                if (Convert.ToBoolean(this.Coin_Exchange_Gridview.CurrentRow.Cells[7].Value))
                {
                    // اذا كان التحويل من دولار الى سوري يتم يتم ارجاع مبلغ الدولار وانقاص مبلغ السوري
                    Program.Budget_update_after_Payment_Reciver("P", "0", this.Coin_Exchange_Gridview.CurrentRow.Cells[2].Value.ToString());
                    Program.Budget_update_after_Payment_Reciver("R", this.Coin_Exchange_Gridview.CurrentRow.Cells[1].Value.ToString(), "0");
                }
                else
                {
                    // اذا كان التحويل من سوري الى دولار يتم ارجاع المبلغ السوري الى الميزانية وانقاص مبلغ الدولار
                    Program.Budget_update_after_Payment_Reciver("R", this.Coin_Exchange_Gridview.CurrentRow.Cells[1].Value.ToString(), "0");
                    Program.Budget_update_after_Payment_Reciver("P", "0", this.Coin_Exchange_Gridview.CurrentRow.Cells[2].Value.ToString());
                }
                /////
                Coin.Coin_Exchange_Delete(Program.Coin_Exchange_id);
                this.Coin_Exchange_Gridview.DataSource = Coin.Coin_Exchange_View();
                Coin_Exchange_Gridview.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LOG.LOGS_add(Program.USER_ID, "حذف", "حذف تحويل عملة", DateTime.Now);
                Coin_Exchange_Sy.Text = "";
                Coin_Exchange_Dollar.Text = "";
                Coin_Exchange_rate.Text = "";
                Coin_Exchange_Notes.Text = "";
                Coin_Exchange_update.Enabled = false;
                Coin_Exchange_delete.Enabled = false;
            }

        }

        private void Coin_Exchange_CombSerach_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int Datet = Convert.ToInt32(Coin_Exchange_CombSerach.SelectedValue);
                this.Coin_Exchange_Gridview.DataSource = Coin.Coin_Exchange_Search_Date_Budget(Datet);
                Coin_Exchange_Gridview.Columns[0].Visible = false;
            }
            catch { return; }
        }

        private void Coin_Exchange_Sy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Coin_Exchange_Dollar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Coin_Exchange_rate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void update_Click(object sender, EventArgs e)
        {
            this.Coin_Exchange_Gridview.DataSource = Coin.Coin_Exchange_View();
            Coin_Exchange_Gridview.Columns[0].Visible = false;
        }

        private void Coin_EX_RB_DtoS_CheckedChanged(object sender, EventArgs e)
        {
            Coin_Exchange_Sy.ReadOnly = true;
            Coin_Exchange_Dollar.ReadOnly = false;
        }

        private void Coin_EX_RB_StoD_CheckedChanged(object sender, EventArgs e)
        {
            Coin_Exchange_Dollar.ReadOnly = true;
            Coin_Exchange_Sy.ReadOnly = false;
        }

        private void Coin_Exchange_Sy_TextChanged(object sender, EventArgs e)
        {
            if (Coin_EX_RB_StoD.Checked)
            {
                Coin_Exchange_Dollar.Text = (double.TryParse(Coin_Exchange_Sy.Text, out double temp) ? temp * (double.TryParse(Coin_Exchange_rate.Text, out double rate) ? rate : 1)
                                             : 1 * (double.TryParse(Coin_Exchange_rate.Text, out double rate2) ? rate2 : 1)).ToString();
            }
        }

        private void Coin_Exchange_Dollar_TextChanged(object sender, EventArgs e)
        {
            if (Coin_EX_RB_DtoS.Checked)
            {
                Coin_Exchange_Sy.Text = (double.TryParse(Coin_Exchange_Dollar.Text, out double temp) ? temp * (double.TryParse(Coin_Exchange_rate.Text, out double rate) ? rate : 1)
                                                : 1 * (double.TryParse(Coin_Exchange_rate.Text, out double rate2) ? rate2 : 1)).ToString();

            }
        }

        private void Coin_Exchange_rate_TextChanged(object sender, EventArgs e)
        {
            if (Coin_EX_RB_DtoS.Checked)
            {
                Coin_Exchange_Sy.Text = (double.TryParse(Coin_Exchange_Dollar.Text, out double temp) ? temp * (double.TryParse(Coin_Exchange_rate.Text, out double rate) ? rate : 1)
                                                    : 1 * (double.TryParse(Coin_Exchange_rate.Text, out double rate2) ? rate2 : 1)).ToString();

            }
            else
            {
                Coin_Exchange_Dollar.Text = (double.TryParse(Coin_Exchange_Sy.Text, out double temp) ? temp * (double.TryParse(Coin_Exchange_rate.Text, out double rate) ? rate : 1)
                                             : 1 * (double.TryParse(Coin_Exchange_rate.Text, out double rate2) ? rate2 : 1)).ToString();
            }
        }
    }
}
