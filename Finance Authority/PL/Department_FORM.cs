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
    public partial class Department_FORM : MetroFramework.Forms.MetroForm
    {
        BL.Department Dep = new BL.Department();
        BL.Authority Auth = new BL.Authority();
        BL.CLS_LOGS LOG = new BL.CLS_LOGS();
        public Department_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            this.Department_Gridview.DataSource = Dep.Department_View();
            this.Department_Gridview.Columns[0].Visible = false;
            this.Department_Gridview.Columns[4].Visible = false;
            Department_CombAuthority.DataSource = Auth.Authority_view();
            Department_CombAuthority.DisplayMember = "اسم الهيئة";
            Department_CombAuthority.ValueMember = "Authority_ID";
        }

        private void Department_new_Click(object sender, EventArgs e)
        {
            Department_add.Enabled = true;
            Department_Name.Text = "";
            Department_Notes.Text = "";
            Department_update.Enabled = false;
            Department_delete.Enabled = false;
        }

        private void Department_add_Click(object sender, EventArgs e)
        {
            if (Department_CombAuthority.SelectedIndex == -1)
            {

                MessageBox.Show("يجب اختيار اسم الهيئة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Department_CombOffice.SelectedIndex == -1)
            {

                MessageBox.Show("يجب اختيار اسم المكتب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Department_Name.Text == String.Empty)
            {

                MessageBox.Show("أضف اسم القسم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable Dt = new DataTable();
            Dt = Dep.Department_Cheack(Department_Name.Text , Convert.ToInt32(Department_CombOffice.SelectedValue));
            if (Dt.Rows.Count == 0)
            {
                Dep.Department_add(Department_Name.Text, Department_Notes.Text, Convert.ToInt32(Department_CombOffice.SelectedValue));
                this.Department_Gridview.DataSource = Dep.Department_View();
                this.Department_Gridview.Columns[0].Visible = false;
                this.Department_Gridview.Columns[4].Visible = false;
                Program.Add_Message();
                LOG.LOGS_add(Program.USER_ID, "اضافة", "اضافة قسم جديد", DateTime.Now);
                Department_Name.Text = "";
                Department_Notes.Text = "";
                Department_add.Enabled = false;
            }
            else
            {
                MessageBox.Show("موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
           
        }

        private void Department_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Department_update_Click(object sender, EventArgs e)
        {
            if (Department_CombAuthority.SelectedIndex == -1)
            {

                MessageBox.Show("يجب اختيار اسم الهيئة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Department_CombOffice.SelectedIndex == -1)
            {

                MessageBox.Show("يجب اختيار اسم المكتب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Department_Name.Text == String.Empty)
            {

                MessageBox.Show("أضف أسم القسم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable Dt = new DataTable();
            Dt = Dep.Department_Cheack(Department_Name.Text , Convert.ToInt32(Department_CombOffice.SelectedValue));
            if (Dt.Rows.Count == 0 || Department_Name.Text == this.Department_Gridview.CurrentRow.Cells[1].Value.ToString())
            {
                Dep.Department_update(Convert.ToInt32(Department_CombOffice.SelectedValue), Department_Name.Text, Department_Notes.Text, Program.Department_ID);
                this.Department_Gridview.DataSource = Dep.Department_View();
                this.Department_Gridview.Columns[0].Visible = false;
                this.Department_Gridview.Columns[4].Visible = false;
                Program.Update_Message();
                LOG.LOGS_add(Program.USER_ID, "تعديل", "تعديل قسم", DateTime.Now);
                Department_Name.Text = "";
                Department_Notes.Text = "";
                Department_update.Enabled = false;
                Department_delete.Enabled = false;
            }
            else
            {
                MessageBox.Show("موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
           
        }

        private void Department_Gridview_Click(object sender, EventArgs e)
        {
            if (Department_Gridview.CurrentRow != null)
            {
                Program.Department_ID = Convert.ToInt32(this.Department_Gridview.CurrentRow.Cells[0].Value.ToString());
                Department_Name.Text = this.Department_Gridview.CurrentRow.Cells[1].Value.ToString();
                Department_Notes.Text = this.Department_Gridview.CurrentRow.Cells[2].Value.ToString();
                Department_CombOffice.Text = this.Department_Gridview.CurrentRow.Cells[3].Value.ToString();
                Department_CombAuthority.Text= this.Department_Gridview.CurrentRow.Cells[4].Value.ToString();
                Department_update.Enabled = true;
                Department_delete.Enabled = true;
                Department_add.Enabled = false;
            }
        }

        private void Department_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف القسم .اذا تم الحذف فسيتم حذف كافة تفاصيلها من البرنامج؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dep.Department_Delete(Program.Department_ID);
                this.Department_Gridview.DataSource = Dep.Department_View();
                this.Department_Gridview.Columns[0].Visible = false;
                this.Department_Gridview.Columns[4].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LOG.LOGS_add(Program.USER_ID, "حذف", "حذف قسم", DateTime.Now);
                Department_Name.Text = "";
                Department_Notes.Text = "";
                Department_update.Enabled = false;
                Department_delete.Enabled = false;
            }
        }

       
        private void Department_textsearch_TextChanged_1(object sender, EventArgs e)
        {
            this.Department_Gridview.DataSource = Dep.Department_Search(Department_textsearch.Text);
            this.Department_Gridview.Columns[0].Visible = false;
            this.Department_Gridview.Columns[4].Visible = false;
        }

        private void Department_CombAuthority_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idAuthority = Convert.ToInt32(Department_CombAuthority.SelectedValue);
                //MessageBox.Show(Contracts_Comb_Department.SelectedValue.GetType().ToString());
                Department_CombOffice.DataSource = Dep.Department_CombAuthority_Office(idAuthority);
                Department_CombOffice.DisplayMember = "Office_Name";
                Department_CombOffice.ValueMember = "Office_ID";

            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}
