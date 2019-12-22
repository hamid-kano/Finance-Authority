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
    public partial class Document_Category_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Document_Category Doc = new BL.CLS_Document_Category();
        string tempName = "";
        public Document_Category_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            this.Document_Category_Gridview.DataSource = Doc.Document_Category_View();
            this.Document_Category_Gridview.Columns[0].Visible = false;
        }

        private void Document_Category_new_Click(object sender, EventArgs e)
        {
            Document_Category_add.Enabled = true;
            Document_Category_Name.Text = "";
            Document_Category_update.Enabled = false;
            Document_Category_delete.Enabled = false;
        }

        private void Document_Category_add_Click(object sender, EventArgs e)
        {
            if (Document_Category_Name.Text == String.Empty)
            {

                MessageBox.Show("أضف نوع السند", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable Dt = new DataTable();
            Dt = Doc.Document_Category_Cheack(Document_Category_Name.Text);
            if (Dt.Rows.Count == 0)
            {
                Doc.Document_Category_add(Document_Category_Name.Text);
                this.Document_Category_Gridview.DataSource = Doc.Document_Category_View();
                this.Document_Category_Gridview.Columns[0].Visible = false;
                Program.Add_Message();
                Document_Category_add.Enabled = false;
                Document_Category_Name.Text = "";
            }
            else
            {
                MessageBox.Show("موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            
        }

        private void Document_Category_update_Click(object sender, EventArgs e)
        {
            if (Document_Category_Name.Text == String.Empty)
            {

                MessageBox.Show("أضف نوع السند", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable Dt = new DataTable();
            Dt = Doc.Document_Category_Cheack(Document_Category_Name.Text);
            if (Dt.Rows.Count == 0 || Document_Category_Name.Text == this.Document_Category_Gridview.CurrentRow.Cells[1].Value.ToString())
            {
                Doc.Document_Category_update(Program.Category_id_id, Document_Category_Name.Text);
                this.Document_Category_Gridview.DataSource = Doc.Document_Category_View();
                this.Document_Category_Gridview.Columns[0].Visible = false;
                Program.Update_Message();
                Document_Category_Name.Text = "";
                Document_Category_update.Enabled = false;
                Document_Category_delete.Enabled = false;
            }
            else
            {
                MessageBox.Show("موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
           
        }

        private void Document_Category_Gridview_Click(object sender, EventArgs e)
        {
            if (Document_Category_Gridview.CurrentRow != null)
            {
                Program.Category_id_id = Convert.ToInt32(this.Document_Category_Gridview.CurrentRow.Cells[0].Value.ToString());
                Document_Category_Name.Text = this.Document_Category_Gridview.CurrentRow.Cells[1].Value.ToString();
                tempName= this.Document_Category_Gridview.CurrentRow.Cells[1].Value.ToString();
                Document_Category_update.Enabled = true;
                Document_Category_delete.Enabled = true;
                Document_Category_add.Enabled = false;
            }
        }

        private void Document_Category_delete_Click(object sender, EventArgs e)
        {
            if (tempName=="فاتورة" || tempName == "دفعة قرض" || tempName == "رواتب")
            {
                Program.Special_Message("لايمكن حذف هذا الصنف");
                return;
            }
            if (MessageBox.Show("هل تريد حذف صفة السند .اذا تم الحذف فسيتم حذف كافة تفاصيلها من البرنامج؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Doc.Document_Category_Delete(Program.Category_id_id);
                this.Document_Category_Gridview.DataSource = Doc.Document_Category_View();
                this.Document_Category_Gridview.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Document_Category_Name.Text = "";
                Document_Category_update.Enabled = false;
                Document_Category_delete.Enabled = false;
            }
        }

        private void Document_Category_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Document_Category_textsearch_TextChanged(object sender, EventArgs e)
        {
            this.Document_Category_Gridview.DataSource = Doc.Document_Category_Search(Document_Category_textsearch.Text);
            this.Document_Category_Gridview.Columns[0].Visible = false;
        }
    }
}
