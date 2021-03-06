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
    public partial class Authority_FORM : MetroFramework.Forms.MetroForm
    {
        BL.Authority Auth = new BL.Authority();
        BL.CLS_LOGS LOG = new BL.CLS_LOGS();
        public Authority_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            this.Authority_Gridview.DataSource = Auth.Authority_view();
            Authority_Gridview.Columns[0].Visible = false;
        }

        private void Authority_new_Click(object sender, EventArgs e)
        {
            Authority_add.Enabled = true;
            Authority_Name.Text = "";
            Authority_Notes.Text = "";
            Authority_update.Enabled = false;
            Authority_delete.Enabled = false;
        }

        private void Authority_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Authority_add_Click(object sender, EventArgs e)
        {
            if (Authority_Name.Text == String.Empty)
            {

                MessageBox.Show("أضف اسم الهيئة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable Dt = new DataTable();
            Dt = Auth.Authority_Cheack(Authority_Name.Text);
            if (Dt.Rows.Count == 0)
            {
                Auth.Authority_add(Authority_Name.Text, Authority_Notes.Text);
                this.Authority_Gridview.DataSource = Auth.Authority_view();
                Authority_Gridview.Columns[0].Visible = false;
                Program.Add_Message();
                LOG.LOGS_add(Program.USER_ID , "اضافة","اضافة هيئة جديدة", DateTime.Now);
                Authority_Name.Text = "";
                Authority_Notes.Text = "";
                Authority_add.Enabled = false;
            }
            else
            {
                MessageBox.Show("موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
           
        }

        private void Authority_Gridview_Click(object sender, EventArgs e)
        {
            if (Authority_Gridview.CurrentRow != null)
            {
                Program.Authority_ID = Convert.ToInt32(this.Authority_Gridview.CurrentRow.Cells[0].Value.ToString());
                Authority_Name.Text = this.Authority_Gridview.CurrentRow.Cells[1].Value.ToString();
                Authority_Notes.Text = this.Authority_Gridview.CurrentRow.Cells[2].Value.ToString();
                Authority_update.Enabled = true;
                Authority_delete.Enabled = true;
                Authority_add.Enabled = false;
            }
        }

        private void Authority_update_Click(object sender, EventArgs e)
        {
            if (Authority_Name.Text == String.Empty)
            {

                MessageBox.Show("أضف اسم الهيئة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable Dt = new DataTable();
            Dt = Auth.Authority_Cheack(Authority_Name.Text);
            if (Dt.Rows.Count == 0 || Authority_Name.Text == this.Authority_Gridview.CurrentRow.Cells[1].Value.ToString())
            {
                Auth.Authority_update(Program.Authority_ID, Authority_Name.Text, Authority_Notes.Text);
                this.Authority_Gridview.DataSource = Auth.Authority_view();
                Authority_Gridview.Columns[0].Visible = false;
                Program.Update_Message();
                LOG.LOGS_add(Program.USER_ID, "تعديل", "تعديل هيئة", DateTime.Now);
                Authority_Name.Text = "";
                Authority_Notes.Text = "";
                Authority_update.Enabled = false;
                Authority_delete.Enabled = false;
            }
            else
            {
                MessageBox.Show("موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
           
        }

        private void Authority_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف الهيئة .أذا تم الحذف فسيتم حذف كافة تفاصيلها من البرنامج؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Auth.Authority_Delete(Program.Authority_ID);
                this.Authority_Gridview.DataSource = Auth.Authority_view();
                Authority_Gridview.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LOG.LOGS_add(Program.USER_ID, "حذف", "حذف هيئة", DateTime.Now);
                Authority_Name.Text = "";
                Authority_Notes.Text = "";
                Authority_update.Enabled = false;
                Authority_delete.Enabled = false;
            }
        }
        private void Authority_textsearch_TextChanged_1(object sender, EventArgs e)
        {
            this.Authority_Gridview.DataSource = Auth.Authority_Search_Name(Authority_textsearch.Text);
            Authority_Gridview.Columns[0].Visible = false;
        }
    }
}
