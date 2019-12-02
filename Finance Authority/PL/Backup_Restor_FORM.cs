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
    public partial class Backup_Restor_FORM : MetroFramework.Forms.MetroForm
    {
        SqlConnection cn = new SqlConnection(@"Server =192.168.50.50; DataBase=FinanceAuthorityDB; Integrated Security= false; USER ID =esa;PASSWORD =123");
        SqlCommand cmd;

        public Backup_Restor_FORM()
        {
            InitializeComponent();
        }

        private void Brows_Button_Click(object sender, EventArgs e)
        {
            string path = Path.GetPathRoot(Environment.SystemDirectory);
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "backup|*.bak";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                string directoryPath = System.IO.Path.GetDirectoryName(OFD.FileName);

                if (directoryPath.Contains(path))
                {
                    MessageBox.Show("يجب وضع النسخة في موقع مغاير لقرص النظام", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Backup_Restor_Path_TextBox.Text = OFD.FileName;
            }

        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Backup_Restor_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (Backup_Restor_Path_TextBox.Text != string.Empty)
                {
                    this.Cursor = Cursors.WaitCursor;
                    string strQury = " Alter DataBase FinanceAuthorityDB set offline with Rollback Immediate; Restore DataBase FinanceAuthorityDB From Disk = '" + Backup_Restor_Path_TextBox.Text + "'WITH REPLACE";
                    cmd = new SqlCommand(strQury, cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand(" Alter DataBase FinanceAuthorityDB set online with Rollback Immediate", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    //MEM.ADD_LOG(Program.APP_IDEN, Program.USER_IDEN, "استعادة نسخة احتياطية", "استعادة نسخة احتياطية", DateTime.Now);


                    MessageBox.Show("تم استعادة نسخة احتياطية بنجاح ", "نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("يجب اختيار ملف الاستعادة ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch
            {
                cn.Close();
                cn.Open();
                cmd = new SqlCommand(" Alter DataBase FinanceAuthorityDB set online with Rollback Immediate", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("يجب اختيار ملف صحيح ", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
    }
}
