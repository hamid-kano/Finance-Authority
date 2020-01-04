using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace Finance_Authority.PL
{
    public partial class Login_FORM : MetroFramework.Forms.MetroForm
    {
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        BL.CLS_User user = new BL.CLS_User();
        public Login_FORM()
        {
            InitializeComponent();
            Server_Name.Text = config.AppSettings.Settings["ServerName"].Value;
            User_DB.Text = config.AppSettings.Settings["UserName"].Value;
            PassWord_DB.Text = config.AppSettings.Settings["Password"].Value;

            ///
            string root = @"C:\AraratProgramFiles";
            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Program.USER_ID == -1)
            {
                Application.Exit();
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (User_Name.Text == "")
            {
                MessageBox.Show("يجب ادخال اسم المستخدم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (PassWord.Text == "")
            {
                MessageBox.Show("يجب ادخال كلمة المرور", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Server_Name.Text == "")
            {
                MessageBox.Show("يجب ادخال اسم السيرفر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (User_DB.Text == "")
            {
                MessageBox.Show("يجب ادخال اسم المستخدم الخاص بالسيرفر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (PassWord_DB.Text == "")
            {
                MessageBox.Show("يجب ادخال كلمة المرور الخاصة بالسيرفر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Program.IsServerConnected()!=0)
            {
                DataTable dt;
                if ((dt=user.User_Cheack_Athuntication(User_Name.Text, PassWord.Text)).Rows.Count>0)
                {
                    Program.USER_ID =Convert.ToInt32(dt.Rows[0][0]);
                    Program.USER_NAME = dt.Rows[0][1].ToString();
                    Program.USER_PASSWORD = dt.Rows[0][2].ToString();
                    Program.Server_Name = Server_Name.Text;
                    Program.Server_UserName = User_DB.Text;
                    Program.Server_Password = PassWord_DB.Text;
                    config.AppSettings.Settings["ServerName"].Value = Program.Server_Name;
                    config.AppSettings.Settings["UserName"].Value = Program.Server_UserName;
                    config.AppSettings.Settings["Password"].Value = Program.Server_Password;
                    config.Save(ConfigurationSaveMode.Modified, true);
                    ConfigurationManager.RefreshSection("appSettings");
                }
                else
                {
                    MessageBox.Show("يجب التأكد من اسم المستخدم وكلمة المرور الخاصة بتسجيل الدخول للبرنامج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("يجب التأكد من المعلومات الخاصة بالاتصال بالسيرفر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
        }
    }
}
