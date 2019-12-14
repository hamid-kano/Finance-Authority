using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Finance_Authority.PL
{
    public partial class Document_FORM : MetroFramework.Forms.MetroForm
    {
        BL.CLS_Document Doc = new BL.CLS_Document();
        OpenFileDialog dlg = new OpenFileDialog();
        public Document_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            this.Document_Gridview.DataSource = Doc.Document_View();
            this.Document_Gridview.Columns[0].Visible = false;
        }

        private void Document_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Document_new_Click(object sender, EventArgs e)
        {
            Document_add.Enabled = true;
            Document_Name.Text = "";
            Document_Type.Text = "";
            Document_URL.Text = "";
            Document_Location.Text = "";
            Document_Extend.Text = "";
            Document_Notes.Text = "";
            Document_update.Enabled = false;
            Document_delete.Enabled = false;
        }

        private void Document_add_Click(object sender, EventArgs e)
        {
            if (Document_Name.Text == String.Empty)
            {

                MessageBox.Show("أضف اسم المستند", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Document_URL.Text == String.Empty)
            {

                MessageBox.Show("أضف رابط المستند", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Doc.Document_add(Document_Type.Text , Document_Name.Text, Document_URL.Text, Document_Location.Text , Document_Extend.Text, Document_Notes.Text);
            this.Document_Gridview.DataSource = Doc.Document_View();
            this.Document_Gridview.Columns[0].Visible = false;
            Program.Add_Message();
            Document_add.Enabled = false;
            Document_Name.Text = "";
            Document_Type.Text = "";
            Document_URL.Text = "";
            Document_Location.Text = "";
            Document_Extend.Text = "";
            Document_Notes.Text = "";
        }

        private void Document_update_Click(object sender, EventArgs e)
        {
            if (Document_Name.Text == String.Empty)
            {

                MessageBox.Show("أضف اسم المستند", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Document_URL.Text == String.Empty)
            {

                MessageBox.Show("أضف رابط المستند", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Doc.Document_update(Document_Type.Text, Document_Name.Text, Document_URL.Text, Document_Location.Text, Document_Extend.Text, Document_Notes.Text , Program.Document_id); 
            this.Document_Gridview.DataSource = Doc.Document_View();
            this.Document_Gridview.Columns[0].Visible = false;
            Program.Update_Message();
            Document_update.Enabled = false;
            Document_delete.Enabled = false;
            Document_Name.Text = "";
            Document_Type.Text = "";
            Document_URL.Text = "";
            Document_Location.Text = "";
            Document_Extend.Text = "";
            Document_Notes.Text = "";
        }

        private void Document_Gridview_Click(object sender, EventArgs e)
        {
            if (Document_Gridview.CurrentRow != null)
            {
                Program.Document_id = Convert.ToInt32(this.Document_Gridview.CurrentRow.Cells[0].Value.ToString());
                Document_Name.Text = this.Document_Gridview.CurrentRow.Cells[1].Value.ToString();
                Document_Type.Text = this.Document_Gridview.CurrentRow.Cells[2].Value.ToString();
                Document_URL.Text = this.Document_Gridview.CurrentRow.Cells[3].Value.ToString();
                Document_Location.Text = this.Document_Gridview.CurrentRow.Cells[4].Value.ToString();
                Document_Extend.Text = this.Document_Gridview.CurrentRow.Cells[5].Value.ToString();
                Document_Notes.Text = this.Document_Gridview.CurrentRow.Cells[6].Value.ToString();
                Document_update.Enabled = true;
                Document_delete.Enabled = true;
                Document_add.Enabled = false;
            }
        }

        private void Document_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف الوثيقة .اذا تم الحذف فسيتم حذف كافة تفاصيلها من البرنامج؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Doc.Document_Delete(Program.Document_id);
                this.Document_Gridview.DataSource = Doc.Document_View();
                this.Document_Gridview.Columns[0].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Document_update.Enabled = false;
                Document_delete.Enabled = false;
                Document_Name.Text = "";
                Document_Type.Text = "";
                Document_URL.Text = "";
                Document_Location.Text = "";
                Document_Extend.Text = "";
                Document_Notes.Text = "";
            }
        }

        private void Document_View_Click(object sender, EventArgs e)
        {
            dlg.ShowDialog();
            Document_URL.Text = dlg.FileName;
            Document_Name.Text = Path.GetFileName(dlg.FileName);
            Document_Type.Text = Path.GetExtension(dlg.FileName);
        }

        private void Document_Search_All_TextChanged(object sender, EventArgs e)
        {
            this.Document_Gridview.DataSource = Doc.Document_Search_All(Document_Search_All.Text);
            this.Document_Gridview.Columns[0].Visible = false;
        }
    }
}
