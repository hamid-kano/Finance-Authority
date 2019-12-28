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
        BL.CLS_LOGS LOG = new BL.CLS_LOGS();
        int _Doc_id ;
        string _Document_Type;
        public Document_FORM(int Doc_id,string Document_Type)
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
            if (Doc_id==-1)
            {
                this.Document_Gridview.DataSource = Doc.Document_View();
                Document_new.Enabled = false;
                Document_add.Enabled = false;
            }
            else
            {
                this.Document_Gridview.DataSource = Doc.Document_View_By_Type_Id_Doc(Document_Type, Doc_id);
            }
                this.Document_Gridview.Columns[0].Visible = false;
                this.Document_Gridview.Columns[7].Visible = false;
                _Doc_id = Doc_id;
                _Document_Type = Document_Type;
                this.Document_Type.Text = _Document_Type;
        }

        private void Document_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Document_new_Click(object sender, EventArgs e)
        {
            Document_add.Enabled = true;
            Document_Name.Text = "";
            Document_URL.Text = "";
            Document_Location.Text = "";
            Document_Extend.Text = "";
            Document_Notes.Text = "";
            Document_Type.Text = _Document_Type;
            Document_update.Enabled = false;
            Document_delete.Enabled = false;
            Document_Brows_File.Enabled = false;
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
            Doc.Document_add(_Document_Type, Document_Name.Text, Document_URL.Text, Document_Location.Text , Document_Extend.Text, Document_Notes.Text, _Doc_id);
            this.Document_Gridview.DataSource = Doc.Document_View_By_Type_Id_Doc(_Document_Type, _Doc_id);
            this.Document_Gridview.Columns[0].Visible = false;
            this.Document_Gridview.Columns[7].Visible = false;
            Program.Add_Message();
            LOG.LOGS_add(Program.USER_ID, "اضافة", "اضافة وثيقة جديدة", DateTime.Now);
            Document_add.Enabled = false;
            Document_Name.Text = "";
            Document_URL.Text = "";
            Document_Type.Text = _Document_Type;
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
            Doc.Document_update(_Document_Type, Document_Name.Text, Document_URL.Text, Document_Location.Text, Document_Extend.Text, Document_Notes.Text, _Doc_id, Program.Document_id);
            this.Document_Gridview.DataSource = Doc.Document_View_By_Type_Id_Doc(_Document_Type, _Doc_id);
            this.Document_Gridview.Columns[0].Visible = false;
            this.Document_Gridview.Columns[7].Visible = false;
            Program.Update_Message();
            LOG.LOGS_add(Program.USER_ID, "تعديل", "تعديل وثيقة", DateTime.Now);
            Document_update.Enabled = false;
            Document_delete.Enabled = false;
            Document_Brows_File.Enabled = false;
            Document_Name.Text = "";
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
                _Document_Type = this.Document_Gridview.CurrentRow.Cells[2].Value.ToString();
                Document_Type.Text= this.Document_Gridview.CurrentRow.Cells[2].Value.ToString();
                Document_URL.Text = this.Document_Gridview.CurrentRow.Cells[3].Value.ToString();
                Document_Location.Text = this.Document_Gridview.CurrentRow.Cells[4].Value.ToString();
                Document_Extend.Text = this.Document_Gridview.CurrentRow.Cells[5].Value.ToString();
                Document_Notes.Text = this.Document_Gridview.CurrentRow.Cells[6].Value.ToString();
                _Doc_id= Convert.ToInt32(this.Document_Gridview.CurrentRow.Cells[7].Value);

                if (Document_new.Enabled)
                {
                    Document_update.Enabled = true;
                    Document_delete.Enabled = true;
                    Document_add.Enabled = false;
                }
                Document_Brows_File.Enabled = true;
            }
        }

        private void Document_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف الوثيقة .اذا تم الحذف فسيتم حذف كافة تفاصيلها من البرنامج؟؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Doc.Document_Delete(Program.Document_id);
                this.Document_Gridview.DataSource = Doc.Document_View_By_Type_Id_Doc(_Document_Type, _Doc_id);
                this.Document_Gridview.Columns[0].Visible = false;
                this.Document_Gridview.Columns[7].Visible = false;
                MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LOG.LOGS_add(Program.USER_ID, "حذف", "حذف وثيقة", DateTime.Now);
                Document_update.Enabled = false;
                Document_delete.Enabled = false;
                Document_Brows_File.Enabled = false;
                Document_Name.Text = "";
                Document_URL.Text = "";
                Document_Location.Text = "";
                Document_Extend.Text = "";
                Document_Notes.Text = "";
            }
        }

        private void Document_View_Click(object sender, EventArgs e)
        {
            if (dlg.ShowDialog()==DialogResult.OK)
            {
                Document_URL.Text = Path.GetFullPath(dlg.FileName);
                Document_Extend.Text = Path.GetExtension(dlg.FileName);
            }
        }

        private void Document_Search_All_TextChanged(object sender, EventArgs e)
        {
            if (Document_new.Enabled)
            {
                this.Document_Gridview.DataSource = Doc.Document_View_By_Type_Id_Doc_SearchAll(_Document_Type, _Doc_id,Document_Search_All.Text);
                this.Document_Gridview.Columns[0].Visible = false;
                this.Document_Gridview.Columns[7].Visible = false;
            }
            else
            {
                this.Document_Gridview.DataSource = Doc.Document_Search_All(Document_Search_All.Text);
                this.Document_Gridview.Columns[0].Visible = false;
                this.Document_Gridview.Columns[7].Visible = false;
                Document_View.Enabled = false;
                Document_add.Enabled = false;
                Document_update.Enabled = false;
                Document_new.Enabled = false;
            }
        }

        private void Document_Brows_File_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Document_URL.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("الملحق غير موجود في مساره الصحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
