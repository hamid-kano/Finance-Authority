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
    public partial class Office_FORM : MetroFramework.Forms.MetroForm
    {
        BL.Office Offic = new BL.Office();
        public Office_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            this.Office_Gridview.DataSource=Offic.Office_View();
            this.Office_Gridview.Columns[0].Visible = false;
            Office_CombAuthontic.DataSource = Offic.Office_Comb_Authontic();
            Office_CombAuthontic.DisplayMember = "Authority_Name";
            Office_CombAuthontic.ValueMember = "Authority_ID";
        }

        private void Office_new_Click(object sender, EventArgs e)
        {
            Office_add.Enabled = true;
            Office_Name.Text = "";
            Office_Notes.Text = "";
            Office_update.Enabled = false;
            Office_delete.Enabled = false;
        }

        private void Office_Gridview_Click(object sender, EventArgs e)
        {
            if (Office_Gridview.CurrentRow != null)
            {
                Program.Office_ID = Convert.ToInt32(this.Office_Gridview.CurrentRow.Cells[0].Value.ToString());
                Office_Name.Text = this.Office_Gridview.CurrentRow.Cells[1].Value.ToString();
                Office_Notes.Text = this.Office_Gridview.CurrentRow.Cells[2].Value.ToString();
                Office_CombAuthontic.Text = this.Office_Gridview.CurrentRow.Cells[3].Value.ToString();
                Office_update.Enabled = true;
                Office_delete.Enabled = true;
            }
        }

        private void Office_update_Click(object sender, EventArgs e)
        {
            if (Office_Name.Text == String.Empty)
            {

                MessageBox.Show("أضف أسم المكتب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable Dt = new DataTable();
            Dt = Offic.Office_Cheack(Office_Name.Text);
            if (Dt.Rows.Count == 0 || Office_Name.Text== this.Office_Gridview.CurrentRow.Cells[1].Value.ToString())
            {
                Offic.Office_update(Program.Office_ID, Office_Name.Text, Office_Notes.Text, Convert.ToInt32(Office_CombAuthontic.SelectedValue));
                this.Office_Gridview.DataSource = Offic.Office_View();
                this.Office_Gridview.Columns[0].Visible = false;
                Program.Update_Message();
                Office_update.Enabled = false;
                Office_delete.Enabled = false;
                Office_Name.Text = "";
                Office_Notes.Text = "";
            }
            else
            {
                MessageBox.Show("موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
           
        }

        private void Office_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف؟؟  ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Offic.Office_Delete(Program.Office_ID);
                this.Office_Gridview.DataSource = Offic.Office_View();
                this.Office_Gridview.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Office_update.Enabled = false;
                Office_delete.Enabled = false;
                Office_Name.Text = "";
                Office_Notes.Text = "";
            }
        }

        private void Office_add_Click_1(object sender, EventArgs e)
        {
            if (Office_Name.Text == String.Empty)
            {

                MessageBox.Show("أضف أسم المكتب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable Dt = new DataTable();
            Dt = Offic.Office_Cheack(Office_Name.Text);
            if (Dt.Rows.Count == 0)
            {
                Offic.Office_add(Office_Name.Text, Office_Notes.Text, Convert.ToInt32(Office_CombAuthontic.SelectedValue));
                this.Office_Gridview.DataSource = Offic.Office_View();
                this.Office_Gridview.Columns[0].Visible = false;
                Program.Add_Message();
                Office_update.Enabled = false;
                Office_delete.Enabled = false;
                Office_Name.Text = "";
                Office_Notes.Text = "";
            }
            else
            {
                MessageBox.Show("موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
        }

        private void Office_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Office_textsearch_TextChanged(object sender, EventArgs e)
        {
            this.Office_Gridview.DataSource = Offic.Office_Search(Office_textsearch.Text);
            this.Office_Gridview.Columns[0].Visible = false;
        }
    }
}
