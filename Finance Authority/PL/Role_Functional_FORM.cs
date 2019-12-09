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
    public partial class Role_Functional_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Role_Functional Role = new BL.CLS_Role_Functional();
        public Role_Functional_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            this.Role_Functional_Gridview.DataSource = Role.Role_Functional_View();
            Role_Functional_Gridview.Columns[0].Visible = false;
        }

        private void Role_Functional_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Role_Functional_new_Click(object sender, EventArgs e)
        {
            Role_Functional_add.Enabled = true;
            Role_Functional_Name.Text = "";
            Role_Functional_Notes.Text = "";
            Role_Functional_update.Enabled = false;
            Role_Functional_delete.Enabled = false;
        }

        private void Role_Functional_add_Click(object sender, EventArgs e)
        {
            if (Role_Functional_Name.Text == String.Empty)
            {

                MessageBox.Show("أدخل دور الموظف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable Dt = new DataTable();
            Dt = Role.Role_Functional_Cheack(Role_Functional_Name.Text);
            if (Dt.Rows.Count == 0)
            {
                Role.Role_Functional_add(Role_Functional_Name.Text, Role_Functional_Notes.Text);
                this.Role_Functional_Gridview.DataSource = Role.Role_Functional_View();
                Role_Functional_Gridview.Columns[0].Visible = false;
                Program.Add_Message();
                Role_Functional_Name.Text = "";
                Role_Functional_Notes.Text = "";
                Role_Functional_add.Enabled = false;
            }
            else
            {
                MessageBox.Show("موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
           
        }

        private void Role_Functional_Gridview_Click(object sender, EventArgs e)
        {
            if (Role_Functional_Gridview.CurrentRow != null)
            {
                Program.Role_Functional_id = Convert.ToInt32(this.Role_Functional_Gridview.CurrentRow.Cells[0].Value.ToString());
                Role_Functional_Name.Text = this.Role_Functional_Gridview.CurrentRow.Cells[1].Value.ToString();
                Role_Functional_Notes.Text = this.Role_Functional_Gridview.CurrentRow.Cells[2].Value.ToString();
                Role_Functional_update.Enabled = true;
                Role_Functional_delete.Enabled = true;
            }
        }

        private void Role_Functional_update_Click(object sender, EventArgs e)
        {
            if (Role_Functional_Name.Text == String.Empty)
            {

                MessageBox.Show("أدخل دور الموظف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable Dt = new DataTable();
            Dt = Role.Role_Functional_Cheack(Role_Functional_Name.Text);
            if (Dt.Rows.Count == 0 || Role_Functional_Name.Text== this.Role_Functional_Gridview.CurrentRow.Cells[1].Value.ToString())
            {
                Role.Role_Functional_update(Program.Role_Functional_id, Role_Functional_Name.Text, Role_Functional_Notes.Text);
                this.Role_Functional_Gridview.DataSource = Role.Role_Functional_View();
                Role_Functional_Gridview.Columns[0].Visible = false;
                MessageBox.Show("تم التعديل بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Role_Functional_Name.Text = "";
                Role_Functional_Notes.Text = "";
                Role_Functional_update.Enabled = false;
                Role_Functional_delete.Enabled = false;
            }
            else
            {
                MessageBox.Show("موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
           
        }

        private void Role_Functional_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف؟؟  ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Role.Role_Functional_Delete(Program.Role_Functional_id);
                this.Role_Functional_Gridview.DataSource = Role.Role_Functional_View();
                Role_Functional_Gridview.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Role_Functional_Name.Text = "";
                Role_Functional_Notes.Text = "";
                Role_Functional_update.Enabled = false;
                Role_Functional_delete.Enabled = false;
            }
        }

        private void Role_Functional_textsearch_TextChanged(object sender, EventArgs e)
        {
            this.Role_Functional_Gridview.DataSource = Role.Role_Functional_Search(Role_Functional_textsearch.Text);
            Role_Functional_Gridview.Columns[0].Visible = false;
        }
    }
}
