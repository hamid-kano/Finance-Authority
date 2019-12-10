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
        public Coin_Exchange_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            Coin_Exchange_CombSerach.DataSource = Coin.Coin_Exchange_CombBudg();
            Coin_Exchange_CombSerach.DisplayMember = "Date";
            Coin_Exchange_CombSerach.ValueMember = "Budget_Id";
            this.Coin_Exchange_Gridview.DataSource = Coin.Coin_Exchange_View();
            Coin_Exchange_Gridview.Columns[0].Visible = false;
            Coin_Exchange_CombBudge.DataSource = Coin.Coin_Exchange_CombBudg();
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
                Coin_Exchange_update.Enabled = true;
                Coin_Exchange_delete.Enabled = true;
            }
        }

        private void Coin_Exchange_add_Click(object sender, EventArgs e)
        {
            Coin.Coin_Exchange_add(Coin_Exchange_Sy.Text, Coin_Exchange_Dollar.Text, Coin_Exchange_rate.Text, Coin_Exchange_Date.Value, Coin_Exchange_Notes.Text, Convert.ToInt32(Coin_Exchange_CombBudge.SelectedValue));
            this.Coin_Exchange_Gridview.DataSource = Coin.Coin_Exchange_View();
            Coin_Exchange_Gridview.Columns[0].Visible = false;
            Program.Add_Message();
            Coin_Exchange_Sy.Text = "";
            Coin_Exchange_Dollar.Text = "";
            Coin_Exchange_rate.Text = "";
            Coin_Exchange_Notes.Text = "";
            Coin_Exchange_add.Enabled = false;
        }

        private void Coin_Exchange_update_Click(object sender, EventArgs e)
        {
            Coin.Coin_Exchange_update(Coin_Exchange_Sy.Text, Coin_Exchange_Dollar.Text, Coin_Exchange_rate.Text, Coin_Exchange_Date.Value, Coin_Exchange_Notes.Text, Convert.ToInt32(Coin_Exchange_CombBudge.SelectedValue), Program.Coin_Exchange_id);
            this.Coin_Exchange_Gridview.DataSource = Coin.Coin_Exchange_View();
            Coin_Exchange_Gridview.Columns[0].Visible = false;
            Program.Update_Message();
            Coin_Exchange_Sy.Text = "";
            Coin_Exchange_Dollar.Text = "";
            Coin_Exchange_rate.Text = "";
            Coin_Exchange_Notes.Text = "";
            Coin_Exchange_update.Enabled = false;
            Coin_Exchange_delete.Enabled = false;
        }

        private void Coin_Exchange_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف؟؟  ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Coin.Coin_Exchange_Delete(Program.Coin_Exchange_id);
                this.Coin_Exchange_Gridview.DataSource = Coin.Coin_Exchange_View();
                Coin_Exchange_Gridview.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
