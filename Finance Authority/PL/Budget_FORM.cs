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
    public partial class Budget_FORM : MetroFramework.Forms.MetroForm
    { BL.CLS_Budget Bud = new BL.CLS_Budget();
        public Budget_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            this.Budget_dataGrid.DataSource = Bud.Budget_view();
            this.Budget_dataGrid.Columns[0].Visible = false;
        }

        private void Budget_xit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Budget_new_Click(object sender, EventArgs e)
        {
            Budget_add.Enabled = true;
            Budget_amount_sy.Text = "";
            Budget_amount_Dollar.Text = "";
            Budget_import_sy.Text = "";
            Budget_import_Dollar.Text = "";
            Budget_Recycle_Sy.Text = "";
            Budget_Recycle_Dollar.Text = "";
            Budget_spicified_Sy.Text = "";
            Budget_spicified_Dollar.Text = "";
            Budget_Notes.Text = "";
            Budget_update.Enabled = false;
            Budget_delete.Enabled = false;
        }
   

        private void Budget_add_Click(object sender, EventArgs e)
        {
            Bud.Budget_add(Budget_amount_sy.Text, Budget_amount_Dollar.Text, Budget_import_sy.Text , Budget_import_Dollar.Text, Budget_Recycle_Sy.Text , Budget_Recycle_Dollar.Text, Budget_spicified_Sy.Text , Budget_spicified_Dollar.Text , Budget_Notes.Text , Budget_DateTime.Value);
            this.Budget_dataGrid.DataSource = Bud.Budget_view();
            this.Budget_dataGrid.Columns[0].Visible = false;
            MessageBox.Show("تم الأضافة بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Budget_amount_sy.Text = "";
            Budget_amount_Dollar.Text = "";
            Budget_import_sy.Text = "";
            Budget_import_Dollar.Text = "";
            Budget_Recycle_Sy.Text = "";
            Budget_Recycle_Dollar.Text = "";
            Budget_spicified_Sy.Text = "";
            Budget_spicified_Dollar.Text = "";
            Budget_Notes.Text = "";
            Budget_add.Enabled = false;
        }

        private void Budget_dataGrid_Click(object sender, EventArgs e)
        {
            if (Budget_dataGrid.CurrentRow != null)
            {
                Program.Budget_Id = Convert.ToInt32(this.Budget_dataGrid.CurrentRow.Cells[0].Value.ToString());
                Budget_amount_sy.Text = this.Budget_dataGrid.CurrentRow.Cells[1].Value.ToString();
                Budget_amount_Dollar.Text = this.Budget_dataGrid.CurrentRow.Cells[2].Value.ToString();
                Budget_import_sy.Text = this.Budget_dataGrid.CurrentRow.Cells[3].Value.ToString();
                Budget_import_Dollar.Text = this.Budget_dataGrid.CurrentRow.Cells[4].Value.ToString();
                Budget_Recycle_Sy.Text = this.Budget_dataGrid.CurrentRow.Cells[5].Value.ToString();
                Budget_Recycle_Dollar.Text = this.Budget_dataGrid.CurrentRow.Cells[6].Value.ToString();
                Budget_spicified_Sy.Text = this.Budget_dataGrid.CurrentRow.Cells[7].Value.ToString();
                Budget_spicified_Dollar.Text = this.Budget_dataGrid.CurrentRow.Cells[8].Value.ToString();
                Budget_DateTime.Text = this.Budget_dataGrid.CurrentRow.Cells[9].Value.ToString();
                Budget_Notes.Text = this.Budget_dataGrid.CurrentRow.Cells[10].Value.ToString();
                Budget_update.Enabled = true;
                Budget_delete.Enabled = true;
            }
        }

        private void Budget_update_Click(object sender, EventArgs e)
        {
            Bud.Budget_update(Budget_amount_sy.Text, Budget_amount_Dollar.Text, Budget_import_sy.Text, Budget_import_Dollar.Text, Budget_Recycle_Sy.Text, Budget_Recycle_Dollar.Text, Budget_spicified_Sy.Text, Budget_spicified_Dollar.Text, Budget_Notes.Text, Budget_DateTime.Value , Program.Budget_Id);
            this.Budget_dataGrid.DataSource = Bud.Budget_view();
            this.Budget_dataGrid.Columns[0].Visible = false;
            MessageBox.Show("تم التعديل بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Budget_amount_sy.Text = "";
            Budget_amount_Dollar.Text = "";
            Budget_import_sy.Text = "";
            Budget_import_Dollar.Text = "";
            Budget_Recycle_Sy.Text = "";
            Budget_Recycle_Dollar.Text = "";
            Budget_spicified_Sy.Text = "";
            Budget_spicified_Dollar.Text = "";
            Budget_Notes.Text = "";
            Budget_update.Enabled = false;
            Budget_delete.Enabled = false;
        }

        private void Budget_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف؟؟  ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Bud.Budget_Delete(Program.Budget_Id);
                this.Budget_dataGrid.DataSource = Bud.Budget_view();
                this.Budget_dataGrid.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Budget_amount_sy.Text = "";
                Budget_amount_Dollar.Text = "";
                Budget_import_sy.Text = "";
                Budget_import_Dollar.Text = "";
                Budget_Recycle_Sy.Text = "";
                Budget_Recycle_Dollar.Text = "";
                Budget_spicified_Sy.Text = "";
                Budget_spicified_Dollar.Text = "";
                Budget_Notes.Text = "";
                Budget_update.Enabled = false;
                Budget_delete.Enabled = false;
            }
        }
        private void Budget_Date_first_ValueChanged_1(object sender, EventArgs e)
        {
            this.Budget_dataGrid.DataSource =Bud.Budget_Date_Between(Budget_Date_first.Value, Budget_Date_last.Value);
            this.Budget_dataGrid.Columns[0].Visible = false;
        }

        private void Budget_Date_last_ValueChanged_1(object sender, EventArgs e)
        {
            this.Budget_dataGrid.DataSource = Bud.Budget_Date_Between(Budget_Date_first.Value, Budget_Date_last.Value);
            this.Budget_dataGrid.Columns[0].Visible = false;
        }
    }
}
