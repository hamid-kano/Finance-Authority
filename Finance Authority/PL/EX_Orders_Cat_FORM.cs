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
    public partial class EX_Orders_Cat_FORM : MetroFramework.Forms.MetroForm
    {
        CLS_Exchange_Orders_Category cat = new CLS_Exchange_Orders_Category();
        
        public EX_Orders_Cat_FORM()
        {
            
            InitializeComponent();
            this.EX_Orders_Cat_dataGrid.DataSource = cat.EX_Orders_Cat_view();
            EX_Orders_Cat_dataGrid.Columns[0].Visible = false;
        }

        private void EX_Orders_Cat_new_Click(object sender, EventArgs e)
        {
            EX_Orders_Cat_add.Enabled = true;
            EX_Orders_Cat_text1.Text = "";
            EX_Orders_Cat_update.Enabled = false;
            EX_Orders_Cat_delete.Enabled = false;
        }

        private void EX_Orders_Cat_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EX_Orders_Cat_add_Click(object sender, EventArgs e)
        {
            if (EX_Orders_Cat_text1.Text == String.Empty)
            {

                MessageBox.Show("أضف واصفة الطلب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable Dt = new DataTable();
            Dt = cat.EX_Orders_Cat_Cheack(EX_Orders_Cat_text1.Text);
            if (Dt.Rows.Count == 0)
            {
                cat.EX_Orders_Cat_add(EX_Orders_Cat_text1.Text);
                MessageBox.Show("تم الأضافة بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EX_Orders_Cat_text1.Text = "";
                EX_Orders_Cat_add.Enabled = false;
                this.EX_Orders_Cat_dataGrid.DataSource = cat.EX_Orders_Cat_view();
                EX_Orders_Cat_dataGrid.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show("موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                EX_Orders_Cat_text1.Text = "";
                return;
            }
           
        }

        private void EX_Orders_Cat_dataGrid_Click(object sender, EventArgs e)
        {
            if (EX_Orders_Cat_dataGrid.CurrentRow != null)
            {
                EX_Orders_Cat_update.Enabled = true;
                EX_Orders_Cat_delete.Enabled = true;
               Program.Category_id= Convert.ToInt32(this.EX_Orders_Cat_dataGrid.CurrentRow.Cells[0].Value.ToString());
                EX_Orders_Cat_text1.Text = this.EX_Orders_Cat_dataGrid.CurrentRow.Cells[1].Value.ToString();
                EX_Orders_Cat_add.Enabled = false;
            }
        }

        private void EX_Orders_Cat_update_Click(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = cat.EX_Orders_Cat_Cheack(EX_Orders_Cat_text1.Text);
            if (Dt.Rows.Count == 0 || EX_Orders_Cat_text1.Text==this.EX_Orders_Cat_dataGrid.CurrentRow.Cells[1].Value.ToString())
            {
                cat.EX_Orders_Cat_update(Program.Category_id, EX_Orders_Cat_text1.Text);
                MessageBox.Show("تم التعديل بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EX_Orders_Cat_text1.Text = "";
                this.EX_Orders_Cat_dataGrid.DataSource = cat.EX_Orders_Cat_view();
                EX_Orders_Cat_dataGrid.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show("موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                EX_Orders_Cat_text1.Text = "";
                return;
            }
            
        }

        private void EX_Orders_Cat_delete_Click(object sender, EventArgs e)
        {
            cat.EX_Orders_Cat_Delete(Program.Category_id);
            MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EX_Orders_Cat_text1.Text = "";
            this.EX_Orders_Cat_dataGrid.DataSource = cat.EX_Orders_Cat_view();
            EX_Orders_Cat_dataGrid.Columns[0].Visible = false;
        }

        private void EX_Orders_Cat_textsearch_TextChanged(object sender, EventArgs e)
        {
            this.EX_Orders_Cat_dataGrid.DataSource =cat.EX_Orders_Cat_Search(EX_Orders_Cat_textsearch.Text);
            EX_Orders_Cat_dataGrid.Columns[0].Visible = false;
        }
    }
}
