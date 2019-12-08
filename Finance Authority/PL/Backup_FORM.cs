using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_Authority.PL
{
    public partial class Backup_FORM : MetroFramework.Forms.MetroForm
    {
        SqlConnection cn = new SqlConnection(@"Server =192.168.50.50 ; DataBase=FinanceAuthorityDB; Integrated Security= false; USER ID =esa;PASSWORD =123");
        SqlCommand cmd;

        public Backup_FORM()
        {
            InitializeComponent();
            this.StyleManager = Program.theme_style(this);
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Brows_Button_Click(object sender, EventArgs e)
        {
            string path = Path.GetPathRoot(Environment.SystemDirectory);
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                if (FBD.SelectedPath.Contains(path))
                {
                    MessageBox.Show("يجب اختيار موقع مغاير لقرص النظام ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Backup_Path_TextBox.Text = FBD.SelectedPath;
            }

        }

        private void Backup_Button_Click(object sender, EventArgs e)
        {
            if (Backup_Path_TextBox.Text != string.Empty)
            {
                this.Cursor = Cursors.WaitCursor;
                string filename = Backup_Path_TextBox.Text + "\\FinanceAuthorityDB" + DateTime.Now.ToShortDateString().Replace('/', '-') + "---" +
                DateTime.Now.ToLongTimeString().Replace(':', '-');
                string strQury = "Backup  DataBase FinanceAuthorityDB to Disk ='" + filename + ".bak'";
                cmd = new SqlCommand(strQury, cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

             //   MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "نسخ احتياطي", "إنشاء نسخة احتياطية", DateTime.Now);

                MessageBox.Show("تم إنشاء نسخة احتياطية بنجاح ", "نسخة احتياطية ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
            }
            else
            {
                MessageBox.Show("يجب اختيار مكان الحفظ ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }
    }
}
