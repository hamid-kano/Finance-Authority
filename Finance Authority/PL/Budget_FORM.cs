﻿using System;
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
        BL.CLS_LOGS LOG = new BL.CLS_LOGS();
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
                Budget_delete.Enabled = true;
            }
        }
        private void Budget_delete_Click(object sender, EventArgs e)
        {
            if (Program.Budget_Id==Convert.ToInt32(Bud.Budget_Last_Budget().Rows[0][0]))
            {
                if (MessageBox.Show("هل تريد الحذف بالتاكيد .. اذا قمت بحذ الميزانية الحالية سيتم حذف جميع سندات الدفع و القبض وكا مايتعلق بهذه الميزانية؟؟  ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Bud.Budget_Delete(Program.Budget_Id);
                    this.Budget_dataGrid.DataSource = Bud.Budget_view();
                    this.Budget_dataGrid.Columns[0].Visible = false;
                    MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LOG.LOGS_add(Program.USER_ID, "حذف", "حذف ميزانية", DateTime.Now);
                    Budget_amount_sy.Text = "";
                    Budget_amount_Dollar.Text = "";
                    Budget_import_sy.Text = "";
                    Budget_import_Dollar.Text = "";
                    Budget_Recycle_Sy.Text = "";
                    Budget_Recycle_Dollar.Text = "";
                    Budget_spicified_Sy.Text = "";
                    Budget_spicified_Dollar.Text = "";
                    Budget_Notes.Text = "";
                    Budget_delete.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("لا يمكنك حذف ميزانية سابقة", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Budget_amount_sy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Budget_amount_Dollar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Budget_import_sy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Budget_import_Dollar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Budget_Recycle_Sy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Budget_Recycle_Dollar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Budget_spicified_Sy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void Budget_spicified_Dollar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Program.DenyChar(e);
        }

        private void update_Click(object sender, EventArgs e)
        {
            this.Budget_dataGrid.DataSource = Bud.Budget_view();
            this.Budget_dataGrid.Columns[0].Visible = false;
        }
    }
}
